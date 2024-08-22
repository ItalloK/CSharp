using System;
using System.Collections;
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
    public partial class F_Cadastro : Form
    {
        string connectionString = "Server=localhost;Database=csharp;Uid=root;Pwd=root;";
        string query = "INSERT INTO Usuarios (CPF, email, nome, telefone, infos) VALUES (@CPF, @Email, @Nome, @Telefone, @Infos)";

        public string Nome;
        public string Email;
        public string CPF;
        public string Infos;
        public string Telefone;

        public F_Cadastro()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (tb_cpf.Text == "" || tb_email.Text == "" || tb_nome.Text == "" || tb_telefone.Text == "" || tb_infos.Text == "")
            {
                MessageBox.Show("Há campos em Branco.");
                return;
            }
            CPF = tb_cpf.Text;
            Email = tb_email.Text;
            Nome = tb_nome.Text;
            Telefone = tb_telefone.Text;
            Infos = tb_infos.Text;

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@CPF", CPF);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Nome", Nome);
            command.Parameters.AddWithValue("@Telefone", Telefone);
            command.Parameters.AddWithValue("@Infos", Infos);
            try
            {
                connection.Open();
                command.ExecuteNonQuery(); // Execute o comando SQL aqui
                MessageBox.Show("Cadastro enviado.");
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao enviar cadastro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
