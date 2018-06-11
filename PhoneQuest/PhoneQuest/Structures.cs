using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SQLite.Structures
{
    /// <summary>
    /// Общая структура для работы с БД. Явной реализации не имеет.
    /// </summary>
    public abstract class Structure : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName) => this.PropertyChanged?.Invoke(this,
              new PropertyChangedEventArgs(propertyName));
    }

    public abstract class LanguageStructure : Structure
    {
        private string _text_ru;
        private string _text_en;

        [NotNull]
        public string text_ru
        {
            get { return _text_ru; }
            set { _text_ru = value; OnPropertyChanged(nameof(text_ru)); }
        }

        [NotNull]
        public string text_en
        {
            get { return _text_en; }
            set { _text_en = value; OnPropertyChanged(nameof(text_en)); }
        }

        public string Text(string language = "ru")
        {
            switch (language)
            {
                case "ru": return text_ru;
                case "en": return text_en;
                default: return text_ru;
            }
        }
    }

    [Table("Questions")]
    public class Question : LanguageStructure
    {
        // Private хранилище данных
        private int _id;
        
        private string _script;

        // Свойства
        [PrimaryKey, AutoIncrement]
        public int id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(nameof(id)); }
        }

        public string script
        {
            get { return _script; }
            set { _script = value; OnPropertyChanged(nameof(script)); }
        }    }


    [Table("Answers")]
    public class Answers : LanguageStructure
    {
        // Private хранилище данных
        private int _id;
        private int _question;
        private string _script;

        // Свойства
        [PrimaryKey, AutoIncrement]
        public int id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(nameof(id)); }
        }

        [NotNull]
        public int Question
        {
            get { return _question; }
            set { _question = value; OnPropertyChanged(nameof(Question)); }
        }

        public string script
        {
            get { return _script; }
            set { _script = value; OnPropertyChanged(nameof(script)); }
        }
    }

    [Table("texts")]
    public class Texts : LanguageStructure
    {
        // Private хранилища
        private int _id;
        private string _class;
        private string _name;
        private static string Language = "ru";

        // Public свойства

        /// <summary>
        /// id записи
        /// </summary>
        [PrimaryKey, AutoIncrement]
        public int id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(nameof(id)); }
        }

        [NotNull, Column("class")]
        public string text_class
        {
            get { return _class; }
            set { _class = value; OnPropertyChanged(nameof(text_class)); }
        }

        [NotNull]
        public string name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(name)); }
        }
    }
}
