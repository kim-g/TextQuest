using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextQuest
{
    /// <summary>
    /// Класс для взаимодействия с системой вопросов и ответов на основе БД SQLite
    /// </summary>
    public class QuestDB : SQLite.SQLiteDataBase
    {
        private string language = "ru";

        public string Language
        {
            get
            {
                return language;
            }

            set
            {
                if (value == "ru" || value == "en") language = value;
            }
        }
        
        
        /// <summary>
        /// Открытие базы данных с вопросами и ответами.
        /// </summary>
        /// <param name="FileName">Имя файла для открытия или создания</param>
        public QuestDB(string FileName) : base(FileName)
        {
            if (File.Exists(FileName))
                OpenDB();
            else
                CreateDB(@"CREATE TABLE `Questions` (
	                            `id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	                            `text_ru`	TEXT,
	                            `text_en`	TEXT,
	                            `script`	TEXT DEFAULT NULL
                            );

                            CREATE TABLE `Answers` (
	                            `id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	                            `Question`	INTEGER NOT NULL,
	                            `text_ru`	TEXT,
	                            `text_en`	TEXT,
	                            `script`	TEXT DEFAULT NULL
                            );");
        }

        /// <summary>
        /// Выдаёт вопрос и ответы на выбранном языке
        /// </summary>
        /// <param name="ID">Номер вопроса</param>
        /// <returns>Возвращает текст вопроса</returns>
        public Question Question(int ID)
        {
            // Получаем ответы
            List<Answer> Answers = new List<Answer>();
            DataTable DT = ReadTable("SELECT `id`, `text_" + Language + "`, `script` FROM `Answers` " +
                "WHERE `Question` = " + ID.ToString() + ";");

            foreach (DataRow Row in DT.Rows)
            {
                Answers.Add(new Answer(Convert.ToInt32(Row.ItemArray[0]), Row.ItemArray[1].ToString(),
                    Row.ItemArray[2].ToString()));
            }

            DataRow QuestRow = GetOne("`text_" + Language + "`, `script`", "Questions",
                "id = " + ID.ToString());
            return new Question(ID, QuestRow.ItemArray[0].ToString(),
                QuestRow.ItemArray[1].ToString(), Answers);

        }
        
    }
}
