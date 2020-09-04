using System;
using System.Collections.Generic;

namespace HarmelLaw.JusticeApp
{
    public class PoliceCaseFile
    {
        public PNCId PNCId { get; set; }
        public HashSet<Defendant> Defendants { get; set; }

        public PoliceCaseFile(PNCId pncId, Defendant defendant)
        {
            PNCId = pncId;
            Defendants = new HashSet<Defendant>();
            Defendants.Add(defendant);
        }
    }
}