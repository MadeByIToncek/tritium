using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tritium.Entities;

namespace Tritium.Mappings
{
    public class MapaNavstev : ClassMap<Navsteva>
    {
        public MapaNavstev()
        {

            Id(x => x.Id);
            References(x => x.Client);
            Map(x => x.Date);
            Map(x => x.AktualniPotize)
                .Length(10000);
            Map(x => x.CoNejviceObtezuje)
                .Length(10000);
            Map(x => x.CoChceVyresit)
                .Length(10000);
            Map(x => x.SkenOkr1);
            Map(x => x.SkenOkr2);
            HasMany(x => x.Skeny)
                .Inverse()
                .Cascade.All();
            HasMany(x => x.KompenzacniSety)
                .Inverse()
                .Cascade.All();
        }
    }
}
