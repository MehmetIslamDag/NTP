using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hata_Ayıklama_Parola_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parola = textBox1.Text;
            string hatakodu;

            //şifre doğrulama işlemi
            if (string.IsNullOrEmpty(parola))
            {
                hatakodu = "101";
                MessageBox.Show("şifre boş bırakılamaz.HATA : " , hatakodu,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (parola.Length<8)
            {
                hatakodu = "102";
                MessageBox.Show("şifre en az sekiz karakterli olmalıdır . ",hatakodu,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (!parolaOzelKarakterIceriyrMU(parola))
            {
                hatakodu = "103";
                MessageBox.Show("şifre en az bir tane özel karakter içermelidir  : " , hatakodu,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("GİRİŞ BAŞARILI : " ,"GİRİŞ BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBox1.Clear();
        }
        //parolanın özel karakter içerip içermediğinin kontrolü
        private bool parolaOzelKarakterIceriyrMU(string parola)
        {
            string ozelKarakterleri = "!@#$½*[]}{()+-/";
            foreach  (char karakter in parola)
            {
                if (ozelKarakterleri.Contains(karakter))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
