using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Extensions
{
    public static class ExtensionMethods
    {
        public static int PlusFive(this int input)
        {
            return input + 5;
        }
    }
}
