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
    public partial class F_Veiculos : Form
    {
        F_Principal fp; // cria um objeto para poder utilizar na classe toda
        public F_Veiculos(string v, F_Principal f)
        {
            InitializeComponent();
            tb_listaveiculos.Text = v;

            fp = f; // Atribui a FP o valor de F

            f.Num = 10;

        }

        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_listaveiculos.Text = tb_listaveiculos.Text;
            /*Comando acima passa os valores do form filho para o form pai*/
        }
    }
}
