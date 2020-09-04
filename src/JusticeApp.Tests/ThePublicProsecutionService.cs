using System;
using Xunit;

namespace HarmelLaw.JusticeApp.Tests
{
    public class ThePublicProsecutionService
    {
        private PublicProsecutionService _thePps;

        public ThePublicProsecutionService()
        {
            // constructor runs before each test
            Setup();
        }

        private void Setup()
        {
            _thePps = new PublicProsecutionService();
        }

        [Fact]
        public void ShouldCreateACaseWhenReceivingAPcdRequest()
        {
            PNCId pncId = new PNCId("AN-ID");
            Suspect suspect = new Suspect(CriminalOffence.CUTTING_AWAY_BUOYS_ETC);
            PoliceInvestigation policeInvestigation = new PoliceInvestigation(pncId, suspect);

            CriminalCase policeCase = _thePps.ReceiveRequestForPreChargeDecision(policeInvestigation);

            Assert.Equal(pncId, policeCase.PNCId);
            Assert.Equal(policeInvestigation.Suspects, policeCase.Suspects);
        }
    }
}