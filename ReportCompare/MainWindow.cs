﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReportCompare
{
    public partial class MainWindow : Form
    {
        TextWriter _writer = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Program.start();
        }

        public static string textBox1 { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Instantiate the writer
            _writer = new TextBoxStreamWriter(txtConsole);
            // Redirect the out Console stream
            Console.SetOut(_writer);

            Console.WriteLine("Ready to work");
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            var optionsForm = new OptionsWindow();
            optionsForm.ShowDialog();
        }

    }
}