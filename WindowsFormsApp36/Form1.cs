using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
             Ogrenci.Items.Add ("Ad:" + textBox1.Text + " Soyad:" + textBox2.Text + " Yaş:" + textBox10.Text + " Şehir:" + textBox7.Text);
             Veli1.Items.Add("Ad:" + textBox3.Text + " Soyad:" + textBox5.Text + " Yaş:" + textBox11.Text + " Şehir:" + textBox8.Text);
             Veli2.Items.Add("Ad:" + textBox3.Text + " Soyad:" + textBox6.Text + " Yaş:" + textBox12.Text + " Şehir:" + textBox9.Text);

          
            MessageBox.Show("Başvuru Kaydedildi");
         }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
