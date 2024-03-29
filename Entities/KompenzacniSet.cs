﻿namespace Tritium.Entities
{
    public class KompenzacniSet
    {
        public virtual int Id { get; protected set; }
        public virtual IList<KompenzacniDavka> KompenzacniDavky { get; set; }

        public KompenzacniSet()
        {
            KompenzacniDavky = [];
        }

        public virtual void PridatDavku(KompenzacniDavka davka)
        {
            KompenzacniDavky.Add(davka);
        }

        public virtual long ZiskatCas()
        {
            long result = 0;
            foreach (KompenzacniDavka item in KompenzacniDavky)
            {
                if (item.Program != null)
                {
                    result += item.Program.Time;
                }
            }
            return result;
        }
    }
}