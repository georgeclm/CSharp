using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wek7
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "anjas";
            string b = "Anjas";
            bool result = a.Equals(b);//case insensitive
            bool secResult = a.Equals(b, StringComparison.OrdinalIgnoreCase);//case sensitive
            string original = "This is a sentence. This is a second sentence.";
            string sentence1 = original.Substring(0, original.IndexOf(".") + 1);// Substring (index to take before and after, the index string to number)
            string phrase = "1122351,5566445 ,458665 ";
            string[] words = phrase.Split(',');
            string f = "This is a trial dumb";
            string g = f.Replace("a", "lol ");
            string y = "A lot of word in hereree";
            string z = y.Remove(2, 4);
            string o = "dfddsa";
            string p = o.Insert(5, "sdfass");
            Console.WriteLine("This is before remove '{0}' This is after remove  '{1}'", y, z);
            Console.WriteLine("This is before insert '{0}' This is after insert  '{1}'", o, p);
            Console.WriteLine(z);
            Console.WriteLine(g);
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine(words[0]);
            Console.WriteLine(original);
            Console.WriteLine(sentence1);
            Console.WriteLine(secResult);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
