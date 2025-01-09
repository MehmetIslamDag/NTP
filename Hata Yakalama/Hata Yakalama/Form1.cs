using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hata_Yakalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, kare;
            try
            {
                sayi = Convert.ToInt32(textBox1.Text);
                kare = sayi * sayi;
                MessageBox.Show(kare.ToString());
            }
            catch 
            {

                MessageBox.Show("hatalı giriş yaptınız lütfen sadece sayi giriniz");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
