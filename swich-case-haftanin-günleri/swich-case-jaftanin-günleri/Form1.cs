using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swich_case_jaftanin_günleri
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
                    MessageBox.Show("pazartesşi");
                    break;
                case 2:
                    MessageBox.Show("salı");
                    break;
                case 3:
                    MessageBox.Show("çarşamba");
                    break;
                case 4:
                    MessageBox.Show("Perşembe");
                    break;
                case 5:
                    MessageBox.Show("Cuma");
                    break;
                case 6:
                    MessageBox.Show("Cumartesi");
                    break;
                case 7:
                    MessageBox.Show("Pazar");
                    break;
                default:
                    MessageBox.Show("Yanlış Değer");
                    break;
            }
        }
    }
}
