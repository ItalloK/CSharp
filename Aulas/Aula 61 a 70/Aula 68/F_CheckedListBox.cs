using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Aula62
{
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarselecionados_Click(object sender, EventArgs e)
        {
            string txt = "";

            //txt=clb_transportes.Items[0].ToString(); // Pega por indice (mostra o carro)
            //txt = clb_transportes.CheckedItems[0].ToString(); // Pega por indice apenas dos marcados
            
            foreach(string t in clb_transportes.CheckedItems) // dessa forma exibe todos selecionados.
            {
                txt += t + ", ";
            }
            MessageBox.Show(txt);
        }

        private void btn_limparlista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear(); // Limpa todos os items
        }

        private void btn_resetarlista_Click(object sender, EventArgs e)
        {
            /*object carro = "Carro";
            clb_transportes.Items.Add(carro, true); // Pode ser tambem string "Carro", o true é pra começar ja marcado.*/
            clb_transportes.Items.Clear(); // Sempre limpar antes pra não flodar
            /*clb_transportes.Items.Add("Carro", false);
            clb_transportes.Items.Add("Avião", false);
            clb_transportes.Items.Add("Navio", false);
            clb_transportes.Items.Add("Onibus", false);
            clb_transportes.Items.Add("Trem", false);*/

            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Onibus");
            tr.Add("Trem");
            clb_transportes.Items.AddRange(tr.ToArray()); // Adiciona com List
        }

        private void btn_addtransporte_Click(object sender, EventArgs e)
        {
            if(tb_novotransporte.Text != "")
            {
                clb_transportes.Items.Add(tb_novotransporte.Text);
                tb_novotransporte.Clear(); // Apos adicionado limpa o local
                tb_novotransporte.Focus(); // poe o marcador de digitação na aba dnv
            }
            else
            {
                MessageBox.Show("Campo em Branco.");
            }
            
        }
    }
}
