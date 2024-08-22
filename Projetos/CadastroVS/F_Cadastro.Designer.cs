namespace Cadastro
{
    partial class F_Cadastro
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
            this.lb_nome = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_infos = new System.Windows.Forms.Label();
            this.tb_infos = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.tb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lb_nome.Location = new System.Drawing.Point(12, 9);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(60, 20);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "Nome:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(69, 11);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(559, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lb_cpf.Location = new System.Drawing.Point(12, 52);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(48, 20);
            this.lb_cpf.TabIndex = 4;
            this.lb_cpf.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(302, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Telefone:";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lb_email.Location = new System.Drawing.Point(12, 93);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(58, 20);
            this.lb_email.TabIndex = 6;
            this.lb_email.Text = "Email:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(69, 92);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(559, 20);
            this.tb_email.TabIndex = 7;
            // 
            // lb_infos
            // 
            this.lb_infos.AutoSize = true;
            this.lb_infos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lb_infos.Location = new System.Drawing.Point(15, 134);
            this.lb_infos.Name = "lb_infos";
            this.lb_infos.Size = new System.Drawing.Size(55, 20);
            this.lb_infos.TabIndex = 8;
            this.lb_infos.Text = "Infos:";
            // 
            // tb_infos
            // 
            this.tb_infos.Location = new System.Drawing.Point(69, 136);
            this.tb_infos.Multiline = true;
            this.tb_infos.Name = "tb_infos";
            this.tb_infos.Size = new System.Drawing.Size(559, 119);
            this.tb_infos.TabIndex = 9;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_enviar.Location = new System.Drawing.Point(209, 283);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(228, 46);
            this.btn_enviar.TabIndex = 10;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(69, 54);
            this.tb_cpf.Mask = "000.000.000-00";
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(227, 20);
            this.tb_cpf.TabIndex = 11;
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(392, 54);
            this.tb_telefone.Mask = "(00) 00000-0000";
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(236, 20);
            this.tb_telefone.TabIndex = 12;
            // 
            // F_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 341);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.tb_infos);
            this.Controls.Add(this.lb_infos);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_infos;
        private System.Windows.Forms.TextBox tb_infos;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.MaskedTextBox tb_cpf;
        private System.Windows.Forms.MaskedTextBox tb_telefone;
    }
}