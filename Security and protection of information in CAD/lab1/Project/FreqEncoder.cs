using System;
using System.Collections.Generic;
using System.Linq;
 
namespace Project
{
    public class FreqEncoder
    {
        private static readonly char[] alphabeth = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        private static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public static IEnumerable<char> SelectByFrequency(IEnumerable<char> arr)
        {
            return arr.Where(Char.IsLetter).GroupBy(n => n)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key);
        }
 
        public static IEnumerable<char> CreateKey(IEnumerable<char> arr)
        {
            var alph = (char[])alphabeth.Clone();
            int pos = 0, i = 0;
            foreach (var item in arr)
            {
                if ((pos = Array.IndexOf(alph, item)) != -1)
                {
                    Swap(ref alph[i], ref alph[pos]);
                }
                i++;
            }
            return alph;
        }
 
        public static IEnumerable<char> Encrypt(IEnumerable<char> text, IEnumerable<char> alphKey)
        {
            var str = text.ToArray();
            var key = alphKey.ToArray();
            int pos = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((pos = Array.IndexOf(alphabeth, str[i])) != -1)
                    str[i] = key[pos];
            }
            return str;
        }

        public static IEnumerable<char> Decrypt(IEnumerable<char> text, IEnumerable<char> alphKey)
        {
            var str = text.ToArray();
            var key = alphKey.ToArray();
            int pos = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((pos = Array.IndexOf(key, str[i])) != -1)
                    str[i] = alphabeth[pos];
            }
            return str;
        }   
    }

    class Program
    {
        static void Main(string[] args)
        {
            //  Input text only support in english
            Console.Write("Please input text: ");
            var text = Console.ReadLine().ToLower().ToCharArray();
 
            //  Building a frequency alphabet from second text
            var text2 = "IEnumerable<char> Decrypt(IEnumerable<char> text, IEnumerable<char> alphKey".ToLower().ToCharArray();
 
            //  Building a frequency alphabet
            var freqKey = FreqEncoder.SelectByFrequency(text2);
 
            //  Replacing the first character of the alphabet with the first character of the frequency alphabet
            var key = FreqEncoder.CreateKey(freqKey);
 
            Console.Write("Debug input Text: ");
            Console.WriteLine(String.Join("", text));
 
            // Process enncrypting
            text = FreqEncoder.Encrypt(text, key).ToArray();
 
            Console.Write("Encrypted text: ");
            Console.WriteLine(String.Join("", text));
 
            // Process decrypting
            text = FreqEncoder.Decrypt(text, key).ToArray();
 
            Console.Write("Decrypted text: ");
            Console.WriteLine(String.Join("", text));
 
            Console.ReadKey(true);
        }
    }
}