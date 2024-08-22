namespace LoginRegistroLocal
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            tb_Nick = new TextBox();
            tb_Senha = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tb_Nome = new TextBox();
            tb_Email = new TextBox();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            lbl_Erro = new Label();
            tb_Idade = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(200, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 223);
            label1.Name = "label1";
            label1.Size = new Size(300, 15);
            label1.TabIndex = 2;
            label1.Text = "Bem Vindo(a) digite os dados abaixo para fazer Registro";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 255);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "Digite seu Nick:";
            // 
            // tb_Nick
            // 
            tb_Nick.Location = new Point(142, 273);
            tb_Nick.Name = "tb_Nick";
            tb_Nick.Size = new Size(300, 23);
            tb_Nick.TabIndex = 0;
            // 
            // tb_Senha
            // 
            tb_Senha.Location = new Point(142, 317);
            tb_Senha.Name = "tb_Senha";
            tb_Senha.PasswordChar = '*';
            tb_Senha.Size = new Size(300, 23);
            tb_Senha.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 299);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 5;
            label3.Text = "Digite sua Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 343);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 7;
            label4.Text = "Digite seu Nome:";
            // 
            // tb_Nome
            // 
            tb_Nome.Location = new Point(142, 361);
            tb_Nome.Name = "tb_Nome";
            tb_Nome.Size = new Size(300, 23);
            tb_Nome.TabIndex = 2;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(142, 405);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(300, 23);
            tb_Email.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 387);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 9;
            label5.Text = "Digite seu Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(142, 431);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 11;
            label6.Text = "Digite sua Idade:";
            // 
            // button1
            // 
            button1.Location = new Point(200, 496);
            button1.Name = "button1";
            button1.Size = new Size(200, 23);
            button1.TabIndex = 5;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_Erro
            // 
            lbl_Erro.AutoSize = true;
            lbl_Erro.ForeColor = Color.Red;
            lbl_Erro.Location = new Point(145, 475);
            lbl_Erro.Name = "lbl_Erro";
            lbl_Erro.Size = new Size(0, 15);
            lbl_Erro.TabIndex = 14;
            // 
            // tb_Idade
            // 
            tb_Idade.Location = new Point(142, 449);
            tb_Idade.Mask = "00";
            tb_Idade.Name = "tb_Idade";
            tb_Idade.Size = new Size(300, 23);
            tb_Idade.TabIndex = 4;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 532);
            Controls.Add(tb_Idade);
            Controls.Add(lbl_Erro);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(tb_Email);
            Controls.Add(label5);
            Controls.Add(tb_Nome);
            Controls.Add(label4);
            Controls.Add(tb_Senha);
            Controls.Add(label3);
            Controls.Add(tb_Nick);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox tb_Nick;
        private TextBox tb_Senha;
        private Label label3;
        private Label label4;
        private TextBox tb_Nome;
        private TextBox tb_Email;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label lbl_Erro;
        private MaskedTextBox tb_Idade;
    }
}