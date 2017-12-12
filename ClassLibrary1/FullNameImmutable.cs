using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// This is an example of coding an immutable struct
    /// </summary>
    public struct FullNameImmutable
    {
        public FullNameImmutable(string f, string m, string l)
        {
            First = f;
            Middle = m;
            Last = l;
        }

        public string First { get; private set; }

        public string Middle { get; private set; }

        public string Last { get; private set; }
    }
}
