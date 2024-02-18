using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tritium.Entities;

namespace Tritium.Mappings
{
    public class MapaPatogenProgramu : ClassMap<PatogenProgram>
    {
        public MapaPatogenProgramu()
        {
            Id(x => x.Id);
            Map(x => x.Name)
                .Length(10000);
            Map(x => x.Type)
                .Length(10000);
            Map(x => x.Time);
            Map(x => x.Samostatne);
            Map(x => x.Onkovir);
            Map(x => x.Par);
            Map(x => x.MORTFRQs).Length(10000);
            Map(x => x.StabKompAPasm).Length(10000);
            Map(x => x.Okruhy).Length(10000);
            Map(x => x.Poznamky).Length(10000);
            Map(x => x.Popis).Length(10000);
        }
    }
}
