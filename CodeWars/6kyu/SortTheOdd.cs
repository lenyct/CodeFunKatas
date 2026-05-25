using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6kyu
{
    // https://www.codewars.com/kata/578aa45ee9fd15ff4600090d
    public static class SortTheOdd
    {
        //public static int[] SortArray(int[] array)
        //{
        //    if (array == null) return null;

        //    var odds = new Queue<int>(array.Where(n => n % 2 != 0).OrderBy(n => n));
        //    var result = new int[array.Length];

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] % 2 != 0)
        //            result[i] = odds.Dequeue();
        //        else
        //            result[i] = array[i];
        //    }

        //    return result;
        //}


        public static int[] SortArray(int[] array)
        {
            if (array == null) return null;

            var odds = new Queue<int>(array.Where(n => n % 2 != 0).OrderBy(n => n));         

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    array[i] = odds.Dequeue();                
            }

            return array;
        }
    }
}
