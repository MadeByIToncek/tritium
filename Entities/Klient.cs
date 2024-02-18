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
        public virtual string? Jmeno { get; set; }
        public virtual DateTime DatumNarozeni { get; set; }
        public virtual string? Telefon { get; set; }
        public virtual string? Email { get; set; }
        public virtual string? Adresa { get; set; }
        public virtual DateTime UvodniSchuzka { get; set; }
        public virtual IList<Navsteva> Navstevy { get; set; }
        public virtual string? Poznamka { get; set; }

        #endregion
        #region Details
        //Detailed stuff

        public virtual bool Kardiostimulator { get; set; }
        public virtual bool AktualniTehotenstvi { get; set; }
        public virtual string? OnkologickeOnemocneni { get; set; }
        public virtual bool Epilepsie { get; set; }
        public virtual string? AutoimunitniOnemocneni { get; set; }
        public virtual string? Leky { get; set; }
        public virtual string? DlouhodobePotize { get; set; }
        public virtual string? KrevniTlak { get; set; }
        public virtual string? PredchazejiciNemoci { get; set; }
        public virtual string? Homeo { get; set; }
        public virtual string? RodinnaAnamneza { get; set; }
        public virtual string? Strava { get; set; }
        public virtual string? Traveni { get; set; }
        public virtual string? SituacePrace { get; set; }
        public virtual string? SituaceRodina { get; set; }
        public virtual string? SituaceOstatni { get; set; }
        public virtual string? Rozpolozeni { get; set; }
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
