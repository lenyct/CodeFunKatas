using System.Text;

namespace CodeWars._6kyu
{
    public class ReversingAProcess
    {
        //https://www.codewars.com/kata/5dad6e5264e25a001918a1fc/train/csharp
        public static string Decode(string r)
        {
            //the legend of alphabet
            Dictionary<char, int> alphabetEncode = "abcdefghijklmnopqrstuvwxyz"
               .Select((c, i) => new { c, i })
               .ToDictionary(x => x.c, x => x.i);

            Dictionary<int, char> alphabetDecode = "abcdefghijklmnopqrstuvwxyz"
                .Select((c, i) => new { c, i })
                .ToDictionary(x => x.i, x => x.c);

            //retrieve the ints from the string
            int multiplier = int.Parse(r.Where(char.IsDigit).ToArray());

            if(GCD(multiplier, 26) != 1)
                return "Impossible to decode";


            var encoded = r.Where(char.IsLetter).ToArray();

            //Simplified coefficient modulo m
            int simplifiedCoefficient = multiplier % 26;
            var sb = new StringBuilder();

            foreach (var c in encoded)
            {
              //  var encodedChar = alphabet[SolveCongruence(simplifiedCoefficient, alphabet[c], 26)];
              sb.Append(alphabetDecode[SolveCongruence(simplifiedCoefficient, alphabetEncode[c], 26)]);
            }
            return sb.ToString();
        }

        public static int GCD(int a, int b)
        {
            if (b == 0)
                return Math.Abs(a);
            return GCD(b, a % b);
        }

        public static int ModInverse(int a, int m)
        {
            int m0 = m;
            int y = 0, x = 1;

            if (m == 1)
                return 0;

            while (a > 1)
            {
                int q = a / m;
                int t = m;

                m = a % m;
                a = t;
                t = y;

                y = x - q * y;
                x = t;
            }

            return x < 0 ? x + m0 : x;
        }

        public static int SolveCongruence(int coefficient, int remainder, int modulus)
        {
            // Simplify coefficient modulo m
            coefficient = ((coefficient % modulus) + modulus) % modulus;

            // Find multiplicative inverse of coefficient
            int inverse = ModInverse(coefficient, modulus);

            // Calculate solution
            int solution = (remainder * inverse) % modulus;

            // Ensure positive result
            return ((solution % modulus) + modulus) % modulus;
        }
    }
}
