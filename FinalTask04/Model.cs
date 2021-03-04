using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace FinalTask4
{
    public class Model
    {
        public class Order
        {
            public int OrderID { get; set; }

            [Required]
            public string Product { get; set; }

            [Required]
            public int Quantity { get; set; }

            [Required]
            public int Price { get; set; }

            [Required]
            public string DeliveryType { get; set; }

            public string Address { get; set; }

            [Required]
            public string PaymentType { get; set; }

            [Required]
            public DateTime OrderDate { get; set; }
        }
    }
}