namespace Tritium.Entities
{
    public class Sken
    {
        public virtual int Id { get; protected set; }
        public virtual PatogenProgram Patogen { get; set; }
        public virtual int FRQ { get; set; }
        public virtual int HRV { get; set; }
    }
}