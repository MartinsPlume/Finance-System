using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FinanceSystem.models;

namespace FinanceSystem.forms
{
    public partial class ProductControl : Form
    {
        private IEnumerable<Product> _products;

        public ProductControl()
        {
            InitializeComponent();
            RefreshTable();
        }

        private void RefreshTable()
        {
            _products = HttpClientService.GetProductData();
            dataGridViewProducts.DataSource = _products;
        }

        private async void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (!(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) || e.RowIndex < 0) return;
            var id = int.Parse((dataGridViewProducts[2, e.RowIndex].Value).ToString());
            foreach (var product in _products)
            {
                if (!id.Equals(product.ProductId)) continue;
                switch (e.ColumnIndex)
                {
                    case 0:
                    {
                        var editProduct = new EditProduct(product);
                        editProduct.Show();
                        break;
                    }
                    case 1:
                    {
                        var dialogResult = MessageBox.Show("Confirm deleting " + product.ProductName + "!", "Are You sure?", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Console.WriteLine(await HttpClientService.DeleteProductAsync(product.ProductId.ToString()));
                        }
                        break;
                    }
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            var editProduct = new EditProduct();
            editProduct.Show();
        }
    }
}
