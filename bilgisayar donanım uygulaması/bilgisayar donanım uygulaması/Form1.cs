using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgisayar_donanım_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string secim;
        private void button1_Click(object sender, EventArgs e)
        {
            secim = listBox1.SelectedItem.ToString();
            if (secim=="MOUSE"||secim == "KLAVYE"||secim == "KAMERA"||secim == "TARAYICI")
            {
                MessageBox.Show("bu parça,giriş aygıtıdır");
            }
            if (secim == "YAZICI" || secim == "HOPERLÖR" || secim == "PROJEKSİYON")
            {
                MessageBox.Show("bu parça,çıkış aygıtıdır");
            }
        }
    }
}
