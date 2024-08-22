namespace LoginRegistroLocal
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_Registro = new Button();
            btn_Login = new Button();
            label2 = new Label();
            tb_Senha = new TextBox();
            tb_Nick = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lbl_Erro = new Label();
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
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 223);
            label1.Name = "label1";
            label1.Size = new Size(287, 15);
            label1.TabIndex = 1;
            label1.Text = "Bem Vindo(a) digite os dados abaixo para fazer Login";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_Registro
            // 
            btn_Registro.Location = new Point(486, 433);
            btn_Registro.Name = "btn_Registro";
            btn_Registro.Size = new Size(75, 23);
            btn_Registro.TabIndex = 3;
            btn_Registro.Text = "Registro";
            btn_Registro.UseVisualStyleBackColor = true;
            btn_Registro.Click += btn_Registro_Click;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(200, 389);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(200, 23);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(477, 415);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 4;
            label2.Text = "Não tem conta?";
            // 
            // tb_Senha
            // 
            tb_Senha.Location = new Point(130, 342);
            tb_Senha.Name = "tb_Senha";
            tb_Senha.PasswordChar = '*';
            tb_Senha.Size = new Size(335, 23);
            tb_Senha.TabIndex = 1;
            // 
            // tb_Nick
            // 
            tb_Nick.Location = new Point(130, 291);
            tb_Nick.Name = "tb_Nick";
            tb_Nick.Size = new Size(335, 23);
            tb_Nick.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 273);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 7;
            label3.Text = "Nick:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 324);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "Senha:";
            // 
            // lbl_Erro
            // 
            lbl_Erro.AutoSize = true;
            lbl_Erro.ForeColor = Color.Red;
            lbl_Erro.Location = new Point(213, 368);
            lbl_Erro.Name = "lbl_Erro";
            lbl_Erro.Size = new Size(0, 15);
            lbl_Erro.TabIndex = 9;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 465);
            Controls.Add(lbl_Erro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tb_Nick);
            Controls.Add(tb_Senha);
            Controls.Add(label2);
            Controls.Add(btn_Login);
            Controls.Add(btn_Registro);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_Registro;
        private Button btn_Login;
        private Label label2;
        private TextBox tb_Senha;
        private TextBox tb_Nick;
        private Label label3;
        private Label label4;
        private Label lbl_Erro;
    }
}
