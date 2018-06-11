using System.IO;
using PhoneQuest.Droid;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(
  DatabaseConnection_Android))]
namespace PhoneQuest.Droid
{

    class DatabaseConnection_Android : IDatabaseConnection
    {
        private string AppDir()
        {
            return Path.GetFullPath(Path.Combine(
                Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, "TextQuest"));
        }

        public SQLiteConnection DbConnection(string FileName)
        {
            var path = Path.GetFullPath(Path.Combine(AppDir(), FileName));
            return new SQLiteConnection(path);
        }

        public string GetPath(string FileName) => Path.GetFullPath(Path.Combine(AppDir(), FileName));
    }
}