using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mevsimler_swich_case1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mevsim = Convert.ToInt32(textBox1.Text);
            switch (mevsim)
            {
                case 1:
                    this.BackColor = Color.White;
                    MessageBox.Show("Temanız kış olmuştur");
                    break;
                case 2:
                    this.BackColor = Color.DarkOrange;
                    MessageBox.Show("Temanız Sonbahar Olmuştur");
                    break;
                case 3:
                    this.BackColor = Color.Yellow;
                    MessageBox.Show("Temanız Yaz Olmuştur");
                    break;
                case 4:
                    this.BackColor = Color.Coral;
                    MessageBox.Show("Temanız İlkbahar Olmuştur");
                    break;
                default:
                    break;
            }
        }
    }
}
