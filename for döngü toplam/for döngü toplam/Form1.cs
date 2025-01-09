using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_döngü_toplam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int başlangıç, bitiş, çarpma;
            çarpma = 1;
            başlangıç = Convert.ToInt32(textBox1.Text);
            bitiş = Convert.ToInt32(textBox2.Text);
            for (int i = başlangıç; i < bitiş; i++)
            {
                çarpma = çarpma * i;
            }
            MessageBox.Show("sayıların çarpımı :" + çarpma.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int başlangıç, bitiş,toplam;
            toplam = 0;
            başlangıç = Convert.ToInt32(textBox1.Text);
            bitiş = Convert.ToInt32(textBox2.Text);
            for (int i = başlangıç; i < bitiş; i++)
            {
                toplam = toplam + i;
            }
            MessageBox.Show("sayıların toplmı :"+ toplam.ToString());
        }
    }
}
