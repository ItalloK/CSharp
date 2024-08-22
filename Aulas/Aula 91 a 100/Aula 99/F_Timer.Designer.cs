namespace Aula90
{
    partial class F_Timer
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_iniciart1 = new System.Windows.Forms.Button();
            this.btn_parart1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_resetarcont1 = new System.Windows.Forms.Button();
            this.btn_iniciarfoto = new System.Windows.Forms.Button();
            this.TimerFoto = new System.Windows.Forms.Timer(this.components);
            this.btn_pararfoto = new System.Windows.Forms.Button();
            this.img_Foto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_iniciart1
            // 
            this.btn_iniciart1.Location = new System.Drawing.Point(12, 12);
            this.btn_iniciart1.Name = "btn_iniciart1";
            this.btn_iniciart1.Size = new System.Drawing.Size(115, 23);
            this.btn_iniciart1.TabIndex = 0;
            this.btn_iniciart1.Text = "Iniciar";
            this.btn_iniciart1.UseVisualStyleBackColor = true;
            this.btn_iniciart1.Click += new System.EventHandler(this.btn_iniciart1_Click);
            // 
            // btn_parart1
            // 
            this.btn_parart1.Location = new System.Drawing.Point(133, 12);
            this.btn_parart1.Name = "btn_parart1";
            this.btn_parart1.Size = new System.Drawing.Size(115, 23);
            this.btn_parart1.TabIndex = 1;
            this.btn_parart1.Text = "Parar";
            this.btn_parart1.UseVisualStyleBackColor = true;
            this.btn_parart1.Click += new System.EventHandler(this.btn_parart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btn_resetarcont1
            // 
            this.btn_resetarcont1.Location = new System.Drawing.Point(254, 12);
            this.btn_resetarcont1.Name = "btn_resetarcont1";
            this.btn_resetarcont1.Size = new System.Drawing.Size(115, 23);
            this.btn_resetarcont1.TabIndex = 3;
            this.btn_resetarcont1.Text = "Resetar Contagem";
            this.btn_resetarcont1.UseVisualStyleBackColor = true;
            this.btn_resetarcont1.Click += new System.EventHandler(this.btn_resetarcont1_Click);
            // 
            // btn_iniciarfoto
            // 
            this.btn_iniciarfoto.Location = new System.Drawing.Point(12, 100);
            this.btn_iniciarfoto.Name = "btn_iniciarfoto";
            this.btn_iniciarfoto.Size = new System.Drawing.Size(112, 23);
            this.btn_iniciarfoto.TabIndex = 5;
            this.btn_iniciarfoto.Text = "Iniciar Carro";
            this.btn_iniciarfoto.UseVisualStyleBackColor = true;
            this.btn_iniciarfoto.Click += new System.EventHandler(this.btn_iniciarfoto_Click);
            // 
            // TimerFoto
            // 
            this.TimerFoto.Interval = 1;
            this.TimerFoto.Tick += new System.EventHandler(this.TimerFoto_Tick);
            // 
            // btn_pararfoto
            // 
            this.btn_pararfoto.Location = new System.Drawing.Point(130, 100);
            this.btn_pararfoto.Name = "btn_pararfoto";
            this.btn_pararfoto.Size = new System.Drawing.Size(109, 23);
            this.btn_pararfoto.TabIndex = 6;
            this.btn_pararfoto.Text = "Parar Carro";
            this.btn_pararfoto.UseVisualStyleBackColor = true;
            this.btn_pararfoto.Click += new System.EventHandler(this.btn_pararfoto_Click);
            // 
            // img_Foto
            // 
            this.img_Foto.Image = global::Aula90.Properties.Resources.pngegg;
            this.img_Foto.Location = new System.Drawing.Point(12, 143);
            this.img_Foto.Name = "img_Foto";
            this.img_Foto.Size = new System.Drawing.Size(112, 60);
            this.img_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Foto.TabIndex = 4;
            this.img_Foto.TabStop = false;
            // 
            // F_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 402);
            this.Controls.Add(this.btn_pararfoto);
            this.Controls.Add(this.btn_iniciarfoto);
            this.Controls.Add(this.img_Foto);
            this.Controls.Add(this.btn_resetarcont1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_parart1);
            this.Controls.Add(this.btn_iniciart1);
            this.Name = "F_Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Timer";
            this.Load += new System.EventHandler(this.F_Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_iniciart1;
        private System.Windows.Forms.Button btn_parart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_resetarcont1;
        private System.Windows.Forms.PictureBox img_Foto;
        private System.Windows.Forms.Button btn_iniciarfoto;
        private System.Windows.Forms.Timer TimerFoto;
        private System.Windows.Forms.Button btn_pararfoto;
    }
}