using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRS.UI
{
    public partial class HastaKayıtEkranı : Form
    {
        public HastaKayıtEkranı()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void HastaKayıtEkranı_Load(object sender, EventArgs e)
        {
            mttxtTelefon.Mask = "\\+\\9\\0\\(000\\)000 00 00";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
