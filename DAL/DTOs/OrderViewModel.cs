using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DTOs
{
    public class OrderViewModel
    {
        public long Order__ID { get; set; }
        //HomeRepair
        public int Device_Type { get; set; }
        public string Device_Type_Desc { get; set; }
        public int Brand { get; set; }
        public string Brand_Desc { get; set; }

        public string Order_Desc { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Order_PhoneNumber { get; set; }
        public int Order_State { get; set; }
        public string Order_State_Desc { get; set; }
        public string Order_Request_Date { get; set; }
        public string Order_Repair_Date { get; set; }
        public long User_ID { get; set; }
        public string Order_Code { get; set; }
        public long User__ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Instagram { get; set; }
        public string Email { get; set; }
        public string JoinDate { get; set; }
        public bool IsAdmin { get; set; }

        public int BuildServiceType { get; set; }

        public string BuildServiceType_Desc { get; set; }

        public int OrderType { get; set; }
        public string OrderType_Desc { get; set; }

        public List<Order> Orders { set; get; }
    }
}
