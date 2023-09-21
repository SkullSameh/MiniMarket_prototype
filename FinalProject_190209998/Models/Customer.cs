using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_190209998.Models
{
    public class Customer
    {
        [PrimaryKey , AutoIncrement] public int Cust_ID { get; set; }

        public string Cust_Name { get; set; }
        public string Cust_Email { get; set; }
        public string Cust_Phone { get; set; }
        public string Cust_Address { get; set; }
    }
}
