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
        private IEnumerable<Order> _orders;
        private IEnumerable<Product> _products;

        public OrderControl()
        {
            InitializeComponent();
            RefreshTable();
            _products = HttpClientService.GetProductData();
        }

        void RefreshTable()
        {
            _orders = HttpClientService.GetOrderData();
            dataGridViewOrders.DataSource = _orders;
            _products = HttpClientService.GetProductData();
        }

        private async void buttonInvoice_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewOrders.Rows)
            {
                if (!Convert.ToBoolean(row.Cells[0].Value)) continue;
                var id = int.Parse(dataGridViewOrders[1, row.Index].Value.ToString());
                foreach(var order in _orders)
                {
                    if (id != order.OrderId || order.Status == "Invoiced") continue;
                    try { 
                        await HttpClientService.UpdateOrderAsync(order);
                        SendInvoice(order);
                        Console.WriteLine("Shipment invoiced!");
                        foreach(var product in _products)
                        {
                            if (product.ProductId != order.ProductId) continue;
                            var updateProduct = new Product
                            {
                                ProductId = product.ProductId,
                                ProductName = product.ProductName,
                                ProductCode = product.ProductCode,
                                Price = product.Price,
                                RetailPrice = product.RetailPrice,
                                Weight = product.Weight,
                                ProductStock = product.ProductStock,
                                ProductReserved = product.ProductReserved - 1
                            };

                            await HttpClientService.UpdateProductAsync(updateProduct);
                        }
                    }
                    catch (Exception invoicingFail)
                    {
                        Console.WriteLine("Invoicing failed " + invoicingFail);
                    }
                }
            }
        }

        private static void SendInvoice(Order order)
        {
            var invoiceMail = new InvoiceMail(order.email, order.OrderId, order.Name, order.PostalCode);
            try
            {
                invoiceMail.SendInvoiceMail();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
