using System;
using System.Windows.Forms;

namespace FinanceSystem.forms
{
    public partial class Home : Form
    {
        public OrderControl orderControl;
        public ProductControl productControl;
        public Home()
        {
            InitializeComponent();
        }

        void Home_Load(object sender, EventArgs e)
        {

        }

        public void buttonProductControl_Click(object sender, EventArgs e)
        {
            productControl = new ProductControl();
            productControl.Show();
        }

        public void buttonOrderControl_Click(object sender, EventArgs e)
        {
            orderControl = new OrderControl();
            orderControl.Show();
        }
    }
}
