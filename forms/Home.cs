using System;
using System.Windows.Forms;

namespace FinanceSystem.forms
{
    public partial class Home : Form
    {
        private OrderControl _orderControl;
        private ProductControl _productControl;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void buttonProductControl_Click(object sender, EventArgs e)
        {
            _productControl = new ProductControl();
            _productControl.Show();
        }

        private void buttonOrderControl_Click(object sender, EventArgs e)
        {
            _orderControl = new OrderControl();
            _orderControl.Show();
        }
    }
}