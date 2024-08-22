namespace Cadastro
{
    partial class F_InicioUsuario
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
            this.lb_data = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_marcarconsulta = new System.Windows.Forms.Button();
            this.btn_sttsagendamento = new System.Windows.Forms.Button();
            this.btn_receberexames = new System.Windows.Forms.Button();
            this.btn_meucadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lb_data.Location = new System.Drawing.Point(2, 3);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(44, 20);
            this.lb_data.TabIndex = 0;
            this.lb_data.Text = "Data";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cadastro.Properties.Resources.medicine_symbol_logo_C5F32D7618_seeklogo_com;
            this.pictureBox1.Location = new System.Drawing.Point(230, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(235, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha a opção desejada:";
            // 
            // btn_marcarconsulta
            // 
            this.btn_marcarconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_marcarconsulta.Location = new System.Drawing.Point(242, 276);
            this.btn_marcarconsulta.Name = "btn_marcarconsulta";
            this.btn_marcarconsulta.Size = new System.Drawing.Size(176, 31);
            this.btn_marcarconsulta.TabIndex = 3;
            this.btn_marcarconsulta.Text = "Marcar Consulta";
            this.btn_marcarconsulta.UseVisualStyleBackColor = true;
            // 
            // btn_sttsagendamento
            // 
            this.btn_sttsagendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_sttsagendamento.Location = new System.Drawing.Point(242, 323);
            this.btn_sttsagendamento.Name = "btn_sttsagendamento";
            this.btn_sttsagendamento.Size = new System.Drawing.Size(176, 31);
            this.btn_sttsagendamento.TabIndex = 4;
            this.btn_sttsagendamento.Text = "Status do Agendamento";
            this.btn_sttsagendamento.UseVisualStyleBackColor = true;
            // 
            // btn_receberexames
            // 
            this.btn_receberexames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_receberexames.Location = new System.Drawing.Point(242, 372);
            this.btn_receberexames.Name = "btn_receberexames";
            this.btn_receberexames.Size = new System.Drawing.Size(176, 31);
            this.btn_receberexames.TabIndex = 5;
            this.btn_receberexames.Text = "Receber Exames";
            this.btn_receberexames.UseVisualStyleBackColor = true;
            // 
            // btn_meucadastro
            // 
            this.btn_meucadastro.Location = new System.Drawing.Point(542, 415);
            this.btn_meucadastro.Name = "btn_meucadastro";
            this.btn_meucadastro.Size = new System.Drawing.Size(111, 23);
            this.btn_meucadastro.TabIndex = 6;
            this.btn_meucadastro.Text = "Meu Cadastro";
            this.btn_meucadastro.UseVisualStyleBackColor = true;
            this.btn_meucadastro.Click += new System.EventHandler(this.btn_meucadastro_Click);
            // 
            // F_InicioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.btn_meucadastro);
            this.Controls.Add(this.btn_receberexames);
            this.Controls.Add(this.btn_sttsagendamento);
            this.Controls.Add(this.btn_marcarconsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_data);
            this.Name = "F_InicioUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_InicioUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_marcarconsulta;
        private System.Windows.Forms.Button btn_sttsagendamento;
        private System.Windows.Forms.Button btn_receberexames;
        private System.Windows.Forms.Button btn_meucadastro;
    }
}