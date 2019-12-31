using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace QLCT
{
    public class DataService
    {
        private readonly SQLiteConnection db;

        internal ObservableCollection<TransactionDetail> GetTransactions()
        {
            return new ObservableCollection<TransactionDetail>(db.Table<TransactionDetail>());
        }

        internal ObservableCollection<ExpenseCategory> GetCategories()
        {
            return new ObservableCollection<ExpenseCategory>(db.Table<ExpenseCategory>());
        }

        internal void InsertTansaction(TransactionDetail transaction)
        {
            db.Insert(transaction);
        }

        private List<ExpenseCategory> getExpenses()
        {
            var expenseCategories = new List<ExpenseCategory>()
            {
                new ExpenseCategory {Name = "Home", Budget = 250},
                new ExpenseCategory {Name = "Entertainment", Budget = 500},
                new ExpenseCategory {Name = "Food", Budget = 700},
                new ExpenseCategory {Name = "Charity", Budget = 650},
                new ExpenseCategory {Name = "Utilities", Budget = 600},
                new ExpenseCategory {Name = "Transport", Budget = 500},
                new ExpenseCategory {Name = "Education", Budget = 550},
                new ExpenseCategory {Name = "Health & Wellness", Budget = 700},
                new ExpenseCategory {Name = "Shopping", Budget = 350}
            };
            return expenseCategories;
        }

        private List<TransactionDetail> getTransactions()
        {
            var transactionDetails = new List<TransactionDetail>()
            {
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 1),
                    Name = "Home Mortgage",
                    Category = "Home",
                    Spent = 15.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 10),
                    Name = "Home Insurance",
                    Category = "Home",
                    Spent = 10.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 13),
                    Name = "Paint",
                    Category = "Home",
                    Spent = 12.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 18),
                    Name = "Home Mortgage",
                    Category = "Home",
                    Spent = 150.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 25),
                    Name = "Home Insurance",
                    Category = "Home",
                    Spent = 10.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 1),
                    Name = "Karate classes",
                    Category = "Entertainment",
                    Spent = 11.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 18),
                    Name = "Swimming classes",
                    Category = "Entertainment",
                    Spent = 10.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 4),
                    Name = "Cable TV",
                    Category = "Entertainment",
                    Spent = 44.99
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 15),
                    Name = "Bowling",
                    Category = "Entertainment",
                    Spent = 40.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 1),
                    Name = "Groceries",
                    Category = "Food",
                    Spent = 90.85
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 16),
                    Name = "Pizza",
                    Category = "Food",
                    Spent = 18.75
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 17),
                    Name = "Italian retaurant",
                    Category = "Food",
                    Spent = 45.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 11),
                    Name = "Chinese restaurant meal",
                    Category = "Food",
                    Spent = 70.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 20),
                    Name = "Groceries",
                    Category = "Food",
                    Spent = 100.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 21),
                    Name = "Fried Chicken Take Out",
                    Category = "Food",
                    Spent = 20.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 22),
                    Name = "Pizza",
                    Category = "Food",
                    Spent = 15.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 23),
                    Name = "Donuts",
                    Category = "Food",
                    Spent = 17.000
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 23),
                    Name = "Groceries",
                    Category = "Food",
                    Spent = 12.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 29),
                    Name = "Groceries",
                    Category = "Food",
                    Spent = 6.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 2, 1),
                    Name = "Groceries",
                    Category = "Food",
                    Spent = 3.85
                },
                 new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 2),
                    Name = "Monthly Charity donation",
                    Category = "Charity",
                    Spent = 10.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 2, 2),
                    Name = "Monthly Charity donation",
                    Category = "Charity",
                    Spent = 10.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 2, 1),
                    Name = "Food Bank Donation",
                    Category = "Charity",
                    Spent = 50.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 3, 1),
                    Name = "Food Bank Donation",
                    Category = "Charity",
                    Spent = 10.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 3, 1),
                    Name = "Monthly Charity donation",
                    Category = "Charity",
                    Spent = 10.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 3, 2),
                    Name = "Internet",
                    Category = "Utilities",
                    Spent = 49.99
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 3, 4),
                    Name = "Cell Phone services",
                    Category = "Utilities",
                    Spent = 90.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 2),
                    Name = "Water Bill",
                    Category = "Utilities",
                    Spent = 50.50
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 3),
                    Name = "Internet",
                    Category = "Utilities",
                    Spent = 49.99
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 8),
                    Name = "Cell Phone services",
                    Category = "Utilities",
                    Spent = 90.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 11),
                    Name = "Electricity Bill",
                    Category = "Utilities",
                    Spent = 150.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 18),
                    Name = "Cloud storage",
                    Category = "Utilities",
                    Spent = 10.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 2, 1),
                    Name = "Water Bill",
                    Category = "Utilities",
                    Spent = 50.50
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 2, 3),
                    Name = "Internet",
                    Category = "Utilities",
                    Spent = 49.99
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 5),
                    Name = "Car Sevice",
                    Category = "Transport",
                    Spent = 50.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 10),
                    Name = "Car repair",
                    Category = "Transport",
                    Spent = 19.50
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 11),
                    Name = "Fuel Purchase",
                    Category = "Transport",
                    Spent = 25.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 18),
                    Name = "Car payment",
                    Category = "Transport",
                    Spent = 10.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 20),
                    Name = "Car Insurance",
                    Category = "Transport",
                    Spent = 50.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 11),
                    Name = "Math training classes",
                    Category = "Education",
                    Spent = 30.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 2, 8),
                    Name = "Piano classes",
                    Category = "Education",
                    Spent = 8.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 2, 11),
                    Name = "Math training classes",
                    Category = "Education",
                    Spent = 15.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 3, 5),
                    Name = "Piano classes",
                    Category = "Education",
                    Spent = 20.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 3, 11),
                    Name = "Math training classes",
                    Category = "Education",
                    Spent = 205.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 2, 22),
                    Name = "Medicine purchase",
                    Category = "Health & Wellness",
                    Spent = 7.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 3, 8),
                    Name = "Gym membership",
                    Category = "Health & Wellness",
                    Spent = 45.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 3, 15),
                    Name = "Doctor visit",
                    Category = "Health & Wellness",
                    Spent = 15.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 3, 22),
                    Name = "Medicine purchase",
                    Category = "Health & Wellness",
                    Spent = 8.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 11),
                    Name = "Winter clothes",
                    Category = "Shopping",
                    Spent = 10.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 15),
                    Name = "Video game console",
                    Category = "Shopping",
                    Spent = 50.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 21),
                    Name = "Laptop computer",
                    Category = "Shopping",
                    Spent = 2.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 1, 27),
                    Name = "Online shopping",
                    Category = "Shopping",
                    Spent = 10.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 2, 21),
                    Name = "Laptop computer",
                    Category = "Shopping",
                    Spent = 3.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 2, 11),
                    Name = "Video game console",
                    Category = "Shopping",
                    Spent = 20.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 2, 11),
                    Name = "Winter clothes",
                    Category = "Shopping",
                    Spent = 70.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 2, 24),
                    Name = "Online shopping",
                    Category = "Shopping",
                    Spent = 100.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 3, 23),
                    Name = "Online shopping",
                    Category = "Shopping",
                    Spent = 70.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 3, 20),
                    Name = "Laptop computer",
                    Category = "Shopping",
                    Spent = 70.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 3, 10),
                    Name = "Winter clothes",
                    Category = "Shopping",
                    Spent = 40.00
                },
                new TransactionDetail
                {
                    Date = new DateTime(2018, 3, 11),
                    Name = "Video game console",
                    Category = "Shopping",
                    Spent = 50.00
                },
            };
            return transactionDetails;
        }

        public DataService()
        {
            db = DependencyService.Get<IFileHelper>().DbConnection();

            db.CreateTable<ExpenseCategory>();

            if (!db.Table<ExpenseCategory>().Any())
            {
                db.InsertAll(getExpenses());
            }

            db.CreateTable<TransactionDetail>();

            if (!db.Table<TransactionDetail>().Any())
            {
                db.InsertAll(getTransactions());
            }
        }
    }
}
