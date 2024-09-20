using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Polymorfism
{
    internal class NumericInputError : UserError
    {
        public override string UEmessage()
        {
            return "You tried to use a numeric input in a text only field.This fired an error!";
        }
    }
}
