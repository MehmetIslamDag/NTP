﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;
            sayi1 = Convert.ToInt32(textBox1.Text);
            if (sayi1 >=1 && sayi1 <=4 )
            {
                MessageBox.Show("ilkokul kademesindesiniz");
            }
            if (sayi1 >=5 && sayi1 <=8)
            {
                MessageBox.Show("ortaokul kademesindesinz");
            }
            if (sayi1 >=9 && sayi1 <=12)
            {
                MessageBox.Show("lise kademesindesiniz");
            }
            if (sayi1 >12 )
            {
                MessageBox.Show("herhangi bir kademede değilsiniz");
            }
            if (sayi1 == 0)
            {
                MessageBox.Show("herhangi bir kademede değilsiniz");
            }
        }
    }
}
