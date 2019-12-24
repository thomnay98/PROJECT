using QLCT.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCT.Helpers
{
    class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public Database()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    connection.CreateTable<TypeOfExpense>();
                    connection.CreateTable<Expense>();
                    connection.CreateTable<TypeOfIncome>();
                    connection.CreateTable<Income>();
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
            }
        }

        public List<TypeOfExpense> GetTypeEx()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    return connection.Table<TypeOfExpense>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return null;
            }
        }

        public TypeOfExpense GetTypeExById(int IDEx)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    var lte = from ltex in connection.Table<TypeOfExpense>().ToList()
                              where ltex.IDEx == IDEx
                              select ltex;
                    return lte.ToList<TypeOfExpense>().FirstOrDefault();
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return null;
            }
        }

        public bool InsertTypeEx(TypeOfExpense te)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    connection.Insert(te);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return false;
            }
        }

        public bool UpdateTypeEx(TypeOfExpense te)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    connection.Update(te);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return false;
            }
        }

        public bool DeleteTypeEx(TypeOfExpense te)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    connection.Delete(te);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return false;
            }
        }

        public List<Expense> GetEx()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    return connection.Table<Expense>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return null;
            }
        }

        public Expense GetExById(int IDE)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    var le = from lex in connection.Table<Expense>().ToList()
                              where lex.IDE == IDE
                              select lex;
                    return le.ToList<Expense>().FirstOrDefault();
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return null;
            }
        }

        public bool InsertEx(Expense e)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    connection.Insert(e);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return false;
            }
        }

        public bool UpdateEx(Expense e)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    connection.Update(e);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return false;
            }
        }

        public bool DeleteEx(Expense e)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    connection.Delete(e);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return false;
            }
        }

        public List<TypeOfIncome> GetTypeIn()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    return connection.Table<TypeOfIncome>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return null;
            }
        }

        public TypeOfIncome GetTypeInById(int IDIn)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    var lti = from ltin in connection.Table<TypeOfIncome>().ToList()
                              where ltin.IDIn == IDIn
                              select ltin;
                    return lti.ToList<TypeOfIncome>().FirstOrDefault();
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return null;
            }
        }

        public bool InsertTypeIn(TypeOfIncome ti)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    connection.Insert(ti);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return false;
            }
        }

        public bool UpdateTypeIn(TypeOfIncome ti)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    connection.Update(ti);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return false;
            }
        }

        public bool DeleteTypeIn(TypeOfIncome ti)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    connection.Delete(ti);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return false;
            }
        }

        public List<Income> GetIn()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    return connection.Table<Income>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return null;
            }
        }

        public Income GetInById(int IDI)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    var li = from lin in connection.Table<Income>().ToList()
                              where lin.IDI == IDI
                              select lin;
                    return li.ToList<Income>().FirstOrDefault();
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return null;
            }
        }

        public bool InsertIn(Income i)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    connection.Insert(i);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return false;
            }
        }

        public bool UpdateIn(Income i)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    connection.Update(i);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return false;
            }
        }

        public bool DeleteIn(Income i)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "moneym.db")))
                {
                    connection.Delete(i);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                // Log.Info("SQLiteExpection:", ex.Message);
                return false;
            }
        }
    }
}
