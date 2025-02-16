namespace CodeWars._7kyu
{
    public class MaskifyCode
    {
        //https://www.codewars.com/kata/5412509bd436bd33920011bc/train/csharp
        //returned a masked string
        public static string Maskify(string cc)
        {
          return cc.Length> 4 ? cc = new string('#', cc.Length - 4) + cc.Substring(cc.Length - 4) : cc;
        }
    }
}
