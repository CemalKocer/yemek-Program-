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
    public partial class Form2 : Form
    {
        private object lblToplamFiyat;

        public EventHandler CheckBox_CheckedChanged { get; }

        public Form2()
        {
            InitializeComponent();

            cbHamburger.CheckedChanged += CheckBox_CheckedChanged;
            cbPizza.CheckedChanged += CheckBox_CheckedChanged;
            checkBox3.CheckedChanged += CheckBox_CheckedChanged;
            cbAdana.CheckedChanged += CheckBox_CheckedChanged;
            cbKola.CheckedChanged += CheckBox_CheckedChanged;
            cbAyran.CheckedChanged += CheckBox_CheckedChanged;
            cbKadayif.CheckedChanged += CheckBox_CheckedChanged;
            cbTantuni.CheckedChanged += CheckBox_CheckedChanged;
            cbFanta.CheckedChanged += CheckBox_CheckedChanged;
            cbDurum.CheckedChanged += CheckBox_CheckedChanged;
            cbSut.CheckedChanged += CheckBox_CheckedChanged;

            label2.Text = "150"; 
            label3.Text = "210"; 
            label4.Text = "225";
            label5.Text = "175";
            label6.Text = "120";
            label7.Text = "100";
            label8.Text = "35";
            label9.Text = "15";
            label10.Text = "75";
            label11.Text = "35";
            label12.Text = "50";
            
        }

        private void btnSprs_Click(object sender, EventArgs e)
        {
           

            bool herhangiBirUrunSecildi = this.Controls.OfType<CheckBox>().Any(cb => cb.Checked);
            if (!herhangiBirUrunSecildi)
            {
                MessageBox.Show("Lütfen Bir Ürün Seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
                this.Hide();

            }

        }



        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }





        private void lblFiyat_Click(object sender, EventArgs e)
        {

        }

 

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void toplamSiparis_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTotalPrice()
        {

            int toplamFiyat = 0; // Toplam fiyatı tutacak değişken

            // Checkbox'lara göre fiyat ekleme işlemleri
            if (cbHamburger.Checked)
            {
                toplamFiyat += int.Parse(label2.Text);
            }
            if (cbPizza.Checked)
            {
                toplamFiyat += int.Parse(label3.Text);
            }
            if (checkBox3.Checked)
            {
                toplamFiyat += int.Parse(label4.Text);
            }
            if (cbAdana.Checked)
            {
                toplamFiyat += int.Parse(label5.Text);
            }
            if (cbTantuni.Checked)
            {
                toplamFiyat += int.Parse(label6.Text);
            }
            if (cbDurum.Checked)
            {
                toplamFiyat += int.Parse(label7.Text);
            }
            if (cbKola.Checked)
            {
                toplamFiyat += int.Parse(label8.Text);
            }
            if (cbAyran.Checked)
            {
                toplamFiyat += int.Parse(label9.Text);
            }
            if (cbKadayif.Checked)
            {
                toplamFiyat += int.Parse(label10.Text);
            }
            if (cbFanta.Checked)
            {
                toplamFiyat += int.Parse(label11.Text);
            }
            if (cbSut.Checked)
            {
                toplamFiyat += int.Parse(label12.Text);
            }

            // Toplam fiyatı gösteren label'ın text'ini güncelleyin
            lblFiyat.Text = "" + toplamFiyat.ToString();
        }
    }
    }

