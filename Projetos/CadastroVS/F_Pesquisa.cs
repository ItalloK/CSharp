using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cadastro
{
    public struct DadosPessoais
    {
        public int id;
        public string nome;
        public string email;
        public string cpf;
        public string telefone;
        public string infos;
    }
    public partial class F_Pesquisa : Form
    {
        public F_Pesquisa()
        {
            InitializeComponent();
            cb_escolha.Items.Add("CPF");
            cb_escolha.Items.Add("Nome");
            cb_escolha.Items.Add("Email");
            //cb_escolha.SelectedIndex = 0;
            cb_escolha.SelectedIndexChanged += new EventHandler(cb_escolha_SelectedIndexChanged);
        }
        private void cb_escolha_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_escolha.SelectedItem.ToString())
            {
                case "CPF":
                    mtb_1.Mask = "000.000.000-00";
                    break;
                case "Nome":
                    mtb_1.Mask = ""; 
                    break;
                case "Email":
                    mtb_1.Mask = ""; 
                    break;
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=csharp;Uid=root;Pwd=root;";
            if (cb_escolha.SelectedItem.ToString() == "CPF")
            {
                PesquisarPor("CPF", connectionString);
            }
            else if (cb_escolha.SelectedItem.ToString() == "Nome")
            {
                PesquisarPor("nome", connectionString);
            }
            else if (cb_escolha.SelectedItem.ToString() == "Email")
            {
                PesquisarPor("email", connectionString);
            }
        }

        private void PesquisarPor(string coluna, string connectionString)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string Valor = mtb_1.Text;
                    connection.Open();
                    string sql = $"SELECT id, nome, email, CPF, telefone, infos FROM usuarios WHERE {coluna} = @Valor";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Valor", Valor);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            lv_pessoas.Items.Clear();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    DadosPessoais Dados = new DadosPessoais
                                    {
                                        id = Convert.ToInt32(reader["id"]),
                                        nome = reader["nome"].ToString(),
                                        email = reader["email"].ToString(),
                                        cpf = reader["CPF"].ToString(),
                                        telefone = reader["telefone"].ToString(),
                                        infos = reader["infos"].ToString()
                                    };

                                    string[] pr = new string[6]; // quantidade de colunas
                                    pr[0] = Dados.id.ToString();
                                    pr[1] = Dados.nome;
                                    pr[2] = Dados.cpf;
                                    pr[3] = Dados.telefone;
                                    pr[4] = Dados.email;
                                    pr[5] = Dados.infos;

                                    ListViewItem l = new ListViewItem(pr);
                                    lv_pessoas.Items.Add(l);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nenhum registro encontrado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
