using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextQuest
{
    public partial class Form1 : Form
    {
        // private vars
        QuestDB Data = new QuestDB("Data.db");
        SQLite.SQLiteLanguage Texts = new SQLite.SQLiteLanguage("Texts.db");
        Question current_question;
        List<Button> Answers = new List<Button>();

        // Public vars
        public Script ScriptEngine { get; set; }

        public Question CurrentQuestion
        {
            get { return current_question; }
            set
            {
                current_question = value;
                SetQuestion();
            }
        }

        public Form1()
        {
            InitializeComponent();
            ScriptEngine = new Script(this, Data, Texts);
            CurrentQuestion = Data.Question(1);
            Answers.Add(SetButton("Тест", ""));
        }

        /// <summary>
        /// Создание новой кнопки и привязка её к форме
        /// </summary>
        /// <param name="Name">Текст кнопки</param>
        /// <param name="Script">Скрипт, исполняемый по нажатии на кнопку</param>
        /// <returns></returns>
        private Button SetButton(string Name, string Script)
        {
            Button NewButton = new Button();
            NewButton.Text = Name;
            NewButton.Tag = Script;
            NewButton.Click += AnswerButton_Click;
            NewButton.Dock = DockStyle.Bottom;
            NewButton.Parent = this;

            return NewButton;
        }

        private void SetQuestion()
        {
            animator.HideSync(label1, true);
            label1.Text = CurrentQuestion.Text;
            animator.Show(label1);
        }

        /// <summary>
        /// Событие нажатия на кнопку ответа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerButton_Click(object sender, EventArgs e)
        {
            ScriptEngine.Execute((string)((Button)sender).Tag);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Answers[0].Dispose();
            Answers.Clear();
        }
    }
}
