using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsCustom
{
    public class InvalidBeerException : Exception
    {
        public InvalidBeerException() : base("Invalid Beer creation: Beer doesnt has name or brand"){ }
    }
}
