using System;
using Xunit;
using HarmelLaw.JusticeApp.Investigation;

namespace HarmelLaw.JusticeApp.Tests.Investigation
{
    public class APoliceInvestigation
    {
        private PNCId _pncId;
        private Suspect _suspect;
        private PoliceInvestigation _anInvestigation;

        public APoliceInvestigation()
        {
            // constructor runs before each test
            Setup();
        }

        private void Setup()
        {
            _pncId = new PNCId("1234-ESDT");
            _suspect = new Suspect(CriminalOffence.FALSE_ACCOUNTING);
            _anInvestigation = new PoliceInvestigation(_pncId, _suspect);
        }

        [Fact]
        public void MustHaveAPoliceNationalComputerId()
        {
            Assert.NotNull(_anInvestigation.PNCId);
        }

        [Fact]
        public void CannotBeCreatedWithAnEmptyPoliceNationalComputerId()
        {
            Action action = () => new PoliceInvestigation(null, _suspect);
            Exception exception = Assert.Throws<ArgumentNullException>(action);

            Assert.Contains("You must provide a PNC Id", exception.Message);
        }

        [Fact]
        public void CannotBeCreatedWithNoSuspect()
        {
            Action action = () => new PoliceInvestigation(_pncId, null);
            Exception exception = Assert.Throws<ArgumentNullException>(action);
            
            Assert.Contains("You must provide a suspect", exception.Message);
        }
    }
}