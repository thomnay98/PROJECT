using QLCT.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace QLCT.Interface
{
    public interface ITypeOfIncome
    {
        ObservableCollection<TypeOfIncome> GetTypeIn();
        TypeOfIncome GetTypeInById(int IDIn);
        bool Insert(TypeOfIncome ti);
        bool Update(TypeOfIncome ti);
        bool Delete(TypeOfIncome ti);
    }
}
