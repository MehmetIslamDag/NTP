﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, yüzdelik;
            sayi1 = Convert.ToInt16(textBox1.Text);
            yüzdelik = sayi1 *18/100;
            MessageBox.Show(yüzdelik.ToString());
        }
    }
}
