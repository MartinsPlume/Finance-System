using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace FinanceSystem
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
