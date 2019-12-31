using System.IO;
using SQLite;

namespace QLCT.Droid
{
    class FileHelper
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "db_sqlnet.db";
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);
            return new SQLiteConnection(path);
        }
    }
}