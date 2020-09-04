using System;
using System.Collections.Generic;
using HarmelLaw.JusticeApp.Investigation;
using HarmelLaw.JusticeApp.Preparation;

namespace HarmelLaw.JusticeApp
{
    public class PublicProsecutionService
    {
        public PreChargeDecisionCase ReceiveRequestForPreChargeDecision(PoliceInvestigationDetails policeInvestigationDetails)
        {
            return new PreChargeDecisionCase(policeInvestigationDetails.PNCId, new HashSet<Suspect>(policeInvestigationDetails.Suspects));
        }

        public CriminalCase AcceptCaseFile(PoliceCaseFile policeCaseFile)
        {
            return new CriminalCase(policeCaseFile.PNCId, policeCaseFile.Defendants);
        }
    }
}