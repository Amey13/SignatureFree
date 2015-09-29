using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace sigfree_demo_
{
    /*
     * firstPhase contain two Steps of Sigfree architecture
     * 1-Uri Decoder
     * 2-ASCII Filter
     */
    class FirstPhase
    {
        public static String Filter_Ascii(string str, ref  int count_Non_Ascii)
        {
            Sigfree obj = new Sigfree();
            count_Non_Ascii = 0;
            String non_ascii = ""; //used to store all non ascii charactors


            if (Regex.IsMatch(str, @"[^\u0020-\u007E]", RegexOptions.None))
            {
                foreach (char c in str)
                {
                    if (c <= '\u0020' || c >= '\u007E')
                    {
                        non_ascii = non_ascii + c;

                        count_Non_Ascii++;
                    }
                }
                Console.WriteLine("No of Non ascii chars  found=" + count_Non_Ascii);
                Console.WriteLine("The non ascii strin is   =" + non_ascii);
            }
            return non_ascii;

        }


        public static String Con_Byte(String Non_Ascii)//used to convert non ascii to byte..
        {
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            byte[] byteArray1 = encoding.GetBytes(Non_Ascii);
            string byte_converted = BitConverter.ToString(byteArray1);
            string str1 = "";
            if (!byte_converted.Equals(""))
            {
                str1 = "\\x" + byte_converted.Replace("-", "\\x");
                return str1;
            }
            else
                return str1;
        }
    }
}
