using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mac_Skoru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int skor1, skor2;
        private void button1_Click(object sender, EventArgs e)
        {
            skor1 = Convert.ToInt32(textBox1.Text);
            skor2 = Convert.ToInt32(textBox2.Text);
            if (skor1 > skor2)
            {
                MessageBox.Show(" Beşiktaş Kazandı");
            }
            if (skor1 < skor2)
            {
                MessageBox.Show("Real Madrid Kazandı ");
            }
            else
            {
                MessageBox.Show("Maç Berabere Bitmiştir");
            }
        }
    }
}
