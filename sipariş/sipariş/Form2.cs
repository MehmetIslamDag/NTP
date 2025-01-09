using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sipariş
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form3 frm3 = new Form3();
        private void adanaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void yemeklerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void yEMEKLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm3.Show();
        }
    }
}
