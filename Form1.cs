using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void girisLabel_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vucutagirligi, boyuzunlugu, vucutkitleindeksi;
            vucutagirligi = Convert.ToDouble(textBox1.Text);
            boyuzunlugu = Convert.ToDouble(textBox2.Text);
            vucutkitleindeksi = vucutagirligi / (boyuzunlugu * boyuzunlugu);
            label5.Text = vucutkitleindeksi.ToString();
            if (vucutkitleindeksi < 18.5)
            { label5.Text = "Zayıf"; }
            else if (18.5 <= vucutkitleindeksi && vucutkitleindeksi < 24.9)
            { label5.Text = "Normal kilolu"; }
            else if (24.9 <= vucutkitleindeksi && vucutkitleindeksi < 29.9)
            { label5.Text = "Fazla kilolu"; }
            else if (29.9 <= vucutkitleindeksi && vucutkitleindeksi < 39.9)
            { label5.Text = "Obez"; }
            else if (39.9 <= vucutkitleindeksi)
            { label5.Text = "İleri derecede obez ( morbid obez )"; }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
