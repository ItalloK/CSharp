using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula90
{
    public partial class F_Timer : Form
    {
        int num = 0;
        int Px, Py;

        public F_Timer()
        {
            InitializeComponent();
        }

        private void F_Timer_Load(object sender, EventArgs e)
        {
            //num = 0;  
            Px = img_Foto.Location.X;
            Py = img_Foto.Location.Y;
        }

        private void btn_iniciart1_Click(object sender, EventArgs e)
        {
            //timer1.Interval = 500; // define intervalo do timer
            timer1.Start();
        }

        private void btn_parart1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = num.ToString();
            num++;
        }

        private void btn_resetarcont1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            label1.Text = num.ToString();
            timer1.Start();
        }

        private void btn_iniciarfoto_Click(object sender, EventArgs e)
        {
            TimerFoto.Start();
        }

        private void btn_pararfoto_Click(object sender, EventArgs e)
        {
            TimerFoto.Stop();
        }

        private void TimerFoto_Tick(object sender, EventArgs e)
        {
            Px+=2;
            if(Px >= 594)
            {
                Px = 12;
            }
            img_Foto.Location = new Point(Px, Py);
            Px = img_Foto.Location.X;
        }
    }
}
