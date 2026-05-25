using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._8Kyu
{
    //https://www.codewars.com/kata/5168bb5dfe9a00b126000018/train/csharp
    public static class ReversedStrings
    {
        public static string Solution(string str)
        {
            var a = str.ToCharArray(); Array.Reverse(a); return new string(a);
        }
    }
}
