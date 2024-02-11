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
            Map(x => x.OnkologickeOnemocneni)
                .Length(10000);
            Map(x => x.Epilepsie);
            Map(x => x.AutoimunitniOnemocneni)
                .Length(10000);
            Map(x => x.Leky)
                .Length(10000);
            Map(x => x.DlouhodobePotize)
                .Length(10000);
            Map(x => x.KrevniTlak).Length(10000);
            Map(x => x.PredchazejiciNemoci).Length(10000);
            Map(x => x.Homeo).Length(10000);
            Map(x => x.RodinnaAnamneza).Length(10000);
            Map(x => x.Strava).Length(10000);
            Map(x => x.Traveni).Length(10000);
            Map(x => x.SituacePrace).Length(10000);
            Map(x => x.SituaceRodina).Length(10000);
            Map(x => x.SituaceOstatni).Length(10000);
            Map(x => x.Rozpolozeni).Length(10000);
        }
    }
}
