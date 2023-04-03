using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Contact
    {
        public int Contact_ID { get; set; }
        public string Name_Family { get; set; }
        public string ContactNumber { get; set; }
        public string ContactSubject { get; set; }
        public string ContactBody { get; set; }
        public string Send_Date { get; set; }
    }
}
