﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula90
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_TrackBar f_TrackBar = new F_TrackBar();
            f_TrackBar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_TreeView f_TreeView = new F_TreeView();
            f_TreeView.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F_WebBrowser f_WebBrowser = new F_WebBrowser();
            f_WebBrowser.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            F_SplitContainer f_SplitContainer = new F_SplitContainer();
            f_SplitContainer.ShowDialog();
        }
    }
}
