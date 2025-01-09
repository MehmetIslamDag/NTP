using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vücut_kütle_endeks_hesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double kilo, boy,sonuc ;
        private void button1_Click(object sender, EventArgs e)
        {
            kilo = Convert.ToDouble(textBox1.Text);
            boy = Convert.ToDouble(textBox2.Text);
            sonuc =kilo/(boy*boy);
            MessageBox.Show("vücut kütle endeksiniz = "+ sonuc);
        }
    }
}
