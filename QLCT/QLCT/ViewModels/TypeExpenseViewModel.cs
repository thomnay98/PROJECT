using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using QLCT.Interface;
using QLCT.Models;
using QLCT.Repository;
using Xamarin.Forms;

namespace QLCT.ViewModels
{
    public class TypeExpenseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));

            }
        }
        private TypeOfExpense te;
        public ITypeOfExpense expenseRepository;
        public ICommand AddTypeEx { get; private set; }
        public ICommand UpdateTypeEx { get; private set; }
        public ICommand DeleteTypeEx { get; private set; }
        private void Insert()
        {
            expenseRepository.Insert(te);
            LoadTypeEx();
        }

        private void Update()
        {
            expenseRepository.Update(te);
            LoadTypeEx();
        }

        private void Delete()
        {
            expenseRepository.Delete(te);
            LoadTypeEx();
        }

        public TypeOfExpense TypeExpense
        {
            get { return te; }
            set
            {
                te = value;
                RaisePropertyChanged("TypeExpense");
                ((Command)UpdateTypeEx).ChangeCanExecute();
            }
        }

        private bool CanExe()
        {
            if (TypeExpense == null || TypeExpense.IDEx == 0) return false;
            return true;
        }

        public int IDEx
        {
            get { return te.IDEx; }
            set
            {
                te.IDEx = value;
                RaisePropertyChanged("IDEx");
            }
        }

        public string TitleEx
        {
            get { return te.TitleEx; }
            set
            {
                te.TitleEx = value;
                RaisePropertyChanged("TitleEx");
            }
        }

        ObservableCollection<TypeOfExpense> expenseCateList;

        public ObservableCollection<TypeOfExpense> ExpenseCateList
        {
            get { return expenseCateList; }
            set
            {
                expenseCateList = value;
                RaisePropertyChanged("ExpenseCateList");
            }
        }


        void LoadTypeEx()
        {
            ExpenseCateList = expenseRepository.GetTypeEx();
        }

        public TypeExpenseViewModel()
        {
            expenseRepository = new ExpenseRepository();
            LoadTypeEx();
            AddTypeEx = new Command(Insert);
            UpdateTypeEx = new Command(Update, CanExe);
            DeleteTypeEx = new Command(Delete, CanExe);
            te = new TypeOfExpense();
        }
    }
}
