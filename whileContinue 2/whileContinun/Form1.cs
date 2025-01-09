using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whileContinun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            do
            {
         MessageBox.Show("döngü çalışıyor : " +sayi.ToString());
                if (sayi==5)
                {
                    MessageBox.Show("döngü durdu");
                    break;
                }
                sayi++;
                
            } while (sayi<10);
        }
    }
}
