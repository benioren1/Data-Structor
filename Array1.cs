using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeekInData
{
    public class Array1
    {
        //o(n)
        public static int getminimum(int[] arr)
        {
            int minimum = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minimum)
                {
                    minimum = arr[i];
                }
            }
            return minimum;

        }

        //o(n)
        public static int getsum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                sum += arr[i];
            }
            return sum;
        }

        //o(n)
        public static int[] marge(int[] arr1, int[] arr2)
        {

            int[] arr3 = new int[arr1.Length + arr2.Length];
            int left1 = 0;
            int right2 = 0;
            int index = 0;

            while (left1 < arr1.Length && right2 < arr2.Length)
            {

                if (arr1[left1] < arr2[right2])
                {

                    arr3[index] = arr1[left1];
                    index++;
                    left1++;
                }
                else
                {

                    arr3[index] = arr2[right2];
                    index++;
                    right2++;

                }

            }
            while (left1 < arr1.Length)
            {
                arr3[index] = arr1[left1];
                index++;
                left1++;

            }
            while (right2 < arr2.Length)
            {
                arr3[index] = arr2[right2];
                index++;
                right2++;

            }

            return arr3;
        }

        //o(n**2)
        public static int[] grtindexamount(int[] array)
        {
            int[] ints = new int[array.Length];

            int tmp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                foreach (int val in array)
                {
                    if (i == val)
                    {
                        tmp += 1;
                    }

                }
                ints[i] = tmp;
                tmp = 0;
            }
            return ints;

        }

        //o(n)
        public static int getnum(int[] arr)
        {

            int count = 0;
            foreach (int val in arr)
            {

                if (val % 2 != 0)
                {
                    count += 1;
                }
            }
            return count;


        }

        //o(n)
        public static int[] getTwoMaxNum(int[] arr)
        {
            if (arr.Length < 2)
            {
                return arr;
            }
            int[] ints = new int[2];
            int max = arr[0];
            int secentmax = arr[0];
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] + arr[i + 1]) > count)
                {

                    max = arr[i];
                    secentmax = arr[i + 1];
                    count = arr[i] + arr[i + 1];
                }
            }
            ints[0] = max;
            ints[1] = secentmax;
            return ints;

        }

        //o(n)
        public static bool getifaxsist(int[] arr, int num)
        {

            int count = 0;
            for (int i = 0; i < arr.Length ; i++)
            {

                if (arr[i] == num)
                {
                    count++;
                }

            }
            if (count == 0)
            {
                return false; } return true;
        }

        //o(n)
        public static int GetThreeMaxNum(int[] arr)
        {
         
            if (arr.Length < 3)
            {
                return 0;
            }
     
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            for(int i = 0;i<arr.Length;i++)
            {
                if (arr[i] > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = arr[i];
                }
                else if (arr[i] > max2)
                {
                    max3 = max2;
                    max2 = arr[i];
                }
                else if (arr[i] > max3)
                {
                    max3 = arr[i];
                }
            }
       
            return max1 + max2 + max3;
        }

        //o(n)
        public static int[] getprodact(int[] arr, int prodact)
        {
            int[] ints = new int[2];
           
            for (int i = 0; i < arr.Length-1; i++)
            {
                
            if ((arr[i] * arr[i+1])== prodact)
                {
                    ints[0] = arr[i];
                    ints[1] = arr[i+1];
                }
            }
            return ints;
        }

        //o(n)
        public static List<int>[] GetLists(int[] arr, int sum)
        {
            List<int>[] lists = new List<int>[10];
            int index = 0;
            for (int i = 0;i < arr.Length-1;i++)
            {
                if (arr[i] + arr[i+1]==sum)
                {
                    lists[index][0] = arr[i];
                    lists[index][1] = arr[i+1];
                    index++;
                }

            }
            return lists;
            
        
        }


    }
}
