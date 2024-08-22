using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula62
{
    public partial class F_MonthCalendar : Form
    {
        public F_MonthCalendar()
        {
            InitializeComponent();
        }

        private void btn_pegardata_Click(object sender, EventArgs e)
        {
            tb_1.Text = monthCalendar1.SelectionStart.ToShortDateString(); // pega a primeira data
            tb_2.Text = monthCalendar1.SelectionEnd.ToShortDateString(); // pega a ultima data
            tb_3.Text = monthCalendar1.TodayDate.ToShortDateString(); // o toshortdatestring nn mostra a hora
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tb_1.Text = monthCalendar1.SelectionStart.ToShortDateString(); // pega a primeira data
            tb_2.Text = monthCalendar1.SelectionEnd.ToShortDateString(); // pega a ultima data
            tb_3.Text = monthCalendar1.TodayDate.ToShortDateString(); // o toshortdatestring nn mostra a hora
        }
    }
}
