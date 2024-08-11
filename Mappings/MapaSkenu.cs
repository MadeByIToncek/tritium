using FluentNHibernate.Mapping;
using Tritium.Entities;

namespace Tritium.Mappings
{
    public class MapaSkenu : ClassMap<Sken>
    {
        public MapaSkenu()
        {
            Id(x => x.Id);
            References(x => x.Navsteva)
                .Not.LazyLoad();
            References(x => x.Patogen)
                .Not.LazyLoad();
            References(x => x.Okruh)
                .Not.LazyLoad();
            Map(x => x.FRQ);
            Map(x => x.HRV);
        }
    }
}
