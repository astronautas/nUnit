using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nUnitProject
{
    public class LowerThanAbsoluteZeroException : Exception
    {
        public LowerThanAbsoluteZeroException() { }

        public LowerThanAbsoluteZeroException(string msg) : base(msg) { }

        public LowerThanAbsoluteZeroException(string msg, Exception inner)
            : base(msg, inner) { }
    }
}
