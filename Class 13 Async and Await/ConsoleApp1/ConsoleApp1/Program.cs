using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1  // async and await  in C#
{
    class Program

    {
        public static void PrintUserMess(string mess)
        {
            //Thread.Sleep(3000);
            Console.WriteLine(mess);
        }

        public static async Task PrintMessEmail(string name)
        {
            Console.WriteLine("This message is send by email");
            await Task.Run(() =>
            {
                Thread.Sleep(4000);
                Console.WriteLine($"{name} This is send async");
            });
          }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your message");
            string mess = Console.ReadLine();

            Console.WriteLine("________________________");
            Task x = PrintMessEmail(name);
            
            PrintUserMess(mess);
            //PrintUserMess(mess);
            //Task x = PrintMessEmail(name);


            Console.ReadLine();



        }
        }
}
