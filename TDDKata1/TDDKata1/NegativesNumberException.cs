using System;

namespace TDDKata1
{
    public class NegativesNumberException : Exception
    {
        public NegativesNumberException()
        {
        }

        public NegativesNumberException(string message)
            : base(message)
        {
        }
    }
}