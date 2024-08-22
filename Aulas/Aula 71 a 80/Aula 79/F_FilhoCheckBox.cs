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
    public partial class F_FilhoCheckBox : Form
    {
        public F_Checkbox f_cb;
        public F_FilhoCheckBox()
        {
            InitializeComponent();
            try
            {
                f_cb = Application.OpenForms["F_Checkbox"] as F_Checkbox;
                cb_carro.Checked = f_cb.cb_carro.Checked;
                /*Isso acima faz o Checkbox do design filho, receber o do pai*/
                cb_aviao.Checked = f_cb.cb_aviao.Checked;
                cb_navio.Checked = f_cb.cb_navio.Checked;
                cb_onibus.Checked = f_cb.cb_onibus.Checked;
            }
            catch
            {
                MessageBox.Show("Erro ao abrir o formulario.");
            }
        }

        private void cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            f_cb.cb_carro.Checked = cb_carro.Checked;
        }

        private void cb_aviao_CheckedChanged(object sender, EventArgs e)
        {
            f_cb.cb_aviao.Checked = cb_aviao.Checked;
        }

        private void cb_navio_CheckedChanged(object sender, EventArgs e)
        {
            f_cb.cb_navio.Checked = cb_navio.Checked;
        }

        private void cb_onibus_CheckedChanged(object sender, EventArgs e)
        {
            f_cb.cb_onibus.Checked = cb_onibus.Checked;
        }
    }
}
