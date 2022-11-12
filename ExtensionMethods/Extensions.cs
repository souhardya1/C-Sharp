using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal static class Extensions
    {
        public static void BubbleSort(this int[] arr, bool reverse = false)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            if (reverse)
            {
                Array.Reverse(arr);
            }
        }

        public static void Reverse (this int[] array)
        {
             Array.Reverse(array);
        }

    }
}
