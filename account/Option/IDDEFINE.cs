using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using platform;

namespace account
{
    public class IDDEFINE
    {
        public static ulong _runId(uint nId) {
            return GenerateId._runId(ID, nId);
        }

        const uint ID = 1;
    }
}
