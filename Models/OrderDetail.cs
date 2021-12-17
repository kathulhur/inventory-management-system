using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class OrderDetail
    {
        public string OrderDetailId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Size { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public decimal Total { get; set; }
        public  DateTime Date { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}
