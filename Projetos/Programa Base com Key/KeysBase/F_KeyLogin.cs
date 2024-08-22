using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KeysBase
{
    public partial class F_KeyLogin : Form
    {

        DataTable dt = new DataTable();

        public F_KeyLogin()
        {
            InitializeComponent();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            string keyDigitada = tb_keys.Text;

            string sql = "SELECT * FROM `Keys` WHERE `Keys` ='"+keyDigitada+"'";
            dt = Bd.dql(sql);
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Key Invalida");
                this.Dispose();
            }
            else
            {
                this.Hide();
                F_Programa f_Programa = new F_Programa();
                f_Programa.ShowDialog();
            }
            
        }
    }
}
