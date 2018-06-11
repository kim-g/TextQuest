using LocalDataAccess.iOS;
using SQLite;
using System;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(
  DatabaseConnection_iOS))]
namespace LocalDataAccess.iOS
{
    public class DatabaseConnection_iOS : IDatabaseConnection
    {
        public SQLiteConnection DbConnection(string FileName)
        {
            string personalFolder =
              System.Environment.
              GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder =
              Path.Combine(personalFolder, "..", "Library");
            var path = Path.Combine(libraryFolder, FileName);
            return new SQLiteConnection(path);
        }

        public string GetPath(string FileName)
        {
            string personalFolder =
              System.Environment.
              GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder =
              Path.Combine(personalFolder, "..", "Library");
            return Path.Combine(libraryFolder, FileName);
        }
    }
}