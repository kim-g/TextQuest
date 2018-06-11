using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PhoneQuest
{
    class AnswerButton : Button
    {
        public int ID;
        public string Script;

        public AnswerButton(int ID, string Text, string Script)
        {
            this.ID = ID;
            this.Text = Text;
            this.Script = Script;
        }
    }
}
