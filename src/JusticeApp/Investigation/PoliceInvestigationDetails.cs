using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HarmelLaw.JusticeApp.Investigation
{
    public class PoliceInvestigationDetails
    {
        private HashSet<Suspect> _suspects = new HashSet<Suspect>();

        public PNCId PNCId { get; set; }
        public IReadOnlyCollection<Suspect> Suspects
        {
            get => _suspects;
        }

        public PoliceInvestigationDetails(PNCId aPncId, Suspect aSuspect)
        {
            if (aPncId == null) throw new ArgumentNullException("You must provide a PNC Id");
            if (aSuspect == null) throw new ArgumentNullException("You must provide a suspect");

            PNCId = aPncId;
            _suspects.Add(aSuspect);
        }
    }
}