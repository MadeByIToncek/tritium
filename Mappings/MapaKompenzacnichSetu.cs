using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tritium.Entities;

namespace Tritium.Mappings
{
    public class MapaKompenzacnichSetu : ClassMap<KompenzacniSet>
    {
        public MapaKompenzacnichSetu()
        {
            Id(x => x.Id);
            HasMany(x => x.KompenzacniDavky)
                .Not.LazyLoad()
                .Inverse()
                .Cascade.All();
        }
    }
}
