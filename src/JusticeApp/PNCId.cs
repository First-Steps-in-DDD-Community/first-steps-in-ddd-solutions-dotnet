using System;

namespace HarmelLaw.JusticeApp
{
    public class PNCId
    {
        public string Value { get; private set; }

        public PNCId(string value)
        {
            Value = value;
        }
    }
}