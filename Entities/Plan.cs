namespace Tritium.Entities
{
    public class Plan
    {
        public virtual int Id { get; protected set; }
        public virtual int Poradi { get; set; }
        public virtual bool Done { get; set; }
        public virtual bool Note { get; set; }
        public virtual string? NoteContents { get; set; }
        public virtual long? NoteDuration { get; set; }
        public virtual IList<PatogenProgram>? Programy { get; set; }

        public Plan()
        {
            Programy = [];
        }

        public virtual void PridatDavku(PatogenProgram davka)
        {
            if (Programy != null)
            {
                Programy.Add(davka);
            } else
            {
                MessageBox.Show("Unable to assign this entry, marked as note!");
            }
        }

        public virtual long ZiskatCas()
        {
            long result = 0;
            if (Programy != null)
            {
                foreach (PatogenProgram item in Programy)
                {
                    if (item != null)
                    {
                        result += item.Time;
                    }
                }
                return result;
            }
            else if (NoteDuration != null)
            {
                return (long)NoteDuration;
            }
            else
            {
                MessageBox.Show("Unable to count time for entry " + Id + ", entry seems to be in some Quantum state!");
                return -1;
            }
        }
    }
}