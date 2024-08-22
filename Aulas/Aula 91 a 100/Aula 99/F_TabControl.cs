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
    public partial class F_TabControl : Form
    {
        public F_TabControl()
        {
            InitializeComponent();
        }

        private void btn_novatab_Click(object sender, EventArgs e)
        {
            if(tb_nomenovaaba.Text != "")
            {
                TabPage pagina = new TabPage();
                pagina.Text = tb_nomenovaaba.Text;
                pagina.Name = tb_nomenovaaba.Text;
                pagina.TabIndex = tabControl1.TabPages.Count;
                tabControl1.TabPages.Add(pagina);
                tb_nomenovaaba.Clear();
                definirmaximo();
            }
            else
            {
                MessageBox.Show("Digite um nome para a nova Tab");
                tb_nomenovaaba.Focus();
            }
        }

        private void btn_removertabatual_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            definirmaximo();
        }

        private void btn_posicionartab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = Int32.Parse(numericUpDown1.Value.ToString());
        }

        private void definirmaximo()
        {
            numericUpDown1.Maximum = tabControl1.TabPages.Count-1;
        }

        private void F_TabControl_Load(object sender, EventArgs e)
        {
            definirmaximo();
        }
    }
}
