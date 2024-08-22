using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula62
{
    public partial class F_PictureBox : Form
    {
        public F_PictureBox()
        {
            InitializeComponent();
        }

        private void F_PictureBox_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.NomeGit;
            label2.Text = Properties.Resources.EnderecoGit;
            /*Pega a String la no Resources.resx
            Ela pode ser usada em qualquer lugar do codigo
            se alterar ela, ela altera no programa inteiro*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._45cf551c8592ac139abcb877d5780f7e;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._6604b9150a6dd96b8361ebb6c5cb6b99;
        }
    }
}
