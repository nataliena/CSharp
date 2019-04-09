using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> IsPalindrome = (s) =>
            {
                string s1 = string.Join("", s.Reverse());

                if (s == s1)
                {
                    Console.WriteLine($"Its palindriome");
                }
                else
                {
                    Console.WriteLine("Itts not a palindorme");
                }

            };


            Action<string> wordsCount = (s) =>
              {
                  string[] words = s.Split(' ');


                  int n = words.Count();
                  Console.WriteLine($"This string has {n} words");

              };

            Action<string> reverse = s =>
               {
                  
                  
                   string reverse1 = String.Join("", s.Reverse());
                   
                   Console.WriteLine(reverse1);

               };

            IsPalindrome += wordsCount;
            
            IsPalindrome += reverse;

            Console.WriteLine("Type some text");
            string Text = Console.ReadLine();
            IsPalindrome(Text);
            Console.ReadLine();






        }
    }
}
