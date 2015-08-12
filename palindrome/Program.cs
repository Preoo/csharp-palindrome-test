using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    public class Palindrome
    {
        public static bool IsPalindrome(string str)
        {
            try
            {
                str = cleanString(str);
                char[] comp = str.ToCharArray();
                if (comp.Reverse().SequenceEqual(comp))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch
            {
                throw new NotImplementedException("Waiting to be implemented.");
            }
        }

        public static string cleanString (string input)
        {
            
            string output = input.ToLower().Trim();
            char[] arr = output.Where(c => (char.IsLetterOrDigit(c))).ToArray();
            return output = new string(arr);

        }

        public static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("Noel sees Leon."));
            Console.WriteLine(cleanString("RE ! ST. eE"));
            Console.WriteLine(IsPalindrome("RE ! ST. eE"));
            Console.WriteLine(IsPalindrome("aA"));
            Console.ReadKey();
        }
    }
}