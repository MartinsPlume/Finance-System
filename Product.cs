using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSystem
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public float Price { get; set; }
        public float RetailPrice { get; set; }
        public int Weight { get; set; }
        public int ProductStock { get; set; }
        public int ProductReserved { get; set; }
    }

}
