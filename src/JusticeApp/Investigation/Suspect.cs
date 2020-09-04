using System;

namespace HarmelLaw.JusticeApp.Investigation
{
    public class Suspect
    {
        private readonly CriminalOffence _offence;

        public Suspect(CriminalOffence offence)
        {
            _offence = offence;
        }
    }
}