using System;
using HarmelLaw.JusticeApp.Investigation;

namespace HarmelLaw.JusticeApp
{
    public class PublicProsecutionService
    {
        public CriminalCase ReceiveRequestForPreChargeDecision(PoliceInvestigation policeInvestigation)
        {
            return new CriminalCase(policeInvestigation.PNCId, policeInvestigation.Suspects);
        }

        public CriminalCase AcceptCaseFile(PoliceCaseFile policeCaseFile)
        {
            return new CriminalCase(policeCaseFile.PNCId, policeCaseFile.Defendants);
        }
    }
}