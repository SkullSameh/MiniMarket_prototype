using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace FinalProject_190209998.Models
{
   public class Payment
    {
        [PrimaryKey , AutoIncrement] public int Pay_ID { get; set; }

        public int Pay_amt { get; set; }
        public DateTime Date { get; set; }
    }
}
