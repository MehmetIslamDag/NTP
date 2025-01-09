using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okul_kademesi_kombo_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte sinif;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sinif = Convert.ToByte(comboBox1.Text);
            if (sinif > 0 && sinif < 5)
            {
                MessageBox.Show("ilkokul kademesindesiniz");
            }
            if (sinif > 4 && sinif <9)
            {
                MessageBox.Show("ortaokul kademesindesiniz");
            }
            if (sinif > 8 && sinif < 13)
            {
                MessageBox.Show("lise kademesindesiniz");
            }
        }
    }
}
