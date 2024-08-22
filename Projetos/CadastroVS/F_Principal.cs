using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastro
{
    public partial class F_Principal : Form
    {
        public bool admlogado = false;
        string connectionString = "Server=localhost;Database=csharp;Uid=root;Pwd=root;";
        public F_Principal()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                lb_statusserver.Text = "Online";
                lb_statusserver.ForeColor = Color.Green;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao servidor MySQL: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (admlogado == false)
            {
                MessageBox.Show("Você não está logado como adm.");
                return;
            }

            F_Cadastro f_Cadastro = new F_Cadastro();
            f_Cadastro.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(admlogado == true)
            {
                MessageBox.Show("Usuario ja conectado.");
            }
            else
            {
                F_Login f_Login = new F_Login(this);
                f_Login.ShowDialog();
            }  
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (admlogado == false)
            {
                MessageBox.Show("Você não está logado como adm.");
            }
            else
            {
                MessageBox.Show("Logado como ADM");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            F_InicioUsuario f_InicioUsuario = new F_InicioUsuario();
            f_InicioUsuario.ShowDialog();
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            F_Pesquisa f_Pesquisa = new F_Pesquisa();
            f_Pesquisa.ShowDialog();
        }
    }
}
