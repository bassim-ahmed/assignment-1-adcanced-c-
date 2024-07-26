using assignment_1_adcanced_c_.Generics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = assignment_1_adcanced_c_.Generics.Point;

namespace assignment_1_adcanced_c_
{
    //T->Generic type
    //swap ->Generic Method
    //In case Generic type <T>is decleard ON method Level ,NOT Class or struct or Interface
    //Copiler can Not detect the type of T Based on passed Parameter
    internal class Helper<T> where T : IComparable
    {

        #region non generics
        //public static void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void Swap(ref double x, ref double y)
        //{
        //    double temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void Swap(ref Point x, ref Point y)
        //{
        //    Point temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static int SearchArray(int[] Array, int value)
        //{
        //    if (Array is not null)
        //    {
        //        for (int i = 0; i < Array.Length; i++)
        //        {
        //            if (value == Array[i])
        //            {
        //                return i;
        //            }
        //        }


        //    }
        //    return -1;
        //}
        #endregion
        #region Generics
        //T->Generic type
        //swap ->Generic Method
        //In case Generic type <T>is decleard ON method Level ,NOT Class or struct or Interface
        //Copiler can detect the type of T Based on passed Parameter
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        public static int SearchArray<T>(T[] Array, T value)
        {
            if (Array is not null)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    if (value.Equals(Array[i]) )
                    {
                        return i;
                    }
                }


            }
            return -1;
        }
        #endregion
        public static void BubbleSort(T[] arr)
        {
            for (int i = 0; i < arr?.Length; i++)
                for (int j = 0; j < arr.Length - i - 1; i++)
                    if (arr[j].CompareTo(arr[j + 1]) == 1)  //must be used from interface Icomparable
                        Swap(ref arr[j], ref arr[j + 1]);
        }

    }
}
