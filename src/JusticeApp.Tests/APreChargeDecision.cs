using System;
using Xunit;

namespace HarmelLaw.JusticeApp.Tests
{
    public class APreChargeDecision
    {
        public APreChargeDecision()
        {
            // constructor runs before each test
            Setup();
        }

        private void Setup()
        {
        }

        [Fact]
        public void ShouldRecordAlternativeOffenceAdviceAgainstSuspects()
        {
            Suspect suspect = new Suspect(CriminalOffence.CUTTING_AWAY_BUOYS_ETC);
            PreChargeDecision aPreChargeDecision = new PreChargeDecision();
            OffenceAdvice offenceAdvice = new OffenceAdvice();

            aPreChargeDecision.RecordAlternativeOffenceAdvice(suspect, offenceAdvice);

            Assert.Equal(offenceAdvice, aPreChargeDecision.GetOffenceAdviceFor(suspect));
        }
    }
}