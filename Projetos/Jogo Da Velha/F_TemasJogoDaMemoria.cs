using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class F_TemasJogoDaMemoria : Form
    {
        public F_TemasJogoDaMemoria()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Kimetsu f_Kimetsu = new F_Kimetsu();
            f_Kimetsu.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Kimetsu f_Kimetsu = new F_Kimetsu();
            f_Kimetsu.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_JogoDaMemoria f_JogoDaMemoria = new F_JogoDaMemoria();
            f_JogoDaMemoria.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_JogoDaMemoria f_JogoDaMemoria = new F_JogoDaMemoria();
            f_JogoDaMemoria.ShowDialog();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Bold);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Regular);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Bold);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Regular);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Shingeki f_Shingeki = new F_Shingeki();
            f_Shingeki.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Shingeki f_Shingeki = new F_Shingeki();
            f_Shingeki.ShowDialog();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Bold);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Regular);
        }
    }
}
