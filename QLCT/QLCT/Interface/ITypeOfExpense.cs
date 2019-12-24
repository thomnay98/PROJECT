using QLCT.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace QLCT.Interface
{
    public interface ITypeOfExpense
    {
        ObservableCollection<TypeOfExpense> GetTypeEx();
        TypeOfExpense GetTypeExById(int IDEx);
        bool Insert(TypeOfExpense te);
        bool Update(TypeOfExpense te);
        bool Delete(TypeOfExpense te);
    }
}
