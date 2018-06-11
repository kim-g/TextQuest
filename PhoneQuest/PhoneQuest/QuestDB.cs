using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneQuest
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
            List<SQLite.Structures.Answers> SQL_Answers = new List<SQLite.Structures.Answers>();

            var QueryAnswers = from Ans in database.Table<SQLite.Structures.Answers>()
                        where Ans.Question == ID
                        select Ans;

            if (QueryAnswers.Count() > 0)
                foreach (SQLite.Structures.Answers Row in QueryAnswers.AsEnumerable())
                {
                    Answers.Add(new Answer(Row.id, Row.Text(Language),
                        Row.script));
                }

            var QueryQuests = from Quest in database.Table<SQLite.Structures.Question>()
                              where Quest.id == ID
                              select Quest;

            return QueryQuests.Count() == 0 ? null : new Question(QueryQuests.First().id, QueryQuests.First().Text(Language),
                QueryQuests.First().script, Answers);

        }
        
    }
}
