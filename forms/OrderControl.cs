using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceSystem.models;

namespace FinanceSystem.forms
{
    public partial class OrderControl : Form
    {
        IEnumerable<Order> orders;
        IEnumerable<Product> products;

        public OrderControl()
        {
            InitializeComponent();
            RefreshTable();
            products = GetProductData();
        }

        void RefreshTable()
        {
            orders = GetOrderData();
            dataGridViewOrders.DataSource = orders;
            products = GetProductData();
        }

        IEnumerable<Order> GetOrderData()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44361//");
            HttpResponseMessage response = client.GetAsync("api/order").Result;
            return response.Content.ReadAsAsync<IEnumerable<Order>>().Result;
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //    var senderGrid = (DataGridView)sender;
        //    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn &&
        //        e.RowIndex >= 0)
        //    {
        //        if (e.ColumnIndex == 0)
        //        {
        //            int id = Int32.Parse(dataGridViewOrders[1, e.RowIndex].Value.ToString());
        //            foreach (var order in orders)
        //            {
        //                if (id.Equals(order.OrderId))
        //                {
        //                    Console.WriteLine(order.OrderId);
        //                }
        //                else
        //                {
        //                    Console.WriteLine(id);
        //                }
        //            }
        //        }
        //    }
        }

        private async void buttonInvoice_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewOrders.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value)){
                    int id = int.Parse(dataGridViewOrders[1, row.Index].Value.ToString());
                    foreach(var order in orders)
                    {
                        if (id == order.OrderId && order.Status!="Invoiced")
                        {
                            try { 
                                await UpdateOrderAsync(order);
                                SendInvoice(order);
                                Console.WriteLine("Shipment invoiced!");
                                foreach(var product in products)
                                {
                                    if (product.ProductId == order.ProductId)
                                    {
                                        Product updateProduct = new Product();
                                        updateProduct.ProductId = product.ProductId;
                                        updateProduct.ProductName = product.ProductName;
                                        updateProduct.ProductCode = product.ProductCode;
                                        updateProduct.Price = product.Price;
                                        updateProduct.RetailPrice = product.RetailPrice;
                                        updateProduct.Weight = product.Weight;
                                        updateProduct.ProductStock = product.ProductStock;
                                        updateProduct.ProductReserved = product.ProductReserved-1;

                                        await UpdateProductAsync(updateProduct);
                                    }
                                }
                            }
                            catch (Exception invoicingFail)
                            {
                                Console.WriteLine("Invoicing failed " + invoicingFail);
                            }
                        }
                    }
                }
            }
        }

        void SendInvoice(Order order)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("mail.inbox.lv");

                mail.From = new MailAddress("kursadarbsprogrammesana@inbox.lv");
                mail.To.Add(order.email);
                mail.Subject = "Invoice number " +order.OrderId.ToString();
                mail.Body = "Dear " + order.Name.ToString() +"!"
                    + Environment.NewLine +
                    "Your order will be delivered to postal code" + order.PostalCode+ " !";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("kursadarbsprogrammesana@inbox.lv", "WHM757Tgra");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Console.WriteLine("Email Sent!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        IEnumerable<Product> GetProductData()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44361//");
            HttpResponseMessage response = client.GetAsync("api/product").Result;

            return response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
        }

        static async Task<Product> UpdateProductAsync(Product product)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44361/");
            HttpResponseMessage response = await client.PutAsJsonAsync(
            $"api/product/{product.ProductId}", product);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            product = await response.Content.ReadAsAsync<Product>();
            return product;
        }

        static async Task<Order> UpdateOrderAsync(Order oldOrder)
        {
            Order order = new Order();
            order.OrderId = oldOrder.OrderId;
            order.Name = oldOrder.Name;
            order.email = oldOrder.email;
            order.PostalCode = oldOrder.PostalCode;
            order.Status = "Invoiced";
            order.ProductId = oldOrder.ProductId;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44361/");
            HttpResponseMessage response = await client.PutAsJsonAsync(
            $"api/order/{oldOrder.OrderId}", order);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            order = await response.Content.ReadAsAsync<Order>();
            return order;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
