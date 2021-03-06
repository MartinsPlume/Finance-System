﻿namespace FinanceSystem.models
{
    public class Order
    {
        public int OrderId { get; set; }
        
        public string Name { get; set; }
        
        public string Email { get; set; }
        
        public int PostalCode { get; set; }
        
        public int ProductId { get; set; }
        
        public string Status { get; set; }
        
        public object JsonConvert { get; internal set; }
    }
}
