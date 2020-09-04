using System;
using System.Collections.Generic;

namespace HarmelLaw.JusticeApp.Investigation
{
    public class PreChargeDecisionCase
    {
        private Dictionary<Suspect, OffenceAdvice> _offenceAdvice = new Dictionary<Suspect, OffenceAdvice>();

        public PNCId PNCId { get; }

        public PreChargeDecisionCase(PNCId pncId, HashSet<Suspect> suspects)
        {
            PNCId = pncId;
            foreach (Suspect s in suspects)
            {
                _offenceAdvice.Add(s, null);
            }
        }

        public void RecordAlternativeOffenceAdvice(Suspect suspect, OffenceAdvice advice)
        {
            _offenceAdvice[suspect] = advice;
        }

        public OffenceAdvice GetOffenceAdviceFor(Suspect suspect)
        {
            return _offenceAdvice[suspect];
        }

        public HashSet<Suspect> GetSuspects()
        {
            return new HashSet<Suspect>(_offenceAdvice.Keys);
        }
    }
}