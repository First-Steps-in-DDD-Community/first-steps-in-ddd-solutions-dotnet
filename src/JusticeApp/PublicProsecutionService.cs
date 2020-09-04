using System;
using HarmelLaw.JusticeApp.Investigation;
using HarmelLaw.JusticeApp.Preparation;

namespace HarmelLaw.JusticeApp
{
    public class PublicProsecutionService
    {
        public PreChargeDecisionCase ReceiveRequestForPreChargeDecision(PoliceInvestigation policeInvestigation)
        {
            return new PreChargeDecisionCase(policeInvestigation.PNCId, policeInvestigation.Suspects);
        }

        public CriminalCase AcceptCaseFile(PoliceCaseFile policeCaseFile)
        {
            return new CriminalCase(policeCaseFile.PNCId, policeCaseFile.Defendants);
        }
    }
}