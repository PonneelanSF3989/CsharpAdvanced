using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public static  class Operation
    {
        
        public static void CallEvent()
        {
            Events.eventLink += new EventHandler (GetString);
            Events.EventHolder();
        }
        public static void GetString()
        {
            Console.WriteLine("\nEnter the word to perform\n");
            string word  = Console.ReadLine();
            ToLower(word);
            ToUpper(word);
            IsPalindrome(word);
        }

        public static void ToUpper(string word)
        {
            string upper = word.ToUpper();
            Console.WriteLine("Upper case : "+upper);
        }
        public static void ToLower(string word)
        {
            string lower = word.ToLower();
            Console.WriteLine("LowerCase : "+lower);
        }
        public static void IsPalindrome(string word)
        {
            string temp = "";
            foreach(char x in word)
            {
                temp+=x;
            }

            if (temp == word)
            {
                Console.WriteLine("Is Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
        }
    }
}