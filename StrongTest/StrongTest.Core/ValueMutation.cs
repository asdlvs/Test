using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongTest.Core
{
    public class ValueMutation
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int AddToConstValue(int a)
        {
            const int constVal = 5;
            return a + constVal;
        }
    }
}
