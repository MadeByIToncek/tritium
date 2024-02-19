using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tritium.Entities;

namespace Tritium.Mappings
{
    public class MapaOkruhu : ClassMap<Okruh>
    {
        public MapaOkruhu()
        {
            Id(x => x.Id);
            Map(x => x.Zkratka)
                .Unique();
            Map(x => x.Name);
            Map(x => x.Delka);
        }
    }
}
