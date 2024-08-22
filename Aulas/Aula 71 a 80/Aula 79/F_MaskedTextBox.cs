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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarcpf_Click(object sender, EventArgs e)
        {
            if (cb_somentetexto.Checked == true)
            {
                mtb_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                /* Assim ele mostra somente o texto */
            }
            else
            {
                mtb_cpf.TextMaskFormat = MaskFormat.IncludeLiterals;
                /* Assim ele mostra com os marcadores - */
            }
            string msg = mtb_cpf.Text;
            MessageBox.Show(msg);
        }
    }
}
