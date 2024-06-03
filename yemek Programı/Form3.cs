using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yemek_Programı
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
               string.IsNullOrWhiteSpace(textBox6.Text)) 
            {
                MessageBox.Show("Lütfen tüm alanları doldur", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);           
            }
            else
            {
                MessageBox.Show("Siparişiniz başarılı şekilde alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                    
               
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
            textBox5.MaxLength = 11;
        }
    }
}
