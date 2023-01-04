using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _120822_TC_NO_DOGRULAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//tüm tc no'ların sonu çift hanedir.

            if (maskedTextBox1.MaskFull)
            {
            string sonHane = maskedTextBox1.Text[10].ToString();

            int SonHaneNum=Convert.ToInt32(sonHane);

            if(SonHaneNum % 2 != 0)
            {
                MessageBox.Show("TCKN Hatalıdır.");

            }
            else
            {
                int toplam = 0;
                for (int i = 0; i < maskedTextBox1.Text.Length-1; i++)

                {
                    string rkm=maskedTextBox1.Text[i].ToString();
                    toplam+= Convert.ToInt32(rkm);
                }
                if(toplam % 10== SonHaneNum)
                {
                    MessageBox.Show("TCKN Doğrudur.");
                }
                else
                {
                    MessageBox.Show("TCKN Hatalıdır.");
                }
            }
           
            }
            else
            {
                MessageBox.Show("Lütfen 11 Haneli Bir TCKN Giriniz.");
            }
          
        }
    }
}
