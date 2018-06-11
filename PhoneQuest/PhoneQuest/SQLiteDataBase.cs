using System;
using System.Data;
using Xamarin.Forms;

namespace SQLite
{
    /// <summary>
    /// Интерфейс подключения БД в различных системах
    /// </summary>
    public interface IDatabaseConnection
    {
        SQLiteConnection DbConnection(string FileName);
        string GetPath(string FileName);
    }

    /// <summary>
    /// Общее подключение к БД
    /// </summary>
    public class SQLiteDataBase
    {
        protected SQLiteConnection database;
        protected static object collisionLock = new object();
        public string DB_Path { get; protected set; }

        public SQLiteDataBase(string FileName)
        {
            database =
                DependencyService.Get<IDatabaseConnection>().DbConnection(FileName);
            DB_Path = DependencyService.Get<IDatabaseConnection>().GetPath(FileName);
        }
    }

    /// <summary>
    /// Конфигурация на основе SQLite
    /// </summary>
    public class SQLiteConfig : SQLiteDataBase
    {
        public SQLiteConfig(string FileName) : base (FileName)
        {
            
        }

        //Работа с конфигом, получение значения
        // Пока заглушка
        public string GetConfigValue(string name)
        {
            return "";
        }

        public int GetConfigValueInt(string name)
        {
            return 0;
        }

        public bool GetConfigValueBool(string name)
        {
            return false;
        }


        //Работа с конфигом, установка значения

        public bool SetConfigValue(string name, string value)
        {
            return false;
        }

        public bool SetConfigValue(string name, int value)
        {
            return false;
        }

        public bool SetConfigValue(string name, bool value)
        {
            return false;
        }
    }

    public class SQLiteLanguage : SQLiteDataBase
    {

        public string Language { get; set; } = "ru";

        public SQLiteLanguage(string FileName) : base (FileName)
        {
            
        }

        public void AddLanguage(string LanguageName)
        {
            //this.Execute("ALTER TABLE `texts` ADD COLUMN `text_" + LanguageName + "` TEXT;");
        }

        public string GetText(string Class, string TextName)
        {
            string Out = "";
            lock (collisionLock)
            {
                var query = from Text in database.Table<Structures.Texts>()
                            where (Text.text_class == Class) && (Text.name == TextName)
                            select Text;
                Out = query.Count() > 0
                    ? query.First().Text(Language)
                    : "";
            }

            return Out;
        }
    }
}
