using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Payment
    {
        public int PaymentId { get; set; }
        public string PaymentType { get; set; }
        public string OtherDetails { get; set; }
    }
}
