using FluentNHibernate.Mapping;

namespace Tritium
{
    public class Klient
    {
        #region Important
        public virtual int Id { get; protected set; }
        public virtual string Jmeno { get; set; }
        public DateTime DatumNarozeni { get; set; }
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


        public virtual void PridatNavstevu(Navsteva navsteva)
        {
            Navstevy.Add(navsteva);
        }
    }


    public class MapaKlientu : ClassMap<Klient>
    {
        public MapaKlientu()
        {
            Id(x => x.Id);
            Map(x => x.Jmeno);
            Map(x => x.DatumNarozeni);
            Map(x => x.Telefon);
            Map(x => x.Email);
            Map(x => x.Adresa);
            Map(x => x.UvodniSchuzka);
            HasMany(x => x.Navstevy)
                .Inverse()
                .Cascade.All();
            Map(x => x.Kardiostimulator);
            Map(x => x.AktualniTehotenstvi);
            Map(x => x.OnkologickeOnemocneni);
            Map(x => x.Epilepsie);
            Map(x => x.AutoimunitniOnemocneni);
            Map(x => x.Leky);
            Map(x => x.DlouhodobePotize);
            Map(x => x.KrevniTlak);
            Map(x => x.PredchazejiciNemoci);
            Map(x => x.Homeo);
            Map(x => x.RodinnaAnamneza);
            Map(x => x.Strava);
            Map(x => x.Traveni);
            Map(x => x.SituacePrace);
            Map(x => x.SituaceRodina);
            Map(x => x.SituaceOstatni);
            Map(x => x.Rozpolozeni);
        }
    }

    public class Navsteva
    {
        public virtual int Id { get; protected set; }
        public virtual Klient Client { get; set; }
        public virtual DateTime Date { get; set; }
    }
    public class MapaNavstev : ClassMap<Navsteva>
    {
        public MapaNavstev() {

            Id(x => x.Id);
            References(x => x.Client);
            Map(x => x.Date);
        }
    }
}
