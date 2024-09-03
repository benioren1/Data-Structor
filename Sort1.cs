using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeekInData
{
    public class Sort1
    {
        public static int FindMin(int[] arr,int index)
        {

            int min = index;
            for (int i = index; i < arr.Length; i++)
            {

                if (arr[i] < arr[min])
                { 
                    min = i;
                }
            
            }
            return min;
        
        }

        //מיון בחירה שמשתמש גם בפונקצייה של מציאת המינימום
        public static int[] selectSort(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {

                int min = FindMin(arr, i);
                if (arr[min] < arr[i])
                {
                    int tmp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = tmp;

                }


            }
            return arr;


        }

        //מיון הכנסה 
        public static int[] InsertSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;

                while (j > 0) { 
                   
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                    j--;
                }
            }
            return arr;

        }





        

            public int[] BubelSurt(int[] arr)
        {

            bool x = true;
            while (x)
            {
                x = false;
                for (int i = 0; i < arr.Length-1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                        x = true;
                    }
                }
            }
            return arr;
        }

        //public int[] Marge(int[] arr)
        //{
        //    int[] left = arr[:arr.Length2]

        //}


    }
}
