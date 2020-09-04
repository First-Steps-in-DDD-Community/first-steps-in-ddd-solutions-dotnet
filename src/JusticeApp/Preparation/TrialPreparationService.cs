using System;
using System.Collections.Generic;
using HarmelLaw.JusticeApp.Investigation;

namespace HarmelLaw.JusticeApp.Preparation
{
    public class TrialPreparationService
    {
        public CriminalCase AcceptCaseFile(PoliceCaseFile policeCaseFile)
        {
            return new CriminalCase(policeCaseFile.PNCId, policeCaseFile.Defendants);
        }
    }
}