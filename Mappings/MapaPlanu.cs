using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tritium.Entities;

namespace Tritium.Mappings
{
    public class MapaPlanu : ClassMap<Plan>
    {
        public MapaPlanu()
        {
            Id(x => x.Id);
            References(x => x.Navsteva)
                .Cascade.All(); 
            Map(x => x.Poradi);
            Map(x => x.Done);
            Map(x => x.Note);
            Map(x => x.NoteContents)
                .Length(10000)
                .Nullable();
            Map(x => x.NoteDuration)
                .Nullable();
            HasMany(x => x.Programy)
                .Not.LazyLoad()
                .Inverse()
                .Cascade.All();
        }
    }
}
