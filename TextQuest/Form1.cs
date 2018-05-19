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
        QuestDB Data = new QuestDB("Data.db");
        SQLite.SQLiteLanguage Texts = new SQLite.SQLiteLanguage("Texts.db");
        public Script ScriptEngine { get; set; }

        public Form1()
        {
            InitializeComponent();
            ScriptEngine = new Script(this, Data, Texts);
            SetQuestion(Data.Question(1));
        }

        

        public void SetQuestion(Question Quest)
        {

            animator.HideSync(label1, true);
            label1.Text = Quest.Text;
            animator.Show(label1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Question Q = Data.Question(1);
            ScriptEngine.Execute(Q.Answers[0].Script);
        }
    }
}
