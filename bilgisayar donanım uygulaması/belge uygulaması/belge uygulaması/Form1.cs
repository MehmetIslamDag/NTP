using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belge_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ortalama;
        private void button1_Click(object sender, EventArgs e)
        {
            ortalama = Convert.ToInt32(textBox1.Text);
            if (ortalama >=0 && ortalama <50)
            {
                MessageBox.Show("Öğrenci Sınıfta kalmıştır");
            }
            if (ortalama >49 && ortalama <70)
            {
                MessageBox.Show("Öğrenci Belgesiz Geçmiştir");
            }
            if (ortalama >69 && ortalama <85)
            {
                MessageBox.Show("Öğrenci Teşekkür Belgesi İle Geçmiştir");
            }
            if (ortalama >84 && ortalama < 101)
            {
                MessageBox.Show("Öğrenci Takdir Belgesi İle Geçmiştir");
            }
        }
    }
}
