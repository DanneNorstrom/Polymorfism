using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism
{
    internal class IntegerInputError : UserError
    {
        public override string UEmessage()
        {
            return "You tried to input a larger number than 2147483647 into the int type.This fired an error!";
        }
    }
}
