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
    public partial class ArabaForm : Form
    {
        public ArabaForm()
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
            Araba araba = new Araba
            {
                marka = txtMarka.Text,
                model = txtModel.Text
            };
            if (!ZorunlulukKontrolu<Araba>.Dogrula(araba))
            {
                lblSonuc.Text = "Araba bilgileri girilmesi zorunludur";
            }
            else
            {
                MessageBox.Show("Araba Formu Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
