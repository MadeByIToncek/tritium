namespace Tritium.Entities
{
    public class Sken
    {
        public virtual int Id { get; protected set; }
        public virtual required PatogenProgram Patogen { get; set; }
        public virtual required int FRQ { get; set; }
        public virtual required int HRV { get; set; }
    }
}