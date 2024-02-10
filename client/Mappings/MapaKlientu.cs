using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tritium.Entities;

namespace Tritium.Mappings
{
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
}
