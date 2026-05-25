namespace CodeWars._7kyu
{
    public static class JadenCasingStrings
    {
        //https://www.codewars.com/kata/5390bac347d09b7da40006f6/train/csharp

        /// <summary>
        /// Return a string where every word has a campital letter - jaden smyth casing 
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        public static string ToJadenCase(this string phrase)
        {
            return new string(phrase.Select((x, i) => i == 0 || phrase[i - 1].Equals(' ') ? char.ToUpper(x) : x).ToArray());
            //clever
            //return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
        }
    }
}
