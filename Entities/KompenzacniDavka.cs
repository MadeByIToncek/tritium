namespace Tritium.Entities
{
    public class KompenzacniDavka
    {
        public virtual int Id { get; protected set; }
        public virtual bool Note { get; set;}
        public virtual string? NoteContents { get; set;}
        public virtual PatogenProgram? Program { get; set; }
    }
}