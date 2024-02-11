using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tritium.Entities;

namespace Tritium.Mappings
{
    public class MapaKompenzacnichDavek :ClassMap<KompenzacniDavka>
    {
        public MapaKompenzacnichDavek() {
            Id(x => x.Id);
            Map(x => x.Note);
            Map(x => x.NoteContents)
                .Length(10000);
            HasOne(x => x.Program)
                .Cascade.All();
        }
    }
}
