using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeekInData
{
    public class Recurtion
    {

        public static int multiply(int a, int b)
        {
            if (b == 1)
            {
                return a;
            }
            return a + multiply(a, b - 1);

        }

        public static int sumOfDigits(int num)
        {
            if (num < 10)
            { return num; }
            return num % 10 + sumOfDigits(num / 10);

        }

        public static int power(int a, int b)
        {

            if (b == 1)
            {
                return a;
            }

            return a * power(a, b - 1);
        }

        public static int reversed(int num)
        {

            if (num <= 0)
            {
                return num;
            }
            Console.Write(num % 10);
            return reversed(num / 10);

        }

        public static int findSum(int[] arr, int num)
        { 
            if(num <= 0)
                { return num; }
            return arr[num-1]+ findSum(arr, num-1);
        
        }

        public static int divide(int a, int b)
        {
            if (a<b )
            {
                return 0;
            }
            return 1 + divide(a-b, b );

        }









    }
}
