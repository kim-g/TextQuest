using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLite;

namespace TextQuest
{
    public class Script
    {
        QuestDB Data;
        SQLiteLanguage TextsDB;
        Form Owner;

        public Script(Form owner, QuestDB DataDB, SQLiteLanguage LanguageDB)
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
                case "question": ((Form1)Owner).CurrentQuestion = Data.Question(
                    Convert.ToInt32(CommandAndParameters[1])); break;
            }
        }

        private void SetLanguage(string Language)
        {
            Data.Language = Language;
            TextsDB.Language = Language;
        }
    }
}
