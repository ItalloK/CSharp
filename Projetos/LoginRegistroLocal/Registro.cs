using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LoginRegistroLocal
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_Nick.Text == "" || tb_Senha.Text == "" || tb_Nome.Text == "" || tb_Email.Text == "" || tb_Idade.Text == "")
            {
                lbl_Erro.Text = "Há campos não preenchidos!";
                return;
            }
            if (tb_Senha.Text.Length < 5)
            {
                lbl_Erro.Text = "A senha deve contar no minimo 5 caracteres!";
                return;
            }
            string idadeTexto = tb_Idade.Text.Trim();
            if (int.TryParse(idadeTexto, out int idade))
            {
                if (idade < 18)
                {
                    lbl_Erro.Text = "Sua idade deve ser superior a 18 anos!";
                    return;
                }
            }

            var pessoa = new Pessoa
            {
                Nick = tb_Nick.Text,
                Senha = tb_Senha.Text,
                Nome = tb_Nome.Text,
                Idade = int.Parse(tb_Idade.Text),
                Email = tb_Email.Text                
            };
            string json = JsonSerializer.Serialize(pessoa, new JsonSerializerOptions { WriteIndented = true });
            string pasta = "Contas";
            string caminhoCompleto = Path.Combine(Environment.CurrentDirectory, pasta);
            if (!Directory.Exists(caminhoCompleto))
            {
                Directory.CreateDirectory(caminhoCompleto);
            }
            string nomeArquivo = tb_Nick.Text+".json";
            string caminhoArquivo = Path.Combine(caminhoCompleto, nomeArquivo);
            if (File.Exists(caminhoArquivo))
            {
                lbl_Erro.Text = "O Nick já está em uso. Por favor, escolha outro."; //rs
                return;
            }
            File.WriteAllText(caminhoArquivo, json);
            MessageBox.Show("Nick: "+tb_Nick.Text+" registrado com Sucesso!");
            Principal p = new Principal();
            p.Show();
            this.Close();
        }
    }
}
