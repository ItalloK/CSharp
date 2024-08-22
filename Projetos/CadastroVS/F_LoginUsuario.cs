using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class F_LoginUsuario : Form
    {
        public F_LoginUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool naotemconta = false;
            if(naotemconta == false)
            {
                MessageBox.Show("Você não tem uma conta, clique em Registrar.");
            }
            mtb_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf;
            cpf = mtb_cpf.Text;
        }

        private void cb_mostrarsenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mostrarsenha.Checked == false)
            {
                tb_senha.PasswordChar = '*';
            }
            else
            {
                tb_senha.PasswordChar = '\0'; // Usar '\0' para mostrar a senha sem qualquer caractere de mascaramento
            }
        }
    }
}
