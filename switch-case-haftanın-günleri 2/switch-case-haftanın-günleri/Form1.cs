using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case_haftanın_günleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int gün = Convert.ToInt32(textBox1.Text);
            switch (gün)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    MessageBox.Show("hafta içi");
                    break;
                case 6:
                case 7:
                    MessageBox.Show("hafta sonu");
                    break;

                default:
                    MessageBox.Show("yanlış değer");
                    break;
                    
            }

        }
    }
}
