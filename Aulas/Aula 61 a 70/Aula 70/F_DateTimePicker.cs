using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula62
{
    public partial class F_DateTimePicker : Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }

        private void btn_obterdata_Click(object sender, EventArgs e)
        {
            tb_data.Text = dtp_data.Text;

            tb_dia.Text = dtp_data.Value.Day.ToString();
            tb_mes.Text = dtp_data.Value.Month.ToString();
            tb_ano.Text = dtp_data.Value.Year.ToString();
        }

        private void btn_setardata_Click(object sender, EventArgs e)
        {
            int dia, mes, ano;
            dia=Int32.Parse(tb_dia.Text);
            mes = Int32.Parse(tb_mes.Text);
            ano = Int32.Parse(tb_ano.Text);

            DateTime dt = new DateTime(ano, mes, dia); // pois o valua só aceita datetime
            dtp_data.Value = dt;
        }

        private void btn_hoje_Click(object sender, EventArgs e)
        {
            /*Obtendo data atual*/
            dtp_data.Value = DateTime.Today;

        }
    }
}
