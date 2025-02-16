using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWars.Tests._6kyu
{
    public class ReversingAProcessTests
    {
        public static void testing_decode(string r, string expected)
        {
            var actual = ReversingAProcess.Decode(r);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public static void test1()
        {
            testing_decode("1273409kuqhkoynvvknsdwljantzkpnmfgf", "uogbucwnddunktsjfanzlurnyxmx");
            testing_decode("1544749cdcizljymhdmvvypyjamowl", "mfmwhbpoudfujjozopaugcb");
            testing_decode("105860ymmgegeeiwaigsqkcaeguicc", "Impossible to decode");

        }
    }
}
