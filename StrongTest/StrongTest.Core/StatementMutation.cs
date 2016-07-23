using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongTest.Core
{
    public class StatementMutation
    {
        public int TestStatement1()
        {
            int x = 100;
            int value = x + 20;
            x += 50;

            return value;
        }
    }
}
