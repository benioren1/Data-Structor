using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeekInData
{
    public class Recurtion1
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
        public static bool isPalindrome(string st)
        {
            if (st.Length == 1)
            { 
            
            return true;
            }
            if (st[0] == st[st.Length - 1])
            {

                return isPalindrome(st.Substring(1, st.Length - 2));
            
            }
            return false;
        }
        public static int  decimalToBinary(int num)
        {
            if (num == 0)
            { 
            return 0;}
            if (num >=1)
            {
                Console.Write(num % 2);
            }
            
            return decimalToBinary(num/2);
        }
        //                                   0
        public static int gcd(int a, int b,int c)
        {

            if (a % (b-c) == 0 && b % (b-c) == 0)
            {
                return a - b;
            }
            else
            {
                return gcd(a, b, c +1);
            }
        
        }

        static void evenNumbers(int n, int current)
        {
            if (current >= n)
            {
                return;
            }

            if (current % 2 == 0)
            {
                Console.WriteLine(current);
            }

            evenNumbers(n, current + 1);
        }

        static int findMax(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                return array[index];
            }

            int max = findMax(array, index + 1);
            return Math.Max(array[index], max);
        }
        //                                               0         0
        static int subtracEvenOddHelper(int number, int even, int odd)
        {
            if (number == 0)
            {
                return even - odd;
            }

            int digit = number % 10;
            int remainder = number / 10;

            if (digit % 2 == 0)
            {
                even += digit;
            }
            else
            {
                odd += digit;
            }

            return subtracEvenOddHelper(remainder, even, odd);
        }












    }
}
