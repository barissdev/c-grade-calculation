using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Quiz notu var";
            }
            else
            {
                checkBox1.Text = "Quiz notu yok";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize, final, ort;
            vize = Convert.ToInt32(textBox1.Text);
            final = Convert.ToInt32(textBox2.Text);
            int quiz = Convert.ToInt32(textBox3.Text);
            int katsayiv = Convert.ToInt32(textBox4.Text);
            int katsayif = Convert.ToInt32(textBox5.Text);
            if (checkBox1.Checked == true) //Eğer checkbox seçiliyse
            {
                ort = Convert.ToInt32(vize * katsayiv / 10 + final * katsayif / 10 + quiz/10 ); ; 
            }
            else
            {
               
                ort = Convert.ToInt32(vize * katsayiv / 10 + final * katsayif / 10);

            }
            label5.Text = ort.ToString();
            if (ort < 40 || final < 40)
                label7.Text = "Kaldınız.";

            else if (ort >= 85)
                label7.Text = "Tebrikler! AA ile geçtiniz.";
            else if (ort >= 70)
                label7.Text = "Tebrikler! BB ile geçtiniz.";
            else if (ort >= 60)
                label7.Text = "Tebrikler! CC ile geçtiniz.";
            else if (ort >= 50)
                label7.Text = "Tebrikler! DC ile geçtiniz.";
            else if (ort >= 40)
                label7.Text = " DD ile geçtiniz.";
            else
                label7.Text = "Geçtiniz.";

            // 85 >= AA, 70-85 >=BB, 60-70 CC, 50-60 DC, 40-50 DD, 0-40 FF
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
