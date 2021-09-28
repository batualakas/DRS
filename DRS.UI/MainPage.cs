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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void hastaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Uygulamayı kapatmak istediğinizden emin misinz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void hastaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hasta kayıt ekranını açtıracak,
            // eğer mevcuttta açık bir hasta kayıt ekranı varsa ön plana getir yoksa yeni bir instance oluştur.
            // Application.OpenForms

            Form HastaKayitEkrani = null;
            foreach (Form acikOlanForm in Application.OpenForms)
            {
                if (acikOlanForm.Text == "HastaKayıtEkranı")
                {
                    HastaKayitEkrani = acikOlanForm;
                }
            }

            if (HastaKayitEkrani != null)
            {
                HastaKayitEkrani.BringToFront();
            }
            else
            {
                var hastaKayitEkrani = new HastaKayıtEkrani();
                hastaKayitEkrani.MdiParent = this; // alt ekran olduğunu belirtme.
                hastaKayitEkrani.WindowState = FormWindowState.Maximized; // tam ekran yapma.
                hastaKayitEkrani.Show(); // hasta kayıt ekranını ekrana getirtme
            }

            //acikOlanForm.BringToFront();




        }

        private void hastaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hasta listesi sayfasını açtıracak
            Form HastaListesiEkrani = null;
            foreach (Form acikOlanSayfa in Application.OpenForms)
            {
                if (acikOlanSayfa.Text == "HastaListesiEkrani")
                {
                    HastaListesiEkrani = acikOlanSayfa;
                }
            }
            if (HastaListesiEkrani != null)
            {
                HastaListesiEkrani.BringToFront();
            }
            else
            {
                var hastaListesiEkrani1 = new HastaListesiEkrani();
                hastaListesiEkrani1.MdiParent = this;
                hastaListesiEkrani1.WindowState = FormWindowState.Maximized;
                hastaListesiEkrani1.Show();

            }
        }

        private void doktorKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // doktor kayıt ekranını açtıracak
            Form DoktorKayitEkrani = null;
            foreach (Form varOlanEkran in Application.OpenForms)
            {
                if (varOlanEkran.Text == "DoktorKayitEkrani")
                {
                    DoktorKayitEkrani = varOlanEkran;
                }
            }
            if (DoktorKayitEkrani != null)
            {
                DoktorKayitEkrani.BringToFront();
            }
            else
            {
               
                        
            }

            

        }

        private void doktorListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // doktor listesini açtıracak
        }
    }
}
