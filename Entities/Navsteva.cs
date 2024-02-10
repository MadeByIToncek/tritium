using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tritium.Entities
{
    public class Navsteva
    {
        public virtual int Id { get; protected set; }
        public virtual Klient Client { get; set; }
        public virtual DateTime Date { get; set; }
    }
}
