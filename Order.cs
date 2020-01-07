using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSystem
{
    class Order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public int PostalCode { get; set; }
        public int ProductId { get; set; }
        public string Status { get; set; }
        public object JsonConvert { get; internal set; }
    }
}
