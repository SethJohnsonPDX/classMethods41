using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethods41
{
    class mathOperations
    {
        public void numDivide(int i, out int j)
        {
            j = i / 2;
        }


        // method with output parameters
        public void outputParams(int x, out int y, out string z)
        {
            y = x * 10;
            z = "Your score with bonuses added: ";
        }

        // method overload
        public void numDivide(int i, out int j, out string k)
        {
            j = i / 4;
            k = "You were penalized.";
        }
    }
}
