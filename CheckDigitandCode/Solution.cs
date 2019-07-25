using System;

namespace CheckDigitandCode
{
    public class Solution
    {
        public static string countletters(string Input)
        {
            int val = 0;
            for (int i = 0; i <= Input.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    val = val + int.Parse(Input[i].ToString()) * 3;
                }
                else
                {
                    val = val + int.Parse(Input[i].ToString());
                }
            }

            string checkDigit = (10 - (val % 10)).ToString();

            string fullstring = Input + checkDigit;

            string string1 = fullstring.Substring(0, 9);

            string string2 = fullstring.Substring(9, 9);

            int val1 = 0, val2 = 0;
            for (int i = 0; i <= string1.Length - 1; i++)
            {
                val1 = val1 + int.Parse(string1[i].ToString()) * (3 + i);

            }

            for (int j = 0; j <= string2.Length - 1; j++)
            {
                val2 = val2 + int.Parse(string2[j].ToString()) * (3 + j);

            }

            string checkCode = ((val1 + val2 + 207) % 103).ToString();

            return checkDigit + "," + checkCode;
        }

        public static void Main(string[] args)
        {
            string s = countletters("87815811023456421");
            Console.WriteLine(s);
            Console.ReadKey();
        }

    }
}
