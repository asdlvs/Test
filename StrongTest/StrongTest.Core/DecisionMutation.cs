using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongTest.Core
{
    public class DecisionMutation
    {
        public bool TestEquals()
        {
            if (5 == 5)
            {
                return true;
            }
            return false;
        }

        public bool TestNotEquals()
        {
            if (5 != 4)
            {
                return true;
            }
            return false;
        }

        public bool TestGreaterThen()
        {
            if (5 > 4)
            {
                return true;
            }
            return false;
        }

        public bool TestLessThen()
        {
            if (4 < 5)
            {
                return true;
            }
            return false;
        }

        public bool TestComplexCondition()
        {
            if (5 > 4 && !(4 >= 5))
            {
                return true;
            }
            return false;
        }
    }
}
