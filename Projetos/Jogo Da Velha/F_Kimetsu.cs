using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class F_Kimetsu : Form
    {
        int movimentos, cliques, cartasEncontradas, tagIndex;
        Image[] img = new Image[9]; //  quantidade de imagens e n picture box

        List<string> lista = new List<string>();

        int[] tags = new int[2];

        public F_Kimetsu()
        {
            InitializeComponent();
            Inicio();
        }

        private void Inicio()
        {
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                int tagIndex = int.Parse(String.Format("{0}", item.Tag));
                img[tagIndex] = item.Image;
                item.Image = Properties.Resources.FundoCartaKimetsu; // poe as imagens para aparecer apenas o fundo;
                item.Enabled = true;
            }
            Posicoes();
        }

        private void Posicoes()
        {
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                Random rdn = new Random();

                int[] xP = { 23, 129, 235, 341, 447, 553 };
                int[] yP = { 27, 133, 239 };
            Repete:
                var X = xP[rdn.Next(0, xP.Length)];
                var Y = yP[rdn.Next(0, yP.Length)];

                string verificacao = X.ToString() + Y.ToString();

                if (lista.Contains(verificacao))
                {
                    goto Repete;
                }
                else
                {
                    item.Location = new Point(X, Y);
                    lista.Add(verificacao);
                }
            }
        }

        private void ImagensClick(object sender, EventArgs e)
        {
            bool parEncontrado = false;
            PictureBox pic = (PictureBox)sender;
            cliques++;
            tagIndex = int.Parse(String.Format("{0}", pic.Tag));
            pic.Image = img[tagIndex];
            pic.Refresh();

            if (cliques == 1)
            {
                tags[0] = int.Parse(String.Format("{0}", pic.Tag));
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Click);
                simpleSound.Play();
            }
            else if (cliques == 2)
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Click);
                simpleSound.Play();
                movimentos++;
                lbl_movimentos.Text = "Movimentos: " + movimentos.ToString();
                tags[1] = int.Parse(String.Format("{0}", pic.Tag));
                parEncontrado = ChecagemPares();
                Desvirar(parEncontrado);
            }
        }

        private bool ChecagemPares()
        {
            cliques = 0;
            if (tags[0] == tags[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Desvirar(bool Check)
        {

            Thread.Sleep(500);
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                if (int.Parse(String.Format("{0}", item.Tag)) == tags[0] || int.Parse(String.Format("{0}", item.Tag)) == tags[1])
                {
                    if (Check == true)
                    {
                        item.Enabled = false;
                        cartasEncontradas++;
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Par);
                        simpleSound.Play();
                    }
                    else
                    {
                        item.Image = Properties.Resources.FundoCartaKimetsu;
                        item.Refresh();
                    }
                }
            }
            finalJogo();
        }

        private void finalJogo()
        {
            if (cartasEncontradas == img.Length * 2)
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Win);
                simpleSound.Play();
                MessageBox.Show("Parabéns, você terminou o jogo com " + movimentos.ToString() + " movimentos");
                DialogResult msg = MessageBox.Show("Deseja continuar jogando?", "Continuar?", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    cliques = 0;
                    movimentos = 0;
                    cartasEncontradas = 0;
                    lista.Clear();
                    Inicio();
                }
                else if (msg == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
    }
}
