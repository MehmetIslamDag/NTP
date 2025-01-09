using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanici_girişi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kullanici_adi, sifre;
        private void button1_Click(object sender, EventArgs e)
        {
            kullanici_adi=textBox1.Text;
            sifre = textBox2.Text;
            if(kullanici_adi=="islam47" && sifre=="4734")
            {
                MessageBox.Show("GİRİŞ BAŞARILI");
            }
            else
            {
                MessageBox.Show("kullanıcı adınız veya adınız yanlış girilmiştir");
            }

        }
    }
}
