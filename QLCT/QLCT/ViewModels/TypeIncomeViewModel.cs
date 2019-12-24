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
    public class TypeIncomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));

            }
        }
        private TypeOfIncome ti;
        public ITypeOfIncome incomeRepository;
        public ICommand AddTypeIn { get; private set; }
        public ICommand UpdateTypeIn { get; private set; }
        public ICommand DeleteTypeIn { get; private set; }
        private void Insert()
        {
            incomeRepository.Insert(ti);
            LoadTypeIn();
        }

        private void Update()
        {
            incomeRepository.Update(ti);
            LoadTypeIn();
        }

        private void Delete()
        {
            incomeRepository.Delete(ti);
            LoadTypeIn();
        }

        public TypeOfIncome TypeIncome
        {
            get { return ti; }
            set
            {
                ti = value;
                RaisePropertyChanged("TypeIncome");
                ((Command)UpdateTypeIn).ChangeCanExecute();
            }
        }

        private bool CanExe()
        {
            if (TypeIncome == null || TypeIncome.IDIn == 0) return false;
            return true;
        }

        public int IDIn
        {
            get { return ti.IDIn; }
            set
            {
                ti.IDIn = value;
                RaisePropertyChanged("IDIn");
            }
        }

        public string TitleEx
        {
            get { return ti.TitleIn; }
            set
            {
                ti.TitleIn = value;
                RaisePropertyChanged("TitleIn");
            }
        }

        ObservableCollection<TypeOfIncome> incomeCateList;

        public ObservableCollection<TypeOfIncome> IncomeCateList
        {
            get { return incomeCateList; }
            set
            {
                incomeCateList = value;
                RaisePropertyChanged("IncomeCateList");
            }
        }


        void LoadTypeIn()
        {
            IncomeCateList = incomeRepository.GetTypeIn();
        }

        public TypeIncomeViewModel()
        {
            incomeRepository = new IncomeRepository();
            LoadTypeIn();
            AddTypeIn = new Command(Insert);
            UpdateTypeIn = new Command(Update, CanExe);
            DeleteTypeIn = new Command(Delete, CanExe);
            ti = new TypeOfIncome();
        }
    }
}
