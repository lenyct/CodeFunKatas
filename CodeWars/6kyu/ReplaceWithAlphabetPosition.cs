using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._6kyu
{
    public static class ReplaceWithAlphabetPosition
    {

        private static Dictionary<char, int> Alphabet = new Dictionary<char, int>()
        {
            {'a', 1},
            {'b', 2},
            {'c', 3},
            {'d', 4},
            {'e', 5},
            {'f', 6},
            {'g', 7},
            {'h', 8},
            {'i', 9},
            {'j', 10},
            {'k', 11},
            {'l', 12},
            {'m', 13},
            {'n', 14},
            {'o', 15},
            {'p', 16},
            {'q', 17},
            {'r', 18},
            {'s', 19},
            {'t', 20},
            {'u', 21},
            {'v', 22},
            {'w', 23},
            {'x', 24},
            {'y', 25},
            {'z', 26},
        };


        public static string AlphabetPosition(string text)
        {            
            StringBuilder sb = new StringBuilder();
            foreach (var c in text.ToLower())
            {
                if(char.IsAsciiLetter(c))
                {
                    sb.Append(Alphabet[c].ToString() + ' ');
                }
            }
            return sb.ToString();

           // return string.Join(" ", text.ToLowerInvariant().Where(char.IsLetter).Select(c => (c - 'a' + 1).ToString()));
        }
    }
}
