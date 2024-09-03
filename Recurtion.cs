using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeekInData
{
    public  class Recurtion
    {

        public static int multiply(int a, int b)
        {
            if (b == 1)
            {
                return a;
            }
            return a + multiply(a, b-1);
        
        }
        public static int sumOfDigits(int num)
        {
            if (num < 10)
            {  return num; }
            return num % 10 + sumOfDigits(num/10);

        }
        




    }
}
