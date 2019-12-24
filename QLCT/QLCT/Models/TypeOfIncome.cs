using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace QLCT.Models
{
    public class TypeOfIncome
    {
        [PrimaryKey, AutoIncrement]
        public int IDIn { get; set; }
        public string TitleIn { get; set; }
    }
}
