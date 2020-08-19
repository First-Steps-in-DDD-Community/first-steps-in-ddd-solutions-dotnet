using System;
using Xunit;

namespace HarmelLaw.JusticeApp.Tests
{
    public class APoliceInvestigation
    {
        PNCId pncId;
        Suspect suspect;
        PoliceInvestigation anInvestigation;

        public APoliceInvestigation()
        {
            // constructor runs before each test
            setup();
        }

        private void setup()
        {
            pncId = new PNCId("1234-ESDT");
            suspect = new Suspect(CriminalOffence.FALSE_ACCOUNTING);
            anInvestigation = new PoliceInvestigation(pncId, suspect);
        }

        [Fact]
        public void mustHaveAPoliceNationalComputerId()
        {
            Assert.NotNull(anInvestigation.pncId);
        }

        [Fact]
        public void cannotBeCreatedWithAnEmptyPoliceNationalComputerId()
        {
            Action action = () => new PoliceInvestigation(null, suspect);
            Exception exception = Assert.Throws<ArgumentNullException>(action);

            Assert.Contains("You must provide a PNC Id", exception.Message);
        }

        [Fact]
        public void cannotBeCreatedWithNoSuspect()
        {
            Action action = () => new PoliceInvestigation(pncId, null);
            Exception exception = Assert.Throws<ArgumentNullException>(action);
            
            Assert.Contains("You must provide a suspect", exception.Message);
        }
    }
}