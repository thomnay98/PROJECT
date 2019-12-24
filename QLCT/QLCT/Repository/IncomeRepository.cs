using QLCT.Helpers;
using QLCT.Interface;
using QLCT.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace QLCT.Repository
{
    public class IncomeRepository : ITypeOfIncome
    {
        Database db;
        public IncomeRepository()
        {
            db = new Database();
        }

        public ObservableCollection<TypeOfIncome> GetTypeIn()
        {
            return new ObservableCollection<TypeOfIncome>(db.GetTypeIn());
        }

        public TypeOfIncome GetTypeInById(int IDIn)
        {
            return db.GetTypeInById(IDIn);
        }

        public bool Insert(TypeOfIncome ti)
        {
            return db.InsertTypeIn(ti);
        }

        public bool Update(TypeOfIncome ti)
        {
            return db.UpdateTypeIn(ti);
        }

        public bool Delete(TypeOfIncome ti)
        {
            return db.DeleteTypeIn(ti);
        }
    }
}
