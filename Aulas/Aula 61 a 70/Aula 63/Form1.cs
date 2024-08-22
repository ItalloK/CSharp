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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um Veiculo.");
                tb_veiculo.Focus(); // Posiciona o Mouse no componente.
                return; // Para a execução do evento.
            }

            tb_listaveiculos.Text += tb_veiculo.Text + ", ";
            tb_veiculo.Clear(); // Limpa a parte de digitação
            tb_veiculo.Focus();
           

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaveiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(tb_listaveiculos.Text); // Objeto Declarado
            f_Veiculos.ShowDialog(); // Diferente de .Show ele não deixa utilizar a janela anteiror
            
        }
    }
}
