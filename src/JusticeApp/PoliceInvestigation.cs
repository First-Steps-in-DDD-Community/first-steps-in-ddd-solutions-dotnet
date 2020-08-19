using System;
using System.Collections.Generic;

namespace HarmelLaw.JusticeApp
{
    public class PoliceInvestigation
    {
        public PNCId pncId;
        public HashSet<Suspect> suspects = new HashSet<Suspect>();

        public PoliceInvestigation(PNCId pncId, Suspect suspect)
        {
            if (pncId == null) throw new ArgumentNullException("You must provide a PNC Id");
            if (suspect == null) throw new ArgumentNullException("You must provide a suspect");

            this.pncId = pncId;
            this.suspects.Add(suspect);
        }
    }
}