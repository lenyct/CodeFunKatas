using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._6kyu
{
    //https://www.codewars.com/kata/583203e6eb35d7980400002a/train/csharp
    public static class CountTheSmileyFaces
    {

        /// <summary>
        /// Given an array (arr) as an argument complete the function countSmileys that should return the total number of smiling faces.
        /// Rules for a smiling face:
        /// Each smiley face must contain a valid pair of eyes.Eyes can be marked as : or ;
        /// A smiley face can have a nose but it does not have to.Valid characters for a nose are - or ~
        /// Every smiling face must have a smiling mouth that should be marked with either ) or D
        /// No additional characters are allowed except for those mentioned.
        /// Valid smiley face examples: :) :D ;-D :~)
        /// Invalid smiley faces: ;( :> :} :]
        /// </summary>
        /// <param name="smileys"></param>
        /// <returns></returns>
        public static int CountSmileys(string[] smileys)
        {
            var validEyes = new[] { ':', ';' };
            var validNose = new[] { '-', '~' };
            var validMouth = new[] { ')', 'D' };

            var count = 0;

            foreach(var s in smileys)
            {
                if(s.Length == 3)
                {

                    if (validEyes.Contains(s[0]) && validNose.Contains(s[1]) && validMouth.Contains(s[2]))
                        count++;
                }
                if (s.Length == 2)
                {

                    if (validEyes.Contains(s[0]) && validMouth.Contains(s[1]))
                        count++;
                }
            }
            //return count;

            var r1 = smileys.Where(s =>
                    (s.Length == 2 && validEyes.Contains(s[0]) && validMouth.Contains(s[1])) ||
                    (s.Length == 3 && validEyes.Contains(s[0]) && validNose.Contains(s[1]) && validMouth.Contains(s[2])));
            return r1.Count(); 
        }
    }
}
