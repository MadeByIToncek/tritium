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
            References(x => x.Client)
                .Not.LazyLoad()
                .Cascade.All();
            Map(x => x.Date);
            Map(x => x.AktualniPotize)
                .Length(10000);
            Map(x => x.CoNejviceObtezuje)
                .Length(10000);
            Map(x => x.CoChceVyresit)
                .Length(10000);
            References(x => x.SkenOkr1)
                .Not.LazyLoad();
            References(x => x.SkenOkr2)
                .Not.LazyLoad();
            HasMany(x => x.Skeny)
                .Not.LazyLoad()
                .Inverse()
                .Cascade.All();
            HasMany(x => x.Plany)
                .Not.LazyLoad()
                .Inverse()
                .Cascade.All();
        }
    }
}
