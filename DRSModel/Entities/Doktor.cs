using DRSModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRSModel.Entities
{
    class Doktor : Base
    {
        public Brans DoktorunBransi { get; set; }
        public string MezunOlduguOkul { get; set; }
        public Unvan DoktorUnvani { get; set; }
    }
}
