﻿using System;
using System.Windows.Forms;

namespace wfm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text         = "VS 2019 Enterprise";
            label1.Text  = "hello vs 2019";
            button1.Text = "OK";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Close Now?");
            Close();
        }
    }
}
