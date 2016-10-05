using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// <author>Gorkem Sazara</author>
// <date>23/02/2016</date>
// <summary></summary>
namespace Accenture
{
    class Program
    {
        public static int ReadInt32(string value)
        {
            int val = -1;
            if (!int.TryParse(value, out val))
                return -1;
            return val;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input n value");
            string sentence = "abbcccaaeeeeb bfffffca ccab";
            int charCountInput = ReadInt32( Console.ReadLine());

            Repeat r = new Repeat();
            sentence = r.FindDuplicatedStrRemoved(charCountInput, sentence);

            Console.WriteLine(sentence);
                //To see the output
            Console.ReadLine();
        }
    }
}
