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
    public partial class StatisticaCostyl : Form
    {
        public StatisticaCostyl()
        {
            InitializeComponent();
        }

        public void AddElementListBox(List<Statistic> Show)
        {
            foreach (var item in Show)
            {
                listBox1.Items.Add(item.ToListStatistics());
            }
        }
    }
}
