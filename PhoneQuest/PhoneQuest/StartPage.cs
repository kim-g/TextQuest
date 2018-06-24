using SQLite;
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
        private AbsoluteLayout QuestionPanel;
        private Label QuestionLabel;
        private Image SlideImage;
        private int TimerGoTo = 1;

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
            ErrorAnswers.Add(new Answer(0, Texts.GetText("main", "error_answer"), "qustion=1", 0,0,10,10));
            Error = new Question(0, Texts.GetText("main", "error"), "", ErrorAnswers, "");
            QuestionLabel = new Label
            {
                Text = Texts.GetText("main", "error"),
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 32,
                Margin = new Thickness(0),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            SlideImage = new Image()
            {
                Margin = new Thickness(0),
                Aspect = Aspect.AspectFit

            };

            QuestionPanel = new AbsoluteLayout
            {
                Children =
                        {
                            QuestionLabel,
                            SlideImage//,
                            //QuestionLabel

                        },
                VerticalOptions = LayoutOptions.FillAndExpand,
                
            };

            Content = new StackLayout
            {
                Children =
                {
                    QuestionPanel, 
                }
            };

            ScriptEngine = new Script(this, Data, Texts);
            CurrentQuestion = Data.Question(1);
            QuestionLabel.Text = this.WidthRequest.ToString() + " xxxx " + this.HeightRequest.ToString();
        }

        public void SetTimer(string InputString)
        {
            string[] Params = InputString.Split(',');
            TimerGoTo = Convert.ToInt32(Params[1]);

            Device.StartTimer(TimeSpan.FromSeconds(Convert.ToInt32(Params[0])), TimerTick);
        }

        private bool TimerTick()
        {
            if (CurrentQuestion.ID != TimerGoTo)
                CurrentQuestion = Data.Question(TimerGoTo);

            return false;
        }


        /// <summary>
        /// Создание новой кнопки и привязка её к форме
        /// </summary>
        /// <param name="Name">Текст кнопки</param>
        /// <param name="Script">Скрипт, исполняемый по нажатии на кнопку</param>
        /// <returns></returns>
        private AnswerButton SetButton(int ID, string Name, string Script, Thickness Margin, double Width, double Height)
        {
            AnswerButton NewButton = new AnswerButton(ID, Name, Script);
            NewButton.Clicked += AnswerButton_Click;
            NewButton.BackgroundColor = Color.Transparent;
            NewButton.WidthRequest = Width;
            NewButton.HeightRequest = Height;
            NewButton.HorizontalOptions = LayoutOptions.Center;
            NewButton.Margin = Margin;
            QuestionPanel.Children.Add(NewButton);

            return NewButton;
        }

        private void SetQuestion()
        {
            QuestionLabel.Text = CurrentQuestion.Text;
            SetBackground(CurrentQuestion.Image);

            foreach (AnswerButton OldButton in Answers) QuestionPanel.Children.Remove(OldButton);
            Answers.Clear();

            foreach (Answer NewAnswer in CurrentQuestion.Answers)
            {
                AnswerButton NewButton = SetButton(NewAnswer.ID, NewAnswer.Text, NewAnswer.Script, NewAnswer.Margin, NewAnswer.Width, NewAnswer.Height);
                Answers.Add(NewButton);
            }

            ScriptEngine.Execute(CurrentQuestion.Script);
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
        
        public void SetBackground(string BKG_Name)
        {
            string Path = DependencyService.Get<IDatabaseConnection>().GetPath("Slide_" + BKG_Name + ".png");
            SlideImage.Source = ImageSource.FromFile(Path);
        }
    }
}