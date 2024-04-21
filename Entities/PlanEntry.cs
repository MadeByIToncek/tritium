using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tritium.Entities
{
    public class PlanEntry
    {
        public virtual int Id { get; protected set; }
        public virtual required Plan Plan { get; set; }
        public virtual required PatogenProgram Program { get; set; }
        public virtual int Poradi { get; set; }
    }
}
