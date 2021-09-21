using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaWinForms_V._0._1
{
    public partial class Registry : Form
    {
        public string LoginTo { get; set; }
        public string PasswordTo { get; set; }
        public Registry()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "" && Login.Text != null && Login.Text != "" && Password.Text != null && Password.Text != "")
            {
                if (Password.Text == textBox1.Text)
                {
                    LoginTo = Login.Text;
                    PasswordTo = Password.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Passwords do not match", "Please");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields", "Please");
            }
        }
    }
}
