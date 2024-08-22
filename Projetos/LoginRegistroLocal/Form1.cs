using System.Text.Json;

namespace LoginRegistroLocal
{
    public partial class Principal : Form
    {
        public string nick;
        private string senha;
        private int tentativas = 0;
        private int maxTentativas = 3;
        public Principal()
        {
            InitializeComponent();
        }

        private void btn_Registro_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            reg.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            nick = tb_Nick.Text;
            senha = tb_Senha.Text;
            if (tb_Nick.Text == "" || tb_Senha.Text == "")
            {
                lbl_Erro.Text = "H� campos n�o preenchidos!";
                return;
            }
            string pasta = "Contas";
            string caminhoCompleto = Path.Combine(Environment.CurrentDirectory, pasta);
            string nomeArquivo = nick + ".json";
            string caminhoArquivo = Path.Combine(caminhoCompleto, nomeArquivo);
            if (!File.Exists(caminhoArquivo))
            {
                lbl_Erro.Text = "Usu�rio n�o encontrado!";
                return;
            }
            try
            {
                string json = File.ReadAllText(caminhoArquivo);
                Pessoa pessoa = JsonSerializer.Deserialize<Pessoa>(json);
                if (pessoa.Senha == senha)
                {
                    MessageBox.Show("Login bem-sucedido! Bem-vindo, " + pessoa.Nome + "!");
                    Pagina p = new Pagina();
                    p.Show();
                    this.Hide();
                    p.FormClosed += (s, args) => this.Close(); // Fecha o formul�rio de login quando o novo formul�rio � fechado
                }
                else
                {
                    tentativas++;
                    lbl_Erro.Text = "Nick ou Senha incorreto ("+tentativas+"/"+maxTentativas+")";
                    tb_Senha.Clear();
                    tb_Nick.Focus();
                    if(tentativas >= 3)
                    {
                        MessageBox.Show("Maximo de tentativas excedido!!");
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                lbl_Erro.Text = "Erro ao processar login. Tente novamente.";
            }            
        }
    }
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Nick { get; set; }
        public string Senha { get; set; }
    }

}
