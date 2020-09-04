using System;
using HarmelLaw.JusticeApp.Investigation;
using HarmelLaw.JusticeApp.Preparation;

namespace HarmelLaw.JusticeApp
{
    public class PublicProsecutionService
    {
        public PreChargeDecision ReceiveRequestForPreChargeDecision(PoliceInvestigation policeInvestigation)
        {
            return new PreChargeDecision(policeInvestigation.PNCId, policeInvestigation.Suspects);
        }

        public CriminalCase AcceptCaseFile(PoliceCaseFile policeCaseFile)
        {
            return new CriminalCase(policeCaseFile.PNCId, policeCaseFile.Defendants);
        }
    }
}