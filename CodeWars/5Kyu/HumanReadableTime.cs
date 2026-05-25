using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CodeWars._5Kyu
{
    //https://www.codewars.com/kata/52685f7382004e774f0001f7/train/csharp
    public static class HumanReadableTime
    {
        /// <summary>
        /// Write a function, which takes a non-negative integer (seconds) as 
        /// input and returns the time in a human-readable format (HH:MM:SS)
        ///HH = hours, padded to 2 digits, range: 00 - 99
        ///MM = minutes, padded to 2 digits, range: 00 - 59
        ///SS = seconds, padded to 2 digits, range: 00 - 59
        ///The maximum time never exceeds 359999 (99:59:59)
        ///You can find some examples in the test fixtures.
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static string GetReadableTime(int seconds)
        {
            // Clamp to range 0..359999 (99:59:59)
            seconds = Math.Clamp(seconds, 0, 359999);

            var hours = seconds / 3600;
            var minutes = (seconds % 3600) / 60;
            var secs = seconds % 60;

            return string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, secs);
        }
    }
}
