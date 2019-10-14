using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCreation
{
    class NumberIsDecimalException : Exception
    {
        public NumberIsDecimalException()
        {

        }

        public NumberIsDecimalException(double num) : base(String.Format("Number is a Decimal: {0}", num))
        {
        }
    }
}
