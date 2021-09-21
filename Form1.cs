using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaWinForms_V._0._1
{
    public partial class StartForm : Form
    {
        private char[] BigSmallLeters, SearthMain, WritenMain;
        private int Counter, Wrong;
        private bool EnableEnter;
        private DateTime TimeStart;
        public User user { get; set; }
        public StartForm()
        {
            InitializeComponent();
            user = new User();
            
            Counter = 0;
            EnableEnter = true;
            sentenceToolStripMenuItem.Checked = true;
            WritenMain = new char[21];
            BigSmallLeters = new char[]
            {
                'A', 'a', 'B', 'b', 'C', 'c', 'D', ' ', 'd', 'E', 'e', 'F', ' ', 'f', 'G', 'g', 'H', 'h',
                'I', 'i', ' ', 'J', 'j', 'K', 'k', 'L', 'l', 'M', ' ', 'm', 'N', 'n', 'O', 'o', 'P', 'p',
                'Q', 'q', 'R', 'r', 'S', 's', 'T', 't', ' ', 'U', 'u', 'V', 'v', 'W', 'w', ' ', 'X', 'x',
                'Y', ' ', 'y', 'Z', 'z', ' '
            };
        }

        private void StartForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!EnableEnter)
            {
                if (e.KeyChar == SearthMain[0])
                {
                    Count.Text = "Count: " + ++Counter;
                    if (SearthMain[1] == '\0')
                    {
                        MessageBox.Show("The end\n" + Statistics(Counter), "Finish");
                        StartButtonMenu.Checked = false;
                        StandartViev();
                        return;
                    }
                    Running_Term();
                }
                else if (e.KeyChar != SearthMain[0])
                    Wrong++;
            }
        }

        private void Running_Term()
        {
            WritenMain[0] = SearthMain[0];
            for (int i = 0, j = 1; i < SearthMain.Length - 1; i++, j++)
                SearthMain[i] = SearthMain[j];
            SearthMain[SearthMain.Length - 1] = '\0';
            ExersizeTextLabe.Text = new string(SearthMain);
            WritenTextLabe.Text = new string(WritenMain);

        }

        private string Statistics(int CountSymbol)
        {
            Statistic stat = new Statistic();
            stat.CreateStatistic(CountSymbol, Wrong, TimeStart);
            user.Statistic.Add(stat);
            return user.Statistic.Last().ShowStatistic();
        }

        private void CloseButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CloseButon_MouseHover(object sender, EventArgs e)
        {
            this.CloseButon.ForeColor = System.Drawing.Color.Red;
        }
        private void CloseButon_MouseLeave(object sender, EventArgs e)
        {
            this.CloseButon.ForeColor = System.Drawing.Color.WhiteSmoke;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && EnableEnter)
            {
                InputLanguage myCurrentLanguage = InputLanguage.CurrentInputLanguage;
                if (myCurrentLanguage.LayoutName == "US")
                {
                    Start_Game();
                    StartButtonMenu.Checked = true;
                }
                else
                    MessageBox.Show("Pay attention to the simulator in English so that everything works correctly, it is recommended to put the English keyboard layout", "Recomendate");
            }
            if (e.KeyCode == Keys.Escape && !EnableEnter)
            {
                StartButtonMenu.Checked = false;
                MessageBox.Show(Statistics(Counter), "Statistic");
                StandartViev();
            }
        }

        private void StartButtonMenu_Click(object sender, EventArgs e)
        {
            if (StartButtonMenu.Checked)
            {
                InputLanguage myCurrentLanguage = InputLanguage.CurrentInputLanguage;
                if (myCurrentLanguage.LayoutName == "US")
                {
                    Start_Game();
                }
            }
            else if (!StartButtonMenu.Checked)
            {
                MessageBox.Show(Statistics(Counter), "Statistic");
                StandartViev();
            }
        }

        private void sentenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            letersToolStripMenuItem.Checked = false;
        }

        private void letersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sentenceToolStripMenuItem.Checked = false;
        }

        private void Start_Game()
        {
            if (sentenceToolStripMenuItem.Checked)
            {
                Sentece_Game();
            }
            if (letersToolStripMenuItem.Checked)
            {
                Leter_Game();
            }
            if (!letersToolStripMenuItem.Checked && !sentenceToolStripMenuItem.Checked)
            {
                MessageBox.Show("Please select modes game", "Message");
                return;
            }
            GameViev();
            TimeStart = DateTime.Now;
        }

        private void GameViev()
        {
            ModesButtonMenu.Enabled = StatisticMenuItem.Enabled = HelpButtonMenu.Enabled = false;
            StartButtonMenu.Text = "STOP";
            WritenTextLabe.Text = "";
            EnableEnter = false;
        }

        private void instruktionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tmp = "This program is designed to teach you how to use the keyboard in English. \n" +
                         "Press ENTER to start, ESCAPE to finish. The program has 2 modes, \n" +
                         "sentence mode allows you to write ready-made text, letter mode generates random letters \n" +
                         "where you get used to the location of the keys. The program also allows you to add \n" +
                         "your own text. Thank you for reading this enjoyable study";
            MessageBox.Show(tmp, "Instruction");
        }

        private void writeYouTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddText newText = new AddText();
            if (newText.ShowDialog() == DialogResult.OK)
            {
                user.BaseSentence.Add(newText.NewText);
            }
        }

        private void loadYouFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            open.Filter = "Text Files(*.txt)|*.txt||";
            open.FilterIndex = 1;
            open.CheckFileExists = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                using(StreamReader reader = new StreamReader(open.OpenFile()))
                {
                    user.BaseSentence.Add(reader.ReadToEnd());
                }
            }
        }

        private void StatisticMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Statistic != null && user.Statistic.Count > 0)
            {
                StatisticaCostyl costyl = new StatisticaCostyl();
                costyl.AddElementListBox(user.Statistic);
                costyl.ShowDialog();
            }
            else
                MessageBox.Show("Non statistics", "Message");
        }

        private void StandartViev()
        {
            Counter = Wrong = 0;
            StartButtonMenu.Text = "START";
            WritenTextLabe.Text = "Press ENTER to Start";
            ExersizeTextLabe.Text = "Press ESCAPE to stop";
            Count.Text = "";
            ModesButtonMenu.Enabled = StatisticMenuItem.Enabled = HelpButtonMenu.Enabled = true;
            EnableEnter = true;
        }

        private void Sentece_Game()
        {
            if (user.BaseSentence.Count > 0)
            {
                Random random = new Random();
                int rand = random.Next(user.BaseSentence.Count - 1);
                if (user.BaseSentence.ElementAt(rand) != "")
                {
                    SearthMain = user.BaseSentence.ElementAt(rand).ToCharArray();
                    ExersizeTextLabe.Text = user.BaseSentence.ElementAt(rand);
                    WritenMain = new char[SearthMain.Length];
                }
                else
                {
                    user.BaseSentence.RemoveAt(rand);
                    Sentece_Game();
                }
            }
            else
                MessageBox.Show("Add text to program","Message");
        }

        private void Leter_Game()
        {
            SearthMain = new char[1000]; 
            Random random = new Random();
            int rand = 0;
            for (int i = 0; i < SearthMain.Length; i++)
            {
                rand = random.Next(BigSmallLeters.Length - 1);
                SearthMain[i] = BigSmallLeters[rand];
            }
            ExersizeTextLabe.Text = new string(SearthMain);
            WritenMain = new char[SearthMain.Length];
        }

    }
}
