﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_döngüsü_örnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baslangic, bitiş;
            baslangic = Convert.ToInt32(textBox1.Text);
            bitiş = Convert.ToInt32(textBox2.Text);
            for (int i = baslangic; i < bitiş; i++)
                listBox1.Items.Add(i);
            {

            }
        }
    }
}
