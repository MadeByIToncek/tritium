using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tritium.Entities;

namespace Tritium.Mappings
{
    public class MapOfPlanEntries : ClassMap<PlanEntry>
    {
        public MapOfPlanEntries()
        {
            Id(x => x.Id);
            References(x => x.Plan)
                .Not.LazyLoad()
                .Cascade.All();
            References(x => x.Program)
                .Not.LazyLoad()
                .Cascade.All();
            Map(x => x.Poradi);
        }
    }
}
