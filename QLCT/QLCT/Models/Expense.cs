using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCT.Models
{
    public class Expense
    {
        [PrimaryKey, AutoIncrement]
        public int IDE { get; set; }
        public int IDEx { get; set; }
        public string NameEx { get; set; }
        public string DateEx { get; set; }
        public string DescriptionEx { get; set; }
        public double PriceEx { get; set; }
    }
}
