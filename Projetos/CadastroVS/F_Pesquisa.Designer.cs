namespace Cadastro
{
    partial class F_Pesquisa
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_escolha = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtb_1 = new System.Windows.Forms.MaskedTextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.lv_pessoas = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_cpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_infos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha a opção que deseja pesquisar:";
            // 
            // cb_escolha
            // 
            this.cb_escolha.FormattingEnabled = true;
            this.cb_escolha.Location = new System.Drawing.Point(15, 29);
            this.cb_escolha.Name = "cb_escolha";
            this.cb_escolha.Size = new System.Drawing.Size(254, 21);
            this.cb_escolha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preencha com as informações:";
            // 
            // mtb_1
            // 
            this.mtb_1.Location = new System.Drawing.Point(15, 87);
            this.mtb_1.Name = "mtb_1";
            this.mtb_1.Size = new System.Drawing.Size(254, 20);
            this.mtb_1.TabIndex = 3;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(15, 122);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(254, 23);
            this.btn_pesquisar.TabIndex = 4;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // lv_pessoas
            // 
            this.lv_pessoas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_nome,
            this.col_cpf,
            this.col_telefone,
            this.col_email,
            this.col_infos});
            this.lv_pessoas.FullRowSelect = true;
            this.lv_pessoas.HideSelection = false;
            this.lv_pessoas.Location = new System.Drawing.Point(15, 164);
            this.lv_pessoas.MultiSelect = false;
            this.lv_pessoas.Name = "lv_pessoas";
            this.lv_pessoas.Size = new System.Drawing.Size(879, 323);
            this.lv_pessoas.TabIndex = 5;
            this.lv_pessoas.UseCompatibleStateImageBehavior = false;
            this.lv_pessoas.View = System.Windows.Forms.View.Details;
            // 
            // col_id
            // 
            this.col_id.Text = "ID";
            this.col_id.Width = 55;
            // 
            // col_nome
            // 
            this.col_nome.Text = "Nome";
            this.col_nome.Width = 170;
            // 
            // col_cpf
            // 
            this.col_cpf.Text = "CPF";
            this.col_cpf.Width = 125;
            // 
            // col_telefone
            // 
            this.col_telefone.Text = "Telefone";
            this.col_telefone.Width = 135;
            // 
            // col_email
            // 
            this.col_email.Text = "Email";
            this.col_email.Width = 100;
            // 
            // col_infos
            // 
            this.col_infos.Text = "Informações";
            this.col_infos.Width = 255;
            // 
            // F_Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 499);
            this.Controls.Add(this.lv_pessoas);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.mtb_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_escolha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Pesquisa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_escolha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtb_1;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.ListView lv_pessoas;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_nome;
        private System.Windows.Forms.ColumnHeader col_cpf;
        private System.Windows.Forms.ColumnHeader col_telefone;
        private System.Windows.Forms.ColumnHeader col_email;
        private System.Windows.Forms.ColumnHeader col_infos;
    }
}