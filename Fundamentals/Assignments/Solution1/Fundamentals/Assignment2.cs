using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class Assignment8
    {
        public void Uppercase()
        {
            Console.WriteLine("Enter the String");
            string sentence = Console.ReadLine();

            string reversed = Reversecase(sentence);
            Console.WriteLine(reversed);

            Reversecase(sentence);

            string Reversecase(string sentence)
            {
                char[] chars = sentence.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (char.IsUpper(chars[i]))
                    {
                        chars[i] = char.ToLower(chars[i]);
                    }
                    else if (char.IsLower(chars[i]))
                    {
                        chars[i] = char.ToUpper(chars[i]);

                    }

                }
                return new string(chars);
            }
        }
    }
}