using System;
using System.Collections.Generic;

namespace HarmelLaw.JusticeApp.Preparation
{
    public class PoliceCaseFile
    {
        public PNCId PNCId { get; }
        public HashSet<Defendant> Defendants { get; }

        public PoliceCaseFile(PNCId pncId, Defendant defendant)
        {
            PNCId = pncId;
            Defendants = new HashSet<Defendant>();
            Defendants.Add(defendant);
        }
    }
}