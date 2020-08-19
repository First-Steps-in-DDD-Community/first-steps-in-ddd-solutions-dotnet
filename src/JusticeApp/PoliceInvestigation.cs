using System;
using System.Collections.Generic;

namespace HarmelLaw.JusticeApp
{
    public class PoliceInvestigation
    {
        public PNCId PNCId { get; set; }
        public HashSet<Suspect> Suspects { get; set; }

        public PoliceInvestigation(PNCId pncId, Suspect suspect)
        {
            if (pncId == null) throw new ArgumentNullException("You must provide a PNC Id");
            if (suspect == null) throw new ArgumentNullException("You must provide a suspect");

            Suspects = new HashSet<Suspect>();
            
            PNCId = pncId;
            Suspects.Add(suspect);
        }
    }
}