using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCT.Helpers
{
    public interface IFileHelper
    {
        SQLiteConnection DbConnection();
    }
}
