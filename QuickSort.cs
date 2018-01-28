using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

    public class QuickSort
    {
        public static void Main(string[] args)
        {
            // unsorted array with 13 integers in it
            int[] unsortedIntArray = { 15, 23, 2, 8, 44, 3, 55, 98, 55, 126, 7, 47, 99 };

            // pass the unsorted array into our QuickSort method along with the numbers at index[0] and at index[12]
            QuickSortMethod(unsortedIntArray, 0, unsortedIntArray.Length - 1);
        }

        //static void QuickSort(int[] a)
        //{
        //    QuickSort(a, 0, a.Length - 1);
        //}

        static void QuickSortMethod(int[] passedInUnsortedArray, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int num = passedInUnsortedArray[start];

            int i = start, j = end;

            while (i < j)
            {
                while (i < j && passedInUnsortedArray[j] > num)
                {
                    j--;
                }

                passedInUnsortedArray[i] = passedInUnsortedArray[j];

                while (i < j && passedInUnsortedArray[i] < num)
                {
                    i++;
                }

                passedInUnsortedArray[j] = passedInUnsortedArray[i];
            }

            passedInUnsortedArray[i] = num;
            QuickSortMethod(passedInUnsortedArray, start, i - 1);
            QuickSortMethod(passedInUnsortedArray, i + 1, end);
        }
    }