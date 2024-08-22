namespace Aula90
{
    partial class F_TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_nomenovaaba = new System.Windows.Forms.TextBox();
            this.btn_novatab = new System.Windows.Forms.Button();
            this.btn_removertabatual = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_posicionartab = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 370);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Componentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(612, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_nomenovaaba
            // 
            this.tb_nomenovaaba.Location = new System.Drawing.Point(12, 12);
            this.tb_nomenovaaba.Name = "tb_nomenovaaba";
            this.tb_nomenovaaba.Size = new System.Drawing.Size(100, 20);
            this.tb_nomenovaaba.TabIndex = 1;
            // 
            // btn_novatab
            // 
            this.btn_novatab.Location = new System.Drawing.Point(118, 10);
            this.btn_novatab.Name = "btn_novatab";
            this.btn_novatab.Size = new System.Drawing.Size(139, 23);
            this.btn_novatab.TabIndex = 2;
            this.btn_novatab.Text = "Nova Tab";
            this.btn_novatab.UseVisualStyleBackColor = true;
            this.btn_novatab.Click += new System.EventHandler(this.btn_novatab_Click);
            // 
            // btn_removertabatual
            // 
            this.btn_removertabatual.Location = new System.Drawing.Point(263, 10);
            this.btn_removertabatual.Name = "btn_removertabatual";
            this.btn_removertabatual.Size = new System.Drawing.Size(139, 23);
            this.btn_removertabatual.TabIndex = 3;
            this.btn_removertabatual.Text = "Remover Tab Atual";
            this.btn_removertabatual.UseVisualStyleBackColor = true;
            this.btn_removertabatual.Click += new System.EventHandler(this.btn_removertabatual_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 39);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // btn_posicionartab
            // 
            this.btn_posicionartab.Location = new System.Drawing.Point(118, 39);
            this.btn_posicionartab.Name = "btn_posicionartab";
            this.btn_posicionartab.Size = new System.Drawing.Size(139, 23);
            this.btn_posicionartab.TabIndex = 5;
            this.btn_posicionartab.Text = "Posicionar na Tab";
            this.btn_posicionartab.UseVisualStyleBackColor = true;
            this.btn_posicionartab.Click += new System.EventHandler(this.btn_posicionartab_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // F_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.btn_posicionartab);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_removertabatual);
            this.Controls.Add(this.btn_novatab);
            this.Controls.Add(this.tb_nomenovaaba);
            this.Controls.Add(this.tabControl1);
            this.Name = "F_TabControl";
            this.Text = "F_TabControl";
            this.Load += new System.EventHandler(this.F_TabControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_nomenovaaba;
        private System.Windows.Forms.Button btn_novatab;
        private System.Windows.Forms.Button btn_removertabatual;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_posicionartab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}