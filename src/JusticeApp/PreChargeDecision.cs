using System;
using System.Collections.Generic;

namespace HarmelLaw.JusticeApp
{
    public class PreChargeDecision
    {
        private Dictionary<Suspect, OffenceAdvice> _offenceAdvice = new Dictionary<Suspect, OffenceAdvice>();

        public void RecordAlternativeOffenceAdvice(Suspect suspect, OffenceAdvice advice)
        {
            _offenceAdvice.Add(suspect, advice);
        }

        public OffenceAdvice GetOffenceAdviceFor(Suspect suspect)
        {
            return _offenceAdvice[suspect];
        }

    }
}