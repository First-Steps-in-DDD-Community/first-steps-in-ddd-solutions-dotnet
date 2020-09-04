using System;
using System.Collections.Generic;
using HarmelLaw.JusticeApp.Investigation;

namespace HarmelLaw.JusticeApp
{
    public class CriminalCase
    {
        public PNCId PNCId { get; set; }
        public HashSet<Suspect> Suspects { get; set; }

        public CriminalCase(PNCId pncId, HashSet<Suspect> suspects)
        {
            PNCId = pncId;
            Suspects = suspects;
        }
    }
}