using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCT.Models
{
    public class Income
    {
        [PrimaryKey, AutoIncrement]
        public int IDI { get; set; }
        public int IDIn { get; set; }
        public string NameIn { get; set; }
        public string DateIn { get; set; }
        public string DescriptionIn { get; set; }
        public double PriceIn { get; set; }
    }
}
