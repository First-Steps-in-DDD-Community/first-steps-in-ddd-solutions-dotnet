using System;
using Xunit;
using HarmelLaw.JusticeApp.Investigation;

namespace HarmelLaw.JusticeApp.Tests.Investigation
{
    public class APreChargeDecision
    {
        private Suspect _suspect;
        private PreChargeDecision _aPreChargeDecision;
        private OffenceAdvice _offenceAdvice;

        public APreChargeDecision()
        {
            // constructor runs before each test
            Setup();
        }

        private void Setup()
        {
            _suspect = new Suspect(CriminalOffence.CUTTING_AWAY_BUOYS_ETC);
            _aPreChargeDecision = new PreChargeDecision();
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