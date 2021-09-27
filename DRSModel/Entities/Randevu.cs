using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRSModel.Entities
{
    class Randevu : Base
    {
        public Hasta RandevuAlanHasta { get; set; }
        public Doktor RandevuAlinanDoktor { get; set; }
        public DateTime RandevuTarihi { get; set; }
    }
}
