using System;
using HarmelLaw.JusticeApp.Investigation;
using HarmelLaw.JusticeApp.Preparation;
using Xunit;

namespace HarmelLaw.JusticeApp.Tests.Investigation
{
    public class TheTrialPreparationService
    {
        private TrialPreparationService _thePps;
        private PNCId _pncId;
        private Suspect _suspect;
        private PoliceInvestigationDetails _policeInvestigationDetails;

        public TheTrialPreparationService()
        {
            // constructor runs before each test
            Setup();
        }

        private void Setup()
        {
            _thePps = new TrialPreparationService();
            _pncId = new PNCId("AN-ID");
            _suspect = new Suspect(CriminalOffence.CUTTING_AWAY_BUOYS_ETC);
            _policeInvestigationDetails = new PoliceInvestigationDetails(_pncId, _suspect);
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