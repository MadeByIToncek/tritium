namespace Tritium.Entities
{
    public class Okruh
    {
        public virtual int Id { get; protected set; }
        public virtual required string Zkratka { get; set;}
        public virtual required string Name { get; set;}
        public virtual int Delka { get; set;}
    }
}
