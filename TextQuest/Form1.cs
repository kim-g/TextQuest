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
        SQLite.SQLiteLanguage Texts = SQLite.SQLiteLanguage.Open("Texts.db");
        Question current_question;
        List<Button> Answers = new List<Button>();
        

        // Public vars
        public Script ScriptEngine { get; set; }
        public Question Error { get; set; }

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

            List<Answer> ErrorAnswers = new List<Answer>();
            ErrorAnswers.Add(new Answer(0, Texts.GetText("main", "error_answer"),"qustion=1"));
            Error = new Question(0, Texts.GetText("main", "error"), "", ErrorAnswers);
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
            NewButton.Visible = false;
            NewButton.Parent = AnswersPanel;
            NewButton.Left = 0;
            NewButton.Width = NewButton.Parent.Width;
            NewButton.Refresh();
            AnswerAnimator.SetDecoration(NewButton, AnimatorNS.DecorationType.None);

            return NewButton;
        }

        private void SetQuestion()
        {
            QuestionAnimator.HideSync(QuestionLabel, true);
            QuestionLabel.Text = CurrentQuestion.Text;
            QuestionAnimator.Show(QuestionLabel);

            foreach (Button OldButton in Answers) OldButton.Dispose();
            Answers.Clear();

            foreach (Answer NewAnswer in CurrentQuestion.Answers)
            {
                Button NewButton = SetButton(NewAnswer.Text, NewAnswer.Script);
                NewButton.Top = (Answers.Count) * (NewButton.Height + 10);
                Answers.Add(NewButton);
                AnswerAnimator.Show(Answers[Answers.Count - 1], false);
            }
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
