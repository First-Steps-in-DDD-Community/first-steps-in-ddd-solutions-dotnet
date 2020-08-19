using System;
using Xunit;

namespace HarmelLaw.JusticeApp.Tests
{
    public class APreChargeDecision
    {
        public APreChargeDecision()
        {
            // constructor runs before each test
            setup();
        }

        private void setup()
        {
        }

        [Fact(Skip = "So the CI build stays green.  Remove this to get coding.")]
        public void shouldRecordAlternativeOffenceAdviceAgainstSuspects()
        {
            Assert.True(false);
        }
    }
}