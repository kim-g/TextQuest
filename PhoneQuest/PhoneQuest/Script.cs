using System;
using SQLite;
using Xamarin.Forms;

namespace PhoneQuest
{
    public class Script
    {
        QuestDB Data;
        SQLiteLanguage TextsDB;
        ContentPage Owner;

        public Script(ContentPage owner, QuestDB DataDB, SQLiteLanguage LanguageDB)
        {
            Owner = owner;
            Data = DataDB;
            TextsDB = LanguageDB;
        }

        public void Execute(string Script)
        {
            string[] Commands = Script.Trim().Split(';');
            foreach (string Command in Commands)
            {
                RunCommand(Command.Trim().ToLowerInvariant());
            }
        }

        private void RunCommand(string Command)
        {
            string[] CommandAndParameters = Command.Split('=');
            switch (CommandAndParameters[0])
            {
                case "language": SetLanguage(CommandAndParameters[1]); break;
                case "question": ((StartPage)Owner).CurrentQuestion = Data.Question(
                    Convert.ToInt32(CommandAndParameters[1])); break;
                case "error": SetError(); break;
            }
        }

        private void SetError()
        {
            ((StartPage)Owner).Error.Answers[0].Script = "question=" + 
                ((StartPage)Owner).CurrentQuestion.ID.ToString();
            ((StartPage)Owner).CurrentQuestion = ((StartPage)Owner).Error;
        }

        private void SetLanguage(string Language)
        {
            Data.Language = Language;
            TextsDB.Language = Language;
        }
    }
}
