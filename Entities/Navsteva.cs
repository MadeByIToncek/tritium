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
        public virtual required Klient Client { get; set; }
        public virtual required DateTime Date { get; set; }
        public virtual required string AktualniPotize { get; set; }
        public virtual required string CoNejviceObtezuje { get; set; }
        public virtual required string CoChceVyresit { get; set; }
        public virtual required Okruh SkenOkr1 { get; set; }//db okruhu
        public virtual required Okruh SkenOkr2 { get; set; }//db okruhu
        public virtual IList<Sken> Skeny { get; set; }
        public virtual IList<KompenzacniSet> KompenzacniSety { get; set; }

        public Navsteva()
        {
            Skeny = [];
            KompenzacniSety = [];
        }

        public virtual void PridatSken(Sken sken)
        {
            Skeny.Add(sken);
        }

        public virtual void PridatKompenzacniDavku(KompenzacniSet SetDavek)
        {
            KompenzacniSety.Add(SetDavek);
        }
        //prirazene patogeny + frq (int, > 2 budou cervene) + hrv (int, > 3 budou cervene)
        //sort nejdrive podle typu (1pp), frq (max>min), hrv (max>min)

    }
}
