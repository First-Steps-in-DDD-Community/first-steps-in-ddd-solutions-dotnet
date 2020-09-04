using System;
using HarmelLaw.JusticeApp.Investigation;
using HarmelLaw.JusticeApp.Preparation;
using Xunit;

namespace HarmelLaw.JusticeApp.Tests.Investigation
{
    public class ThePreChargeDecisionService
    {
        private PreChargeDecisionService _thePrechargeDecisionService;
        private PNCId _pncId;
        private Suspect _suspect;
        private PoliceInvestigationDetails _policeInvestigationDetails;

        public ThePreChargeDecisionService()
        {
            // constructor runs before each test
            Setup();
        }

        private void Setup()
        {
            _thePrechargeDecisionService = new PreChargeDecisionService();
            _pncId = new PNCId("AN-ID");
            _suspect = new Suspect(CriminalOffence.CUTTING_AWAY_BUOYS_ETC);
            _policeInvestigationDetails = new PoliceInvestigationDetails(_pncId, _suspect);
        }

        [Fact]
        public void ShouldCreateAPreChargeDecisionWhenReceivingAPcdRequest()
        {
            PreChargeDecisionCase pcdCase = _thePrechargeDecisionService.ReceiveRequestForPreChargeDecision(_policeInvestigationDetails);

            Assert.Equal(_pncId, pcdCase.PNCId);
            Assert.Equal(_policeInvestigationDetails.Suspects, pcdCase.GetSuspects());
        }
    }
}