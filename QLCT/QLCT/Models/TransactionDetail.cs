using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QLCT
{
    public class TransactionDetail
    {
        [PrimaryKey, AutoIncrement]
        [Display(AutoGenerateField = false)]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public double Spent { get; set; }
        public DateTime Date { get; set; }
    }
}
