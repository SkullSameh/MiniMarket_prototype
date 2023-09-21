using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace FinalProject_190209998.Models
{
    public class Peoduct
    {
        [PrimaryKey , AutoIncrement] public int Pro_ID { get; set; }

        public string Pro_Name { get; set; }
        public string Pro_IMG { get; set; }
        public int Pro_Price { get; set; }
    }
}
