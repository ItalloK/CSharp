namespace Aula62
{
    partial class F_ComboBox
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
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.btn_mostrarselecionado = new System.Windows.Forms.Button();
            this.btn_limparcombobox = new System.Windows.Forms.Button();
            this.btn_resetarelementos = new System.Windows.Forms.Button();
            this.tb_novotransporte = new System.Windows.Forms.TextBox();
            this.btn_addnovotransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Onibus",
            "Trem"});
            this.cb_transportes.Location = new System.Drawing.Point(12, 12);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(288, 21);
            this.cb_transportes.TabIndex = 0;
            this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
            // 
            // btn_mostrarselecionado
            // 
            this.btn_mostrarselecionado.Location = new System.Drawing.Point(306, 12);
            this.btn_mostrarselecionado.Name = "btn_mostrarselecionado";
            this.btn_mostrarselecionado.Size = new System.Drawing.Size(200, 23);
            this.btn_mostrarselecionado.TabIndex = 1;
            this.btn_mostrarselecionado.Text = "Mostrar Selecionado";
            this.btn_mostrarselecionado.UseVisualStyleBackColor = true;
            this.btn_mostrarselecionado.Click += new System.EventHandler(this.btn_mostrarselecionado_Click);
            // 
            // btn_limparcombobox
            // 
            this.btn_limparcombobox.Location = new System.Drawing.Point(306, 41);
            this.btn_limparcombobox.Name = "btn_limparcombobox";
            this.btn_limparcombobox.Size = new System.Drawing.Size(200, 23);
            this.btn_limparcombobox.TabIndex = 2;
            this.btn_limparcombobox.Text = "Limpar ComboBox";
            this.btn_limparcombobox.UseVisualStyleBackColor = true;
            this.btn_limparcombobox.Click += new System.EventHandler(this.btn_limparcombobox_Click);
            // 
            // btn_resetarelementos
            // 
            this.btn_resetarelementos.Location = new System.Drawing.Point(306, 70);
            this.btn_resetarelementos.Name = "btn_resetarelementos";
            this.btn_resetarelementos.Size = new System.Drawing.Size(200, 23);
            this.btn_resetarelementos.TabIndex = 3;
            this.btn_resetarelementos.Text = "Resetar Elementos";
            this.btn_resetarelementos.UseVisualStyleBackColor = true;
            this.btn_resetarelementos.Click += new System.EventHandler(this.btn_resetarelementos_Click);
            // 
            // tb_novotransporte
            // 
            this.tb_novotransporte.Location = new System.Drawing.Point(306, 136);
            this.tb_novotransporte.Name = "tb_novotransporte";
            this.tb_novotransporte.Size = new System.Drawing.Size(200, 20);
            this.tb_novotransporte.TabIndex = 4;
            // 
            // btn_addnovotransporte
            // 
            this.btn_addnovotransporte.Location = new System.Drawing.Point(306, 162);
            this.btn_addnovotransporte.Name = "btn_addnovotransporte";
            this.btn_addnovotransporte.Size = new System.Drawing.Size(200, 23);
            this.btn_addnovotransporte.TabIndex = 5;
            this.btn_addnovotransporte.Text = "Adicionar novo transporte";
            this.btn_addnovotransporte.UseVisualStyleBackColor = true;
            this.btn_addnovotransporte.Click += new System.EventHandler(this.btn_addnovotransporte_Click);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 427);
            this.Controls.Add(this.btn_addnovotransporte);
            this.Controls.Add(this.tb_novotransporte);
            this.Controls.Add(this.btn_resetarelementos);
            this.Controls.Add(this.btn_limparcombobox);
            this.Controls.Add(this.btn_mostrarselecionado);
            this.Controls.Add(this.cb_transportes);
            this.Name = "F_ComboBox";
            this.Text = "F_ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_transportes;
        private System.Windows.Forms.Button btn_mostrarselecionado;
        private System.Windows.Forms.Button btn_limparcombobox;
        private System.Windows.Forms.Button btn_resetarelementos;
        private System.Windows.Forms.TextBox tb_novotransporte;
        private System.Windows.Forms.Button btn_addnovotransporte;
    }
}