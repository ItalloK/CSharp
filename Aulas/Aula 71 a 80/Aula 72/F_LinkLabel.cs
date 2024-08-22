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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            ll_multiplos.Links.Add(0, 6, "www.google.com.br"); // Posicao onde começa, tamanho e o link
            ll_multiplos.Links.Add(9, 5, "www.github.com/ItalloK"); // Posicao onde começa, tamanho e o link
            ll_multiplos.Links.Add(17, 7, "www.youtube.com"); // Posicao onde começa, tamanho e o link

            ll_multiplos.Links[2].Enabled = false; // desabilita o Link
        
        }

        private void ll_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/"+tb_nome.Text); // passa oq tem em tb_nome para o link

            //LinkLabel ll = (LinkLabel)sender; // junto com o de baixo
            //ll.LinkVisited = true; // tem essa forma tambem q qualquer botao funciona.
            ll_github.LinkVisited = true; // apos abrir o link ele define como link visitado. ( troca a cor do botao para roxo )
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe"); // abre a calculadora
        }

        private void ll_multiplos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }
    }
}
