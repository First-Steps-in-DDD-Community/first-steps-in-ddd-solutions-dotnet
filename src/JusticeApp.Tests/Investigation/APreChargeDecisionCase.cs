using System;
using Xunit;
using HarmelLaw.JusticeApp.Investigation;
using System.Collections.Generic;

namespace HarmelLaw.JusticeApp.Tests.Investigation
{
    public class APreChargeDecisionCase
    {
        private Suspect _suspect;
        private PreChargeDecisionCase _aPreChargeDecisionCase;
        private OffenceAdvice _offenceAdvice;
        private HashSet<Suspect> _suspects;

        public APreChargeDecisionCase()
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
            _aPreChargeDecisionCase = new PreChargeDecisionCase(pncId, _suspects);
            _offenceAdvice = new OffenceAdvice();
        }

        [Fact]
        public void ShouldRecordAlternativeOffenceAdviceAgainstSuspects()
        {
            _aPreChargeDecisionCase.RecordAlternativeOffenceAdvice(_suspect, _offenceAdvice);

            Assert.Equal(_offenceAdvice, _aPreChargeDecisionCase.GetOffenceAdviceFor(_suspect));
        }
    }
}