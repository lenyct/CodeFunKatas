using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._7kyu
{
    public static class ShortestWord
    {
        //https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9/train/csharp

        /// <summary>
        /// Simple, given a string of words, return the length of the shortest word(s).
        /// String will never be empty and you do not need to account for different data types.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int FindShort(string s)
        {
            return s.Split(' ').OrderBy(x => x.Count()).First().Count();
        }
    }
}
