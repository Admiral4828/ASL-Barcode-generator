using ASL_Barcode;
using System;
using System.Windows.Forms;

namespace Test
{
    public partial class Barkod : Form
    {
        public Barkod()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cmbOlkeler.Items != null)
            {
                cmbOlkeler.SelectedIndex = 0;

                BarCodeGenerator Generate = new BarCodeGenerator();
                Generate.OlkeSiyahisi();

                cmbOlkeler.DataSource = BarCodeGenerator.lstOlkeler;
                cmbOlkeler.DisplayMember = "Key";
                cmbOlkeler.ValueMember = "Value";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtIstehsalciKodu.Text) && txtIstehsalciKodu.TextLength == 4)
            {
                BarCodeGenerator Generate = new BarCodeGenerator();
                Generate.BarkodHazirla_EAN13(txtOlkeKodu.Text, txtIstehsalciKodu.Text);

                txtBarKod.Text = BarCodeGenerator.Barkod;
            }
            else
            {
                MessageBox.Show("İstehsalçı kodunu doğru daxil edin");
            }
        }

        private void cmbOlkeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOlkeKodu.Text = cmbOlkeler.Text.Substring(0, 3);
        }
    }
}
