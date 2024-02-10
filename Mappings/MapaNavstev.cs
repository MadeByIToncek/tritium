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
        }
    }
}
