using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._5Kyu
{
    public static class RGBToHexConversion
    {
        //https://www.codewars.com/kata/513e08acc600c94f01000001/train/csharp

        /// <summary>
        /// The rgb function is incomplete. Complete it so that passing in RGB decimal values will result 
        /// in a hexadecimal representation being returned. Valid decimal values for RGB are 0 - 255. 
        /// Any values that fall out of that range must be rounded to the closest valid value.
        ///Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.
        /// </summary>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string Rgb(int r, int g, int b)
        {
            // Clamp values to the valid range 0-255
            r = Math.Clamp(r, 0, 255);
            g = Math.Clamp(g, 0, 255);
            b = Math.Clamp(b, 0, 255);

            return string.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
        }
    }
}
