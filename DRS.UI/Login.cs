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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
            // kullanıcı adı şifre doğru ise anasayfaya yönlendirsin
        {
            var Id = txtKullaniciAdi.Text;
            var sifre = txtSifre.Text;
            if (Id == "admin" && sifre == "1234")
                // bu durumda yeni ekran açtırma
            {
                MessageBox.Show("Hoşgeldiniz :)");
                var anaSayfaEkrani = new MainPage();
                anaSayfaEkrani.Show();
                anaSayfaEkrani.WindowState = FormWindowState.Maximized;
                this.Hide();

            }
            else if (Id != "admin")
            {
                MessageBox.Show("Kullancı Adınız Hatalı!");
            }
            else if (sifre != "1234")
            {
                MessageBox.Show("Şifreniz Hatalı");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız ve Şifreniz Hatalı");
            }
        }
    }
}
