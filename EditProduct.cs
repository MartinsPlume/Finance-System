using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceSystem
{
    public partial class EditProduct : Form
    {
        bool newProduct = false;

        Product product = new Product();
        

        static HttpClient client = new HttpClient();

        public EditProduct(Product editProduct)
        {
            
            InitializeComponent();
            try {
                Text = editProduct.ProductName;
                product.ProductId = editProduct.ProductId;
                textBoxProductName.Text= editProduct.ProductName;
                textBoxProductCode.Text = editProduct.ProductCode;
                numericUpDownPrice.Value = Convert.ToDecimal(editProduct.Price);
                numericUpDownRetail.Value = Convert.ToDecimal(editProduct.RetailPrice);
                numericUpDownWeight.Value = Convert.ToDecimal(editProduct.Weight);
                numericUpDownStock.Value = Convert.ToDecimal(editProduct.ProductStock);
                numericUpDownReserved.Value = Convert.ToDecimal(editProduct.ProductReserved);
            }
            catch (Exception e)
            {
                Console.WriteLine("Setting values failed " + e);
            }
        }

        public EditProduct()
        {
            Text = "New Product";
            InitializeComponent();
            newProduct = true;
        }

        private void checkBoxConfirmChanges_CheckedChanged(object sender, EventArgs e)
        {
            if (!buttonSaveChanges.Visible)
            {
                product.ProductName = textBoxProductName.Text.ToString();
                product.ProductCode = textBoxProductCode.Text.ToString();
                product.Price = Convert.ToSingle(numericUpDownPrice.Value);
                product.RetailPrice = Convert.ToSingle(numericUpDownRetail.Value);
                product.Weight = Convert.ToInt32(numericUpDownWeight.Value);
                product.ProductStock = Convert.ToInt32(numericUpDownStock.Value);
                product.ProductReserved = Convert.ToInt32(numericUpDownReserved.Value);

                if (!string.IsNullOrEmpty(product.ProductName) |
                    !string.IsNullOrEmpty(product.ProductCode) |
                    !product.Price.Equals(0) |
                    !product.RetailPrice.Equals(0) |
                    !product.Weight.Equals(0))
                {
                    try
                    {
                        buttonSaveChanges.Visible = true;
                    }
                    catch (Exception jsonError)
                    {
                        Console.WriteLine("Error converting to Json " + jsonError);
                    }

                    
                }
                else
                {
                    MessageBox.Show("Fill out all fields!");
                    checkBoxConfirmChanges.Checked = false;
                }
                  
                
            }
            else
            {
                buttonSaveChanges.Visible = false;
            }
        }

        private async void buttonSaveChanges_ClickAsync(object sender, EventArgs e)
        {
            if (newProduct)
            {
                await CreateProductAsync(product);
            }
            else
            {
                await UpdateProductAsync(product);
            }
            this.Close();
        }

        static async Task<Uri> CreateProductAsync(Product product)
        {
            client.BaseAddress = new Uri("https://localhost:44361/");
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/product", product);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        static async Task<Product> UpdateProductAsync(Product product)
        {
            client.BaseAddress = new Uri("https://localhost:44361/");
            HttpResponseMessage response = await client.PutAsJsonAsync(
            $"api/product/{product.ProductId}", product);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            product = await response.Content.ReadAsAsync<Product>();
            return product;
        }
    }
}
