using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QLCT.Models
{
    class AddTransactionDetail
    {
        public double Spent { get; set; }
        public CategoryPicker Category { get; set; }
        [Display(Name = "Mô tả khoản chi")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mô tả không được để trống")]
        public string ExpenseDescription { get; set; }

        public DateTime Date { get; set; }

        public enum CategoryPicker
        {
            Home,
            Entertainment,
            Food,
            Charity,
            Utilities,
            Auto,
            Education,
            HelathAndWellness,
            Shopping
        };
    }
}
