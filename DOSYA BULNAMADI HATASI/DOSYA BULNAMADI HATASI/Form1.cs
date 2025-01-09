using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOSYA_BULNAMADI_HATASI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "C://Users//Lab2-01//Pictures//Camera Roll";
            if (System.IO.File.Exists(filePath))
            {
                MessageBox.Show("dosyanız bulundu");
            }
            else
            {
                try
                {
                    //System.IO.File.OpenRead(filePath);
                }
                catch (System.IO.FileNotFoundException ex)
                {
                    MessageBox.Show("dosyanız bulunamadı" + ex.Message);
                }

            }
        }
    }
}
