using System;

namespace HarmelLaw.JusticeApp
{
    public class Suspect
    {
        private readonly CriminalOffence offence;

        public Suspect(CriminalOffence offence)
        {
            this.offence = offence;
        }
    }
}