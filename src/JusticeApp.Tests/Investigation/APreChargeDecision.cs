using System;
using Xunit;
using HarmelLaw.JusticeApp.Investigation;
using System.Collections.Generic;

namespace HarmelLaw.JusticeApp.Tests.Investigation
{
    public class APreChargeDecision
    {
        private Suspect _suspect;
        private PreChargeDecision _aPreChargeDecision;
        private OffenceAdvice _offenceAdvice;
        private HashSet<Suspect> _suspects;

        public APreChargeDecision()
        {
            // constructor runs before each test
            Setup();
        }

        private void Setup()
        {
            PNCId pncId = new PNCId("ANOTHER_PNC_ID");
            _suspect = new Suspect(CriminalOffence.CUTTING_AWAY_BUOYS_ETC);
            _suspects = new HashSet<Suspect>();
            _suspects.Add(_suspect);
            _aPreChargeDecision = new PreChargeDecision(pncId, _suspects);
            _offenceAdvice = new OffenceAdvice();
        }

        [Fact]
        public void ShouldRecordAlternativeOffenceAdviceAgainstSuspects()
        {
            _aPreChargeDecision.RecordAlternativeOffenceAdvice(_suspect, _offenceAdvice);

            Assert.Equal(_offenceAdvice, _aPreChargeDecision.GetOffenceAdviceFor(_suspect));
        }
    }
}