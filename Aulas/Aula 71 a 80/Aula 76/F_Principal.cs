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
    public partial class F_Principal : Form
    {
        public int Num;
        public F_Principal()
        {
            InitializeComponent();
            Num = 0;
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
            F_Veiculos f_Veiculos = new F_Veiculos(tb_listaveiculos.Text, this); // Objeto Declarado
            f_Veiculos.ShowDialog(); // Diferente de .Show ele não deixa utilizar a janela anteiror
            
        }

        private void btn_valnum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Num.ToString()); // mostra o valor de num em string
        }

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Checkbox f_Checkbox = new F_Checkbox();
            f_Checkbox.ShowDialog();    
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog(); 
        }

        private void comboboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();
            f_DateTimePicker.ShowDialog();
        }

        private void linkedLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_LinkLabel = new F_LinkLabel();
            f_LinkLabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();
            f_ListBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_ListView = new F_ListView();
            f_ListView.ShowDialog();
        }

        private void fMaskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox f_MaskedTextBox = new F_MaskedTextBox();
            f_MaskedTextBox.ShowDialog();
        }
    }
}
