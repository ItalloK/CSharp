namespace JogoDaVelha
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnlimpar = new Button();
            PontosX = new Label();
            BolaPontos = new Label();
            Empates = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            menuStrip1 = new MenuStrip();
            tEMASToolStripMenuItem = new ToolStripMenuItem();
            rosaToolStripMenuItem = new ToolStripMenuItem();
            pretoToolStripMenuItem = new ToolStripMenuItem();
            flamengoToolStripMenuItem = new ToolStripMenuItem();
            versusToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            btm = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            panel3 = new Panel();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            panel4 = new Panel();
            panel1 = new Panel();
            panel5.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnlimpar
            // 
            btnlimpar.BackColor = Color.FromArgb(255, 192, 255);
            btnlimpar.Cursor = Cursors.Hand;
            btnlimpar.FlatAppearance.BorderColor = Color.Fuchsia;
            btnlimpar.FlatAppearance.BorderSize = 2;
            btnlimpar.FlatStyle = FlatStyle.Flat;
            btnlimpar.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnlimpar.ForeColor = SystemColors.ActiveCaptionText;
            btnlimpar.Location = new Point(84, 326);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(309, 53);
            btnlimpar.TabIndex = 2;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = false;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // PontosX
            // 
            PontosX.AutoSize = true;
            PontosX.BackColor = Color.Transparent;
            PontosX.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            PontosX.ForeColor = SystemColors.ControlLightLight;
            PontosX.Location = new Point(41, 51);
            PontosX.Name = "PontosX";
            PontosX.Size = new Size(26, 30);
            PontosX.TabIndex = 0;
            PontosX.Text = "0";
            // 
            // BolaPontos
            // 
            BolaPontos.AutoSize = true;
            BolaPontos.BackColor = Color.Transparent;
            BolaPontos.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            BolaPontos.ForeColor = SystemColors.ControlLightLight;
            BolaPontos.Location = new Point(228, 51);
            BolaPontos.Name = "BolaPontos";
            BolaPontos.Size = new Size(26, 30);
            BolaPontos.TabIndex = 1;
            BolaPontos.Text = "0";
            // 
            // Empates
            // 
            Empates.AutoSize = true;
            Empates.BackColor = Color.Transparent;
            Empates.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Empates.ForeColor = SystemColors.ControlLightLight;
            Empates.Location = new Point(418, 52);
            Empates.Name = "Empates";
            Empates.Size = new Size(26, 30);
            Empates.TabIndex = 2;
            Empates.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 3;
            label1.Text = "X Pontos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(189, 26);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 4;
            label2.Text = "O Pontos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(389, 26);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 5;
            label3.Text = "Empates";
            label3.Click += label3_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(Empates);
            panel5.Controls.Add(BolaPontos);
            panel5.Controls.Add(PontosX);
            panel5.Location = new Point(0, 394);
            panel5.Name = "panel5";
            panel5.Size = new Size(491, 90);
            panel5.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tEMASToolStripMenuItem, versusToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(484, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // tEMASToolStripMenuItem
            // 
            tEMASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rosaToolStripMenuItem, pretoToolStripMenuItem, flamengoToolStripMenuItem });
            tEMASToolStripMenuItem.Name = "tEMASToolStripMenuItem";
            tEMASToolStripMenuItem.Size = new Size(52, 20);
            tEMASToolStripMenuItem.Text = "Temas";
            // 
            // rosaToolStripMenuItem
            // 
            rosaToolStripMenuItem.Name = "rosaToolStripMenuItem";
            rosaToolStripMenuItem.Size = new Size(127, 22);
            rosaToolStripMenuItem.Text = "Rosa";
            rosaToolStripMenuItem.Click += rosaToolStripMenuItem_Click;
            // 
            // pretoToolStripMenuItem
            // 
            pretoToolStripMenuItem.Name = "pretoToolStripMenuItem";
            pretoToolStripMenuItem.Size = new Size(127, 22);
            pretoToolStripMenuItem.Text = "Preto";
            pretoToolStripMenuItem.Click += pretoToolStripMenuItem_Click;
            // 
            // flamengoToolStripMenuItem
            // 
            flamengoToolStripMenuItem.Name = "flamengoToolStripMenuItem";
            flamengoToolStripMenuItem.Size = new Size(127, 22);
            flamengoToolStripMenuItem.Text = "Flamengo";
            flamengoToolStripMenuItem.Click += flamengoToolStripMenuItem_Click;
            // 
            // versusToolStripMenuItem
            // 
            versusToolStripMenuItem.Name = "versusToolStripMenuItem";
            versusToolStripMenuItem.Size = new Size(52, 20);
            versusToolStripMenuItem.Text = "Versus";
            versusToolStripMenuItem.Click += versusToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(1, 323);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 129);
            panel2.TabIndex = 1;
            // 
            // btm
            // 
            btm.BackColor = Color.Transparent;
            btm.Cursor = Cursors.Hand;
            btm.FlatAppearance.BorderColor = Color.Fuchsia;
            btm.FlatAppearance.BorderSize = 2;
            btm.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btm.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 214, 232);
            btm.FlatStyle = FlatStyle.Flat;
            btm.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            btm.ForeColor = Color.Black;
            btm.Location = new Point(84, 9);
            btm.Name = "btm";
            btm.Size = new Size(99, 80);
            btm.TabIndex = 0;
            btm.UseVisualStyleBackColor = false;
            btm.Click += btm_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Fuchsia;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 214, 232);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button1.Location = new Point(294, 9);
            button1.Name = "button1";
            button1.Size = new Size(99, 80);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btm_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Fuchsia;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 214, 232);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button2.Location = new Point(189, 9);
            button2.Name = "button2";
            button2.Size = new Size(99, 80);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btm_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.Fuchsia;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 214, 232);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button3.Location = new Point(84, 95);
            button3.Name = "button3";
            button3.Size = new Size(99, 80);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            button3.Click += btm_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.Fuchsia;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 214, 232);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button4.Location = new Point(189, 95);
            button4.Name = "button4";
            button4.Size = new Size(99, 80);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = false;
            button4.Click += btm_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.Fuchsia;
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 214, 232);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button5.Location = new Point(294, 95);
            button5.Name = "button5";
            button5.Size = new Size(99, 80);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = false;
            button5.Click += btm_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.Fuchsia;
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 214, 232);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button6.Location = new Point(84, 181);
            button6.Name = "button6";
            button6.Size = new Size(99, 80);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = false;
            button6.Click += btm_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = Color.Fuchsia;
            button7.FlatAppearance.BorderSize = 2;
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 214, 232);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button7.Location = new Point(189, 181);
            button7.Name = "button7";
            button7.Size = new Size(99, 80);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = false;
            button7.Click += btm_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderColor = Color.Fuchsia;
            button8.FlatAppearance.BorderSize = 2;
            button8.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 214, 232);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button8.Location = new Point(294, 181);
            button8.Name = "button8";
            button8.Size = new Size(99, 80);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = false;
            button8.Click += btm_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button10);
            panel3.Controls.Add(button11);
            panel3.Controls.Add(button12);
            panel3.Controls.Add(button13);
            panel3.Controls.Add(button14);
            panel3.Controls.Add(button15);
            panel3.Controls.Add(button16);
            panel3.Controls.Add(button17);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(0, 291);
            panel3.Name = "panel3";
            panel3.Size = new Size(483, 150);
            panel3.TabIndex = 11;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonFace;
            button9.Cursor = Cursors.Hand;
            button9.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button9.Location = new Point(294, 181);
            button9.Name = "button9";
            button9.Size = new Size(99, 80);
            button9.TabIndex = 10;
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ButtonFace;
            button10.Cursor = Cursors.Hand;
            button10.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button10.Location = new Point(189, 181);
            button10.Name = "button10";
            button10.Size = new Size(99, 80);
            button10.TabIndex = 9;
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.ButtonFace;
            button11.Cursor = Cursors.Hand;
            button11.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button11.Location = new Point(84, 181);
            button11.Name = "button11";
            button11.Size = new Size(99, 80);
            button11.TabIndex = 8;
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.ButtonFace;
            button12.Cursor = Cursors.Hand;
            button12.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button12.Location = new Point(294, 95);
            button12.Name = "button12";
            button12.Size = new Size(99, 80);
            button12.TabIndex = 7;
            button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.ButtonFace;
            button13.Cursor = Cursors.Hand;
            button13.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button13.Location = new Point(189, 95);
            button13.Name = "button13";
            button13.Size = new Size(99, 80);
            button13.TabIndex = 6;
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.ButtonFace;
            button14.Cursor = Cursors.Hand;
            button14.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button14.Location = new Point(84, 95);
            button14.Name = "button14";
            button14.Size = new Size(99, 80);
            button14.TabIndex = 5;
            button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.ButtonFace;
            button15.Cursor = Cursors.Hand;
            button15.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button15.Location = new Point(189, 9);
            button15.Name = "button15";
            button15.Size = new Size(99, 80);
            button15.TabIndex = 4;
            button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.ButtonFace;
            button16.Cursor = Cursors.Hand;
            button16.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button16.Location = new Point(294, 9);
            button16.Name = "button16";
            button16.Size = new Size(99, 80);
            button16.TabIndex = 3;
            button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            button17.BackColor = SystemColors.ButtonFace;
            button17.Cursor = Cursors.Hand;
            button17.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button17.Location = new Point(84, 9);
            button17.Name = "button17";
            button17.Size = new Size(99, 80);
            button17.TabIndex = 2;
            button17.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Location = new Point(1, 323);
            panel4.Name = "panel4";
            panel4.Size = new Size(482, 129);
            panel4.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btm);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 273);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(484, 489);
            Controls.Add(btnlimpar);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo da Velha by: Italo";
            Load += Form1_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnlimpar;
        private Label PontosX;
        private Label BolaPontos;
        private Label Empates;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tEMASToolStripMenuItem;
        private ToolStripMenuItem rosaToolStripMenuItem;
        private ToolStripMenuItem pretoToolStripMenuItem;
        private ToolStripMenuItem flamengoToolStripMenuItem;
        private ToolStripMenuItem versusToolStripMenuItem;
        private Panel panel2;
        private Button btm;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Panel panel3;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Panel panel4;
        private Panel panel1;
    }
}
