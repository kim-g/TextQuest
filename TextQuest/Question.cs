using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextQuest
{
    /// <summary>
    /// Класс вопросов и списка ответов к ним
    /// </summary>
    public class Question
    {
        public int ID;
        public string Text;
        public string Script;
        public List<Answer> Answers = new List<Answer>();

        public Question(int id, string text, string script, List<Answer> answers)
        {
            ID = id;
            Text = text;
            Script = script;
            Answers = answers;
        }
    }

    /// <summary>
    /// Класс ответов на вопрос
    /// </summary>
    public class Answer
    {
        public int ID;
        public string Text;
        public string Script;

        public Answer(int id, string text, string script)
        {
            ID = id;
            Text = text;
            Script = script;
        }
    }
}
