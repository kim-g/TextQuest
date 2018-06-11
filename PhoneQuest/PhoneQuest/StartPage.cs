using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PhoneQuest
{
	public class StartPage : ContentPage
	{
        private SQLite.SQLiteLanguage Texts = new SQLite.SQLiteLanguage("Texts.db");
        private QuestDB Data = new QuestDB("Data.db");
        Question current_question;
        List<AnswerButton> Answers = new List<AnswerButton>();
        private StackLayout QuestionPanel;
        private StackLayout AnswersPanel;
        private Label QuestionLabel;

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

        public StartPage()
        {
            List<Answer> ErrorAnswers = new List<Answer>();
            ErrorAnswers.Add(new Answer(0, Texts.GetText("main", "error_answer"), "qustion=1"));
            Error = new Question(0, Texts.GetText("main", "error"), "", ErrorAnswers);
            QuestionLabel = new Label
            {
                Text = Texts.GetText("main", "error"),
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 32,
                Margin = new Thickness(0),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            QuestionPanel = new StackLayout
            {
                Children =
                        {
                           QuestionLabel
                        },
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.Red
            };

            AnswersPanel = new StackLayout
            {
                VerticalOptions = LayoutOptions.End,
                BackgroundColor = Color.Green
            };

            Content = new StackLayout
            {
                Children =
                {
                    QuestionPanel, 
                    AnswersPanel
                }
            };

            ScriptEngine = new Script(this, Data, Texts);
            CurrentQuestion = Data.Question(1);
        }

        /// <summary>
        /// Создание новой кнопки и привязка её к форме
        /// </summary>
        /// <param name="Name">Текст кнопки</param>
        /// <param name="Script">Скрипт, исполняемый по нажатии на кнопку</param>
        /// <returns></returns>
        private AnswerButton SetButton(int ID, string Name, string Script)
        {
            AnswerButton NewButton = new AnswerButton(ID, Name, Script);
            NewButton.Clicked += AnswerButton_Click;
            NewButton.HorizontalOptions = LayoutOptions.Center;
            NewButton.VerticalOptions = LayoutOptions.End;
            AnswersPanel.Children.Add(NewButton);


            return NewButton;
        }

        private void SetQuestion()
        {
            QuestionLabel.Text = CurrentQuestion.Text;

            foreach (AnswerButton OldButton in Answers) AnswersPanel.Children.Remove(OldButton);
            Answers.Clear();

            foreach (Answer NewAnswer in CurrentQuestion.Answers)
            {
                AnswerButton NewButton = SetButton(NewAnswer.ID, NewAnswer.Text, NewAnswer.Script);
                Answers.Add(NewButton);
            }
        }

        /// <summary>
        /// Событие нажатия на кнопку ответа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerButton_Click(object sender, EventArgs e)
        {
            ScriptEngine.Execute(((AnswerButton)sender).Script);
        }       
    }
}