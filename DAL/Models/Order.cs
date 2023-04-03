using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Order
    {
        public long Order__ID { get; set; }
        public int OrderType { get; set; }

        //HomeRepair
        public int Device_Type { get; set; }
        public int Brand { get; set; }
        //BuldType
        public int BuildServiceType { get; set; }

        public string Order_Desc { get; set; }
        //استان
        public string State { get; set; }
        public string Address { get; set; }

        public string Order_PhoneNumber { get; set; }
        public int Order_State { get; set; }
        public string Order_Request_Date { get; set; }
        public string Order_Repair_Date { get; set; }
        public long User_ID { get; set; }
        public string Order_Code { get; set; }
    }
}
