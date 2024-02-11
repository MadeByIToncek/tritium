using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tritium.Entities;

namespace Tritium.Mappings
{
    public class MapaSkenu : ClassMap<Sken>
    {
        public MapaSkenu()
        {
            Id(x => x.Id);
            References(x => x.Patogen);
            Map(x => x.FRQ);
            Map(x => x.HRV);
        }
    }
}
