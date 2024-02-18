using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace Tritium.Entities
{
    public class PatogenProgram
    {
        public virtual int Id { get; protected set; }
        public virtual required string Name { get; set; }
        public virtual required string Type { get; set; }
        public virtual required long Time { get; set; }
        public virtual bool Samostatne { get; set; }
        public virtual bool Onkovir { get; set; }
        public virtual bool Par { get; set; }
        public virtual string? MORTFRQs { get; set; }
        public virtual string? StabKompAPasm { get; set; }
        public virtual string? Okruhy { get; set; }
        public virtual string? Poznamky { get; set; }
    }
}