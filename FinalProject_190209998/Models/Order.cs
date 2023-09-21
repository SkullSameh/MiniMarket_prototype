using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace FinalProject_190209998.Models
{
    public class Order
    {
        [PrimaryKey , AutoIncrement] public int Ord_ID { get; set; }

        public Models.Customer Cust { protected get;  set; }

        public Models.Peoduct Pro { protected get;  set; }

        public string Ord_Pro { get; set; }
        public int Ord_Pro_Price { get; set; }

        public int Ord_Price { get; set; }
    }
}
