using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congruent_Solution.CognizantPreparation
{
    public class VersionControl
    {
        public static void Main()
        {
            Console.Write("Enter a String: ");
            string input  = Console.ReadLine()??"";
            RepeatedCharInString(input);
            Console.ReadLine();
        }
        public static void RepeatedCharInString(string input)
        {
            if(string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Empty String");
            }
            char[] chars = input.Replace(" ", "").ToLower().ToCharArray();
            Dictionary<char, int> myDictionary = new Dictionary<char, int>();
            foreach (char c in chars)
            {
                if (myDictionary.ContainsKey(c))
                {
                    myDictionary[c]++;
                }
                else
                {
                    myDictionary[c] = 1;
                }
            }
            foreach(var dictionary in myDictionary)
            {
                if(dictionary.Value > 1)
                {
                    Console.WriteLine("The Character "+dictionary.Key+ " is present "+dictionary.Value+" times");
                }
            }
        }
    }
}
