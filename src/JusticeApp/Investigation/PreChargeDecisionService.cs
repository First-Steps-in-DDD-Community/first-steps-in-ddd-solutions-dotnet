using System;
using System.Collections.Generic;
using HarmelLaw.JusticeApp.Preparation;

namespace HarmelLaw.JusticeApp.Investigation
{
    public class PreChargeDecisionService
    {
        public PreChargeDecisionCase ReceiveRequestForPreChargeDecision(PoliceInvestigationDetails policeInvestigationDetails)
        {
            return new PreChargeDecisionCase(policeInvestigationDetails.PNCId, new HashSet<Suspect>(policeInvestigationDetails.Suspects));
        }
    }
}