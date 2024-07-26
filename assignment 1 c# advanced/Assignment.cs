using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1_c__advanced
{
   
    internal class Assignment
    {
        public static void OptimizedBubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false; 
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                   
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true; 
                    }
                }
                if (!swapped) break; 
            }
        }
        public class Range<T> where T : IComparable<T>
        {
            public T MinValue { get; }
            public T MaxValue { get; }

            public Range(T min, T max)
            {
                if (min.CompareTo(max) > 0)
                    Console.WriteLine ("Minimum value must be less than or equal to maximum value.");

                MinValue = min;
                MaxValue = max;
            }

            public bool IsInRange(T value)
            {
                return value.CompareTo(MinValue) >= 0 && value.CompareTo(MaxValue) <= 0;
            }

            public double Length()
            {
               
                return Convert.ToDouble(MaxValue) - Convert.ToDouble(MinValue);
            }
        }

        static void Main(string[] args) {

            #region ex 1
            //int[] array = { 64, 34, 25, 12, 22, 11, 90 };
            //OptimizedBubbleSort(array);
            //Console.WriteLine("Sorted array:");
            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
            #region ex 2
            Range<int> intRange = new Range<int>(1, 10);
            Console.WriteLine(intRange.IsInRange(5));  // Output: true
            Console.WriteLine(intRange.IsInRange(15)); // Output: false
            Console.WriteLine(intRange.Length());      // Output: 9
            #endregion


        }
    }
}
