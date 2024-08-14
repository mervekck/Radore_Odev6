using Odev_6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_6.WFA
{
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci
            {
                adi = txtAdi.Text,
                soyadi = txtSoyadi.Text,
                bolum = txtBolum.Text
            };
            if (!ZorunlulukKontrolu<Ogrenci>.Dogrula(ogr))
            {
                lblSonuc.Text = "Ogrenci bilgileri girilmesi zorunludur";
            }
            else
            {
                MessageBox.Show("Ogrenci Formu Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
