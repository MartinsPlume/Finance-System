using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceSystem.models;

namespace FinanceSystem.forms
{
    public partial class ProductControl : Form
    {
        IEnumerable<Product> products;
        

        public ProductControl()
        {
            InitializeComponent();
            RefreshTable();
        }

        void RefreshTable()
        {
            products = GetProductData();
            dataGridViewProducts.DataSource = products;
        }

        IEnumerable<Product> GetProductData()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44361//");
            HttpResponseMessage response = client.GetAsync("api/product").Result;

            return response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
        }

        async void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
            e.RowIndex >= 0)
            {
                int id = Int32.Parse((dataGridViewProducts[2, e.RowIndex].Value).ToString());
                foreach (var product in products)
                {
                    if (id.Equals(product.ProductId))
                    {
                        if (e.ColumnIndex == 0)
                        {
                            EditProduct editProduct = new EditProduct(product);
                            editProduct.Show();
                        }
                        else if (e.ColumnIndex == 1)
                        {
                            DialogResult dialogResult = MessageBox.Show("Confirm deleting " + product.ProductName + "!", "Are You sure?", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                Console.WriteLine(await DeleteProductAsync(product.ProductId.ToString()));
                            }
                        }


                    }
                }
            }
        }

        static async Task<HttpStatusCode> DeleteProductAsync(string id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44361//");
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/product/{id}");
            return response.StatusCode;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            EditProduct editProduct = new EditProduct();
            editProduct.Show();
        }
    }
}
