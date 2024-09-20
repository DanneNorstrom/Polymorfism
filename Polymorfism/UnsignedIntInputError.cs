using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism
{
    internal class UnsignedIntInputError : UserError
    {
        public override string UEmessage()
        {
            return "You tried to input a negative value into the uint type.This fired an error!";
        }
    }
}
