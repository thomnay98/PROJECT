using QLCT.Helpers;
using QLCT.Interface;
using QLCT.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace QLCT.Repository
{
    public class ExpenseRepository : ITypeOfExpense
    {
        Database db;
        public ExpenseRepository()
        {
            db = new Database();
        }

        public ObservableCollection<TypeOfExpense> GetTypeEx()
        {
            return new ObservableCollection<TypeOfExpense>(db.GetTypeEx());
        }

        public TypeOfExpense GetTypeExById(int IDEx)
        {
            return db.GetTypeExById(IDEx);
        }

        public bool Insert(TypeOfExpense te)
        {
            return db.InsertTypeEx(te);
        }

        public bool Update(TypeOfExpense te)
        {
            return db.UpdateTypeEx(te);
        }

        public bool Delete(TypeOfExpense te)
        {
            return db.DeleteTypeEx(te);
        }
    }
}
