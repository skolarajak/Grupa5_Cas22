using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas22
{
    class SumCalc
    {
        static public int CalculateSum(List<int> numbers)
        {
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}
