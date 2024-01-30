using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double value = 0;
        string operation = ""; // +-x/ tıklnan işareti bu değişkende tutalım
        bool operation_press = false;
        // Bütün rakamlar için buraya gelelim...
        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Rakama  tıklandı...");

            if ((txt_sonuc.Text == "0") || operation_press == true)
            {
                txt_sonuc.Clear();
            }

            operation_press = false;

            Button b = (Button)sender;  // bu aslında convert to button olmuş oldu
            //MessageBox.Show(b.Text);
            txt_sonuc.Text += b.Text;//bunlar string olduğu için birbirlerine toplamıyor atarken
        }
        // işlem sembollerine tıklanınca buraya gelinecek
        private void button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;  
            operation = b.Text;
            value = double.Parse(txt_sonuc.Text);
            operation_press = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_sonuc.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt_sonuc.Clear();
            value = 0;
        }

        private void btn_equel_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+": txt_sonuc.Text = (value + double.Parse(txt_sonuc.Text)).ToString();
                    break;

                case "-":
                    txt_sonuc.Text = (value - double.Parse(txt_sonuc.Text)).ToString();
                    break;

                case "x":
                    txt_sonuc.Text = (value * double.Parse(txt_sonuc.Text)).ToString();
                    break;

                case "/":
                    txt_sonuc.Text = (value / double.Parse(txt_sonuc.Text)).ToString();
                    break;

                default:
                    break;
            }
        }
    }
}
