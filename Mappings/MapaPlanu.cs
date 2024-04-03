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
            Map(x => x.Poradi);
            Map(x => x.Note);
            Map(x => x.NoteContents)
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
