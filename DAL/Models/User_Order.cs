using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class User_Order
    {
        public long User_Order_ID { get; set; }
        public long Order_ID { get; set; }
        public long User_ID { get; set; }
    }
}
