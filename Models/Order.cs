using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public string Details { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public int CustomerId{ get; set; }
        public Customer Customer { get; set; }

    }
}
