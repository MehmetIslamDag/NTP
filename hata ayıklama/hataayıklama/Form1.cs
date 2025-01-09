using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hataayıklama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1,sayi2,sonuç;
                sayi1 = 10;
                sayi2 = 0;
                sonuç = sayi1 / sayi2;
            }
            catch 
            {
                MessageBox.Show("sayı sıfıra bölünmez   "+ ex.Message);

            }
        }
    }
}
