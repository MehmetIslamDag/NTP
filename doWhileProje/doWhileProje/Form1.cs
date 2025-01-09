using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doWhileProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int başlangıç = Convert.ToInt32(textBox1.Text);
            int bitiş = Convert.ToInt32(textBox2.Text);
            int i = başlangıç;

            do
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    listBox1.Items.Add(i);
                }
                if (i % 7 == 0)
                {
                    listBox2.Items.Add(i);
                }
                if (i % 3  == 0 && i % 5 == 0 && i % 7 == 0)
                {
                    listBox3.Items.Add(i);
                }
                i++;
            } while (i<=bitiş);
        }
    }
}
