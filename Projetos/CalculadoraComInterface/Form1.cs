using System.Data;
namespace CalculadoraComInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            setValue(7);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            setValue(8);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            setValue(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            setValue(6);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            setValue(5);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            setValue(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setValue(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setValue(2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            setValue(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setValue(0);
        }


        private void setValue(int val)
        {
            if (tb_tela.Text.Length < 11)
            {
                tb_tela.Text += val;
            }
            else
            {
                MessageBox.Show("Maximo de numeros digitados;");
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb_telaNums.Text += tb_tela.Text + "+";
            tb_tela.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb_telaNums.Text += tb_tela.Text;
            var valor = CalcularExpressao(tb_telaNums.Text.ToString());
            tb_tela.Text = valor.ToString();
            button19.Enabled = false;
            button18.Enabled = false;
            button16.Enabled = false;
            button15.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button6.Enabled = false;
            button5.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tb_tela.Clear();
            tb_telaNums.Clear();
            button19.Enabled = true;
            button18.Enabled = true;
            button16.Enabled = true;
            button15.Enabled = true;
            button14.Enabled = true;
            button13.Enabled = true;
            button12.Enabled = true;
            button11.Enabled = true;
            button10.Enabled = true;
            button9.Enabled = true;
            button8.Enabled = true;
            button7.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = true;
            button4.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tb_telaNums.Text += tb_tela.Text + "*";
            tb_tela.Clear();
        }

        private double CalcularExpressao(string expressao)
        {
            DataTable dt = new DataTable();
            object resultado = dt.Compute(expressao, string.Empty);
            return Convert.ToDouble(resultado);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tb_telaNums.Text += tb_tela.Text + "-";
            tb_tela.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tb_telaNums.Text += tb_tela.Text + "/";
            tb_tela.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tb_telaNums.Text += tb_tela.Text + "(";
            tb_tela.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tb_telaNums.Text += tb_tela.Text + ")";
            tb_tela.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_telaNums.Text += tb_tela.Text + ".";
            tb_tela.Clear();
        }
    }
}
