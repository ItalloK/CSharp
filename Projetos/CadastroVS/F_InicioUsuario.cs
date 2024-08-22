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
    public partial class F_InicioUsuario : Form
    {
        public bool Logado = false;
        public F_InicioUsuario()
        {
            InitializeComponent();
            string Ano = DateTime.Now.Year.ToString();
            string Mes = DateTime.Now.Month.ToString();
            string Dia = DateTime.Now.Day.ToString();
            lb_data.Text = $"Data: {Dia}/{Mes}/{Ano}";
        }

        private void btn_meucadastro_Click(object sender, EventArgs e)
        {
            if(Logado == false)
            {
                F_LoginUsuario f_LoginUsuario = new F_LoginUsuario();
                f_LoginUsuario.ShowDialog();
            }
            else
            {
                F_PerfilUsuario f_PerfilUsuario = new F_PerfilUsuario();
                f_PerfilUsuario.ShowDialog();
            }
        }
    }
}
