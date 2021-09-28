using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRS.UI.Helpers
{
    public static class FormHelpers
    {
        public static void FormTemizle(Form temizlenecekForm)
        {
            foreach (var control in temizlenecekForm.Controls)
            {
                if (control is TextBox)
                {
                    var txt = (TextBox)control;
                    txt.Clear();
                }
                if (control is ComboBox)
                {
                    var cmb = (ComboBox)control;
                    cmb.SelectedIndex = -1;
                }
                
            }
        }

    }
}
