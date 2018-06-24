using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PhoneQuest
{
    /// <summary>
    /// Класс вопросов и списка ответов к ним
    /// </summary>
    public class Question
    {
        public int ID;
        public string Text;
        public string Script;
        public string Image;
        public List<Answer> Answers = new List<Answer>();

        public Question(int id, string text, string script, List<Answer> answers, string _image)
        {
            ID = id;
            Text = text;
            Script = script;
            Answers = answers;
            Image = _image;
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
        public Thickness Margin;
        public double Width;
        public double Height;

        public Answer(int id, string text, string script, int left, int top, int width, int height)
        {
            ID = id;
            Text = text;
            Script = script;
            Margin = new Thickness(left, top);
            Width = width;
            Height = height;
        }
    }
}
