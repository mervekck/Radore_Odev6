namespace Odev_6.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cmbSec.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "��renci Kay�t":
                    OgrenciForm ogr = new OgrenciForm();
                    ogr.Show();                    
                    break;
                case "Araba Kay�t":
                    ArabaForm araba = new ArabaForm();
                    araba.Show();                    
                    break;
            }
            this.Hide();

        }
    }
}
