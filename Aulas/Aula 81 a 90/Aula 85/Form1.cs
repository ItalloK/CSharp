using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aula_83
{
    public partial class Form1 : Form
    {
        StreamReader leitura = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void Salvar()
        {
            try
            {
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK) //se for ok no salvamento
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter italo_streamwriter = new StreamWriter(arquivo);
                    italo_streamwriter.Flush();
                    italo_streamwriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    italo_streamwriter.Write(this.richTextBox1.Text);
                    italo_streamwriter.Flush();
                    italo_streamwriter.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro na Gravação: " + "Erro ao Gravar", ex.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Abrir()
        {
            this.openFileDialog1.Multiselect = false; // proibe a abertura de varios arquivos

            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"C:\\Users\\itall\\Downloads\";
            openFileDialog1.Filter = "(*.txt)|*.TXT";

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if(dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader italo_streamreader =  new StreamReader(arquivo);
                    italo_streamreader .BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha = italo_streamreader.ReadLine();
                    while(linha != null )
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = italo_streamreader.ReadLine();
                    }
                    italo_streamreader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de Leitura: " + "Erro ao Ler", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }
    }
}
