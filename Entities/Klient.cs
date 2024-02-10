using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tritium.Entities
{
    public class Klient
    {
        #region Important
        public virtual int Id { get; protected set; }
        public virtual string Jmeno { get; set; }
        public virtual DateTime DatumNarozeni { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Email { get; set; }
        public virtual string Adresa { get; set; }
        public virtual DateTime UvodniSchuzka { get; set; }
        public virtual IList<Navsteva> Navstevy { get; set; }

        #endregion
        #region Details
        //Detailed stuff

        public virtual bool Kardiostimulator { get; set; }
        public virtual bool AktualniTehotenstvi { get; set; }
        public virtual bool OnkologickeOnemocneni { get; set; }
        public virtual bool Epilepsie { get; set; }
        public virtual bool AutoimunitniOnemocneni { get; set; }
        public virtual bool Leky { get; set; }
        public virtual bool DlouhodobePotize { get; set; }
        public virtual bool KrevniTlak { get; set; }
        public virtual bool PredchazejiciNemoci { get; set; }
        public virtual bool Homeo { get; set; }
        public virtual bool RodinnaAnamneza { get; set; }
        public virtual bool Strava { get; set; }
        public virtual bool Traveni { get; set; }
        public virtual bool SituacePrace { get; set; }
        public virtual bool SituaceRodina { get; set; }
        public virtual bool SituaceOstatni { get; set; }
        public virtual bool Rozpolozeni { get; set; }
        #endregion

        public Klient()
        {
            Navstevy = new List<Navsteva>();
        }

        public virtual void PridatNavstevu(Navsteva navsteva)
        {
            Navstevy.Add(navsteva);
        }
    }

}
