using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism
{
    internal class ByteInputError : UserError
    {
        public override string UEmessage()
        {
            return "You tried to input a larger number than 255 into the byte type.This fired an error!";
        }
    }
}
