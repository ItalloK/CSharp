namespace Aula62
{
    partial class F_CheckedListBox
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
            this.clb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_mostrarselecionados = new System.Windows.Forms.Button();
            this.btn_limparlista = new System.Windows.Forms.Button();
            this.btn_resetarlista = new System.Windows.Forms.Button();
            this.btn_addtransporte = new System.Windows.Forms.Button();
            this.tb_novotransporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_transportes
            // 
            this.clb_transportes.FormattingEnabled = true;
            this.clb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Onibus",
            "Trem"});
            this.clb_transportes.Location = new System.Drawing.Point(12, 12);
            this.clb_transportes.Name = "clb_transportes";
            this.clb_transportes.Size = new System.Drawing.Size(174, 289);
            this.clb_transportes.TabIndex = 0;
            // 
            // btn_mostrarselecionados
            // 
            this.btn_mostrarselecionados.Location = new System.Drawing.Point(192, 12);
            this.btn_mostrarselecionados.Name = "btn_mostrarselecionados";
            this.btn_mostrarselecionados.Size = new System.Drawing.Size(242, 23);
            this.btn_mostrarselecionados.TabIndex = 1;
            this.btn_mostrarselecionados.Text = "Mostrar Selecionados";
            this.btn_mostrarselecionados.UseVisualStyleBackColor = true;
            this.btn_mostrarselecionados.Click += new System.EventHandler(this.btn_mostrarselecionados_Click);
            // 
            // btn_limparlista
            // 
            this.btn_limparlista.Location = new System.Drawing.Point(192, 41);
            this.btn_limparlista.Name = "btn_limparlista";
            this.btn_limparlista.Size = new System.Drawing.Size(242, 23);
            this.btn_limparlista.TabIndex = 2;
            this.btn_limparlista.Text = "Limpar Lista";
            this.btn_limparlista.UseVisualStyleBackColor = true;
            this.btn_limparlista.Click += new System.EventHandler(this.btn_limparlista_Click);
            // 
            // btn_resetarlista
            // 
            this.btn_resetarlista.Location = new System.Drawing.Point(192, 70);
            this.btn_resetarlista.Name = "btn_resetarlista";
            this.btn_resetarlista.Size = new System.Drawing.Size(243, 23);
            this.btn_resetarlista.TabIndex = 3;
            this.btn_resetarlista.Text = "Resetar Lista";
            this.btn_resetarlista.UseVisualStyleBackColor = true;
            this.btn_resetarlista.Click += new System.EventHandler(this.btn_resetarlista_Click);
            // 
            // btn_addtransporte
            // 
            this.btn_addtransporte.Location = new System.Drawing.Point(192, 278);
            this.btn_addtransporte.Name = "btn_addtransporte";
            this.btn_addtransporte.Size = new System.Drawing.Size(242, 23);
            this.btn_addtransporte.TabIndex = 4;
            this.btn_addtransporte.Text = "Adicionar Transporte";
            this.btn_addtransporte.UseVisualStyleBackColor = true;
            this.btn_addtransporte.Click += new System.EventHandler(this.btn_addtransporte_Click);
            // 
            // tb_novotransporte
            // 
            this.tb_novotransporte.Location = new System.Drawing.Point(192, 252);
            this.tb_novotransporte.Name = "tb_novotransporte";
            this.tb_novotransporte.Size = new System.Drawing.Size(242, 20);
            this.tb_novotransporte.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um novo Transporte:";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_novotransporte);
            this.Controls.Add(this.btn_addtransporte);
            this.Controls.Add(this.btn_resetarlista);
            this.Controls.Add(this.btn_limparlista);
            this.Controls.Add(this.btn_mostrarselecionados);
            this.Controls.Add(this.clb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transportes;
        private System.Windows.Forms.Button btn_mostrarselecionados;
        private System.Windows.Forms.Button btn_limparlista;
        private System.Windows.Forms.Button btn_resetarlista;
        private System.Windows.Forms.Button btn_addtransporte;
        private System.Windows.Forms.TextBox tb_novotransporte;
        private System.Windows.Forms.Label label1;
    }
}