using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethods41
{
    class Program
    {
        static void Main(string[] args)
        {
            mathOperations math = new mathOperations();
            string enterNum = "Enter a number: ";
            Console.WriteLine(enterNum);
            int input = Convert.ToInt32(Console.ReadLine());
            int j;

            math.numDivide(input, out j);

            Console.WriteLine(j);
            Console.ReadLine();

            string enterNewNum = "Enter a different number: ";
            Console.WriteLine(enterNewNum);

            int input2 = Convert.ToInt32(Console.ReadLine());

            // Static Class and Method
            Console.WriteLine(staticClass.doMath(input2));
            Console.ReadLine();


        }

    }
}
