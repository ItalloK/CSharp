using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class F_Times : Form
    {

        private Form1 form1;
        public F_Times(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        private void escolhaTime(string nomeTime)
        {
            if (Global.time1 == "")
            {
                Global.time1 = nomeTime;
                lbl_time1.Text = nomeTime;
            }
            else if (Global.time2 == "")
            {
                Global.time2 = nomeTime;
                lbl_time2.Text = nomeTime;
            }
            else
            {
                MessageBox.Show("Ja foi escolhido 2 times, clique em limpar.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            escolhaTime("Flamengo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            escolhaTime("Vasco");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            escolhaTime("São Paulo");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            escolhaTime("Santos");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            escolhaTime("Fluminense");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            escolhaTime("Atletico-Mg");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            escolhaTime("Botafogo");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            escolhaTime("Internacional");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            escolhaTime("Bahia");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            escolhaTime("Fortaleza");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            escolhaTime("Corinthians");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            escolhaTime("Palmeiras");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            escolhaTime("Cruzeiro");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            escolhaTime("Grêmio");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            escolhaTime("Criciuma");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            escolhaTime("Athletico PR");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            escolhaTime("Bragantino");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            escolhaTime("EC Vitória");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            escolhaTime("Juventude");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            escolhaTime("Ceara");
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Global.time1 = "";
            Global.time2 = "";
            lbl_time1.Text = "...";
            lbl_time2.Text = "...";
            MessageBox.Show("Campos limpos, escolha os times novamente.");
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (Global.time1 == "" || Global.time2 == "" || cb_estadios.Text == "")
            {
                MessageBox.Show("Você deve escolher 2 times e um estádio antes de confirmar.");
                Global.confirmou = false;
                return;
            }
            Global.confirmou = true;
            verificarEstadio();
            this.Close();
        }

        private void F_Times_Load(object sender, EventArgs e)
        {
            Global.confirmou = false;
            Global.time1 = "";
            Global.time2 = "";
            cb_estadios.Text = "";
        }

        private void F_Times_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Global.confirmou == false)
            {
                Global.time1 = "";
                Global.time2 = "";
                cb_estadios.Text = "";
            }
        }

        private void verificarEstadio()
        {
            if(cb_estadios.Text == "Maracanã")
            {
                form1.BackgroundImage = Image.FromFile("estadios\\Maracana.png");
            }else if (cb_estadios.Text == "MorumBIS")
            {
                form1.BackgroundImage = Image.FromFile("estadios\\Morumbis.png");
            }
            else if (cb_estadios.Text == "Allianz Parque")
            {
                form1.BackgroundImage = Image.FromFile("estadios\\AllianzParque.png");
            }
            else if (cb_estadios.Text == "Neo Quimica Arena")
            {
                form1.BackgroundImage = Image.FromFile("estadios\\NeoQuimicaArena.png");
            }
            else if (cb_estadios.Text == "São Januário")
            {
                form1.BackgroundImage = Image.FromFile("estadios\\SaoJanuario.png");
            }
            else if (cb_estadios.Text == "Arena da Baixada")
            {
                form1.BackgroundImage = Image.FromFile("estadios\\ArenaDaBaixada.png");
            }
            else if (cb_estadios.Text == "Vila Belmiro")
            {
                form1.BackgroundImage = Image.FromFile("estadios\\VilaBelmiro.png");
            }
            form1.corVersus();
        }
    }
}
