using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCT.Models
{
    public class TypeOfExpense
    {
        [PrimaryKey, AutoIncrement]
        public int IDEx { get; set; }
        public string TitleEx { get; set; }
    }
}
