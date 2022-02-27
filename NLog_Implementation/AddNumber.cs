using System;
using System.Collections.Generic;
using System.Text;

namespace NlogImplimentation
{
    class AddNumber
    {
        NlogC nlog = new NlogC();
        public int Sum(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                nlog.LogDebug("Debug Successfull : sum()");
                nlog.LogError("Expecting null values");
                nlog.LogWarn("a or b should not equal to 0");
            }
            int c = a + b;
            nlog.LogDebug("Debug Successfull");
            return c;
        }

    }
}
