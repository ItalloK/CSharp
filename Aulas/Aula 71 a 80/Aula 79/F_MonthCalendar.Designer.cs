namespace Aula62
{
    partial class F_MonthCalendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.btn_pegardata = new System.Windows.Forms.Button();
            this.tb_3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(279, 59);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(204, 20);
            this.tb_1.TabIndex = 1;
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(279, 85);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(204, 20);
            this.tb_2.TabIndex = 2;
            // 
            // btn_pegardata
            // 
            this.btn_pegardata.Location = new System.Drawing.Point(279, 30);
            this.btn_pegardata.Name = "btn_pegardata";
            this.btn_pegardata.Size = new System.Drawing.Size(204, 23);
            this.btn_pegardata.TabIndex = 3;
            this.btn_pegardata.Text = "Pegar Data";
            this.btn_pegardata.UseVisualStyleBackColor = true;
            this.btn_pegardata.Click += new System.EventHandler(this.btn_pegardata_Click);
            // 
            // tb_3
            // 
            this.tb_3.Location = new System.Drawing.Point(279, 111);
            this.tb_3.Name = "tb_3";
            this.tb_3.Size = new System.Drawing.Size(204, 20);
            this.tb_3.TabIndex = 4;
            // 
            // F_MonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.tb_3);
            this.Controls.Add(this.btn_pegardata);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "F_MonthCalendar";
            this.Text = "F_MonthCalendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.Button btn_pegardata;
        private System.Windows.Forms.TextBox tb_3;
    }
}