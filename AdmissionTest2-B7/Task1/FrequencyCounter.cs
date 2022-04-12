using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FrequencyCounter
    {
        public string Count(string text)
        {
            string stringResult = "";

            string inputString = text;

            string newstring = new String(inputString.Distinct().ToArray());


            int intLen = newstring.Length;
            int k = 1;

            char[] chrarray = newstring.ToCharArray();
            Array.Sort(chrarray);

            foreach (char c in chrarray)
            {
                stringResult= stringResult+ (CountCharacter(c, inputString));

                if (k != intLen)
                    stringResult = stringResult + ",";

                k = k + 1;

            }


            return stringResult;
        }

        public string CountCharacter(char paramchar, string s)
        {
            int i = 0;

            foreach (char c in s)
            {
                if (c == paramchar)
                    i = i + 1;
            }

            return paramchar.ToString() + "-" + i.ToString();

        }

    }
}
