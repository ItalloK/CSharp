using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class F_Login : Form
    {
        private F_Principal f_principal;
        public F_Login(F_Principal f_principal)
        {
            InitializeComponent();
            this.f_principal = f_principal;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=csharp;Uid=root;Pwd=root;";
            MySqlConnection conexao = new MySqlConnection(connectionString);

            try
            {
                conexao.Open();
                string Usuario = tb_usuario.Text;
                string Senha = tb_senha.Text;

                string consulta = "SELECT * FROM admins WHERE CPF = @Usuario AND Senha = @Senha";
                MySqlCommand comando = new MySqlCommand(consulta, conexao);

                comando.Parameters.AddWithValue("@Usuario", Usuario);
                comando.Parameters.AddWithValue("@Senha", Senha);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    f_principal.admlogado = true;
                    f_principal.lb_userninguem.Text = Usuario;
                    MessageBox.Show("Login Efetuado com Sucesso.");
                    this.Close(); // Fecha a Aba de Login
                }
                else
                {
                    tb_usuario.Clear();
                    tb_senha.Clear();
                    MessageBox.Show("Usuario ou Senha incorretos.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            
        }
    }
}
