using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRSModel.Entities
{
    public class Hasta : Base
    {
        public double Boy { get; set; }
        public double Kilo { get; set; }
        private int _yas; // yaş field'ı.

        public int Yas // PROPERTY
        {
            get { 
                var fark =DateTime.Now - this.DogumTarihi;
                _yas = fark.Days / 365;
                return _yas;
            }
            // set kısmı yok çünkü dışarıdan değer girilmemeli property'e.
            
        }

    }
}
