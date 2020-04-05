using System;
using System.Windows.Forms;
using FinanceSystem.models;

namespace FinanceSystem.forms
{
    public partial class EditProduct : Form
    {
        private readonly bool _newProduct;
        private readonly Product _product = new Product();

        public EditProduct(Product editProduct)
        {
            InitializeComponent();
            try
            {
                Text = editProduct.ProductName;
                _product.ProductId = editProduct.ProductId;
                textBoxProductName.Text = editProduct.ProductName;
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
            _newProduct = true;
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private void checkBoxConfirmChanges_CheckedChanged(object sender, EventArgs e)
        {
            if (!buttonSaveChanges.Visible)
            {
                _product.ProductName = textBoxProductName.Text;
                _product.ProductCode = textBoxProductCode.Text;
                _product.Price = Convert.ToSingle(numericUpDownPrice.Value);
                _product.RetailPrice = Convert.ToSingle(numericUpDownRetail.Value);
                _product.Weight = Convert.ToInt32(numericUpDownWeight.Value);
                _product.ProductStock = Convert.ToInt32(numericUpDownStock.Value);
                _product.ProductReserved = Convert.ToInt32(numericUpDownReserved.Value);

                if (!(!string.IsNullOrEmpty(_product.ProductName) |
                      !string.IsNullOrEmpty(_product.ProductCode) |
                      !_product.Price.Equals(0) |
                      !_product.RetailPrice.Equals(0) |
                      !_product.Weight.Equals(0)))
                {
                    MessageBox.Show("Fill out all fields!");
                    checkBoxConfirmChanges.Checked = false;
                }
                else
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
            }
            else
            {
                buttonSaveChanges.Visible = false;
            }
        }

        private async void buttonSaveChanges_ClickAsync(object sender, EventArgs e)
        {
            if (_newProduct)
            {
                await HttpService.CreateProductAsync(_product);
            }
            else
            {
                await HttpService.UpdateProductAsync(_product);
            }

            this.Close();
        }
    }
}