﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinfromsTest
{
    public partial class Form1 : Form
    {
        private TextBox textBox1;
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
    {
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // textBox1
        // 
        this.textBox1.AcceptsReturn = true;
        this.textBox1.AcceptsTab = true;
        this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.textBox1.Multiline = true;
        this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        // 
        // Form1
        // 
        this.ClientSize = new System.Drawing.Size(284, 264);
        this.Controls.Add(this.textBox1);
        this.Text = "TextBox Example";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    }
}
