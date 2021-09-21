using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaWinForms_V._0._1
{
    public partial class Loginer : Form
    {
        public List<User> AllUsers { get; set; }

        public Loginer()
        {
            InitializeComponent();
            AllUsers = new List<User>();
            if (File.Exists("AllUsers.bin"))
                Deserializ();
        }


        private void Serializ()
        {
            BinaryFormatter New_BinFormat = new BinaryFormatter();
            using (Stream fStream = File.Create("AllUsers.bin"))
                New_BinFormat.Serialize(fStream, AllUsers);
        }

        private void Deserializ()
        {
            BinaryFormatter New_BinFormat = new BinaryFormatter();
            using (Stream fStream = File.OpenRead("AllUsers.bin"))
                AllUsers = (List<User>)New_BinFormat.Deserialize(fStream);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = System.Drawing.Color.Red;
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AllUsers.Any())
            {
                for (int i = 0; i < AllUsers.Count; i++)
                {
                    if (AllUsers[i].Passwording == Password.Text && AllUsers[i].Logining == Login.Text)
                    {
                        StartForm game = new StartForm();
                        game.user = AllUsers[i];
                        game.ShowDialog();
                        AllUsers[i] = game.user;
                        Serializ();
                        return;
                    }
                }
            }
            MessageBox.Show("Sorry this user does not exist.", "Message");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registry registry = new Registry();
            if (registry.ShowDialog() == DialogResult.OK)
            {
                User tmp = new User(registry.PasswordTo, registry.LoginTo);
                AllUsers.Add(tmp);
                Serializ();
                Password.Text = Login.Text = "";
            }
        }
    }
}
