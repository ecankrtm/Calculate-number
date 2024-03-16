using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortlamaenbüyük
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi1 = double.Parse(textBox1.Text);
                double sayi2 = double.Parse(textBox2.Text);
                double sayi3 = double.Parse(textBox3.Text);

                double enBuyuk = Math.Max(sayi1, Math.Max(sayi2, sayi3));

                textBox4.Text = enBuyuk.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli sayılar girin.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi1 = double.Parse(textBox1.Text);
                double sayi2 = double.Parse(textBox2.Text);
                double sayi3 = double.Parse(textBox3.Text);

                double ortalama = (sayi1 + sayi2 + sayi3) / 3;

                textBox4.Text = ortalama.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli sayılar girin.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi1 = double.Parse(textBox1.Text);
                double sayi2 = double.Parse(textBox2.Text);
                double sayi3 = double.Parse(textBox3.Text);

                double enküçük = Math.Min(sayi1, Math.Min(sayi2, sayi3));

                textBox4.Text = enküçük.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli sayılar girin.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
