using System;
using HarmelLaw.JusticeApp.Investigation;
using Xunit;

namespace HarmelLaw.JusticeApp.Tests
{
    public class ThePublicProsecutionService
    {
        private PublicProsecutionService _thePps;
        private PNCId _pncId;
        private Suspect _suspect;
        private PoliceInvestigation _policeInvestigation;

        public ThePublicProsecutionService()
        {
            // constructor runs before each test
            Setup();
        }

        private void Setup()
        {
            _thePps = new PublicProsecutionService();
            _pncId = new PNCId("AN-ID");
            _suspect = new Suspect(CriminalOffence.CUTTING_AWAY_BUOYS_ETC);
            _policeInvestigation = new PoliceInvestigation(_pncId, _suspect);
        }

        [Fact]
        public void ShouldCreateAPreChargeDecisionWhenReceivingAPcdRequest()
        {
            PreChargeDecision pcdCase = _thePps.ReceiveRequestForPreChargeDecision(_policeInvestigation);

            Assert.Equal(_pncId, pcdCase.PNCId);
            Assert.Equal(_policeInvestigation.Suspects, pcdCase.GetSuspects());
        }

        [Fact]
        public void ShouldCreateACriminalCaseWhenAPoliceCaseFileIsAccepted()
        {
            Defendant defendant = new Defendant();
            PoliceCaseFile policeCaseFile = new PoliceCaseFile(_pncId, defendant);

            CriminalCase criminalCase = _thePps.AcceptCaseFile(policeCaseFile);

            Assert.Equal(_pncId, criminalCase.PNCId);
            Assert.Equal(policeCaseFile.Defendants, criminalCase.Defendants);
        }
    }
}