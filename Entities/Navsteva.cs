using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tritium.Entities
{
    public class Navsteva
    {
        public virtual int Id { get; protected set; }
        public virtual Klient Client { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual string AktualniPotize { get; set; }
        public virtual string CoNejviceObtezuje { get; set; }
        public virtual string CoChceVyresit { get; set; }
        public virtual string SkenOkr1 { get; set; }//db okruhu
        public virtual string SkenOkr2 { get; set; }//db okruhu

        //prirazene patogeny + frq (int, > 2 budou cervene) + hrv (int, > 3 budou cervene)
        //sort nejdrive podle typu (1pp), frq (max>min), hrv (max>min)

    }
}
