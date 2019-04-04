using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5App
{
    class Program
    {
        public delegate void Print(string text, string user);
        static void Main(string[] args)
        {
            Print printEmail = new Print(EmailNotification);
            Print printSms = new Print(SmsNotification);
            Print printMms = new Print(MmslNotification);
            printEmail += printSms;
            printEmail += printMms;

            printEmail("Zdravo , kako si?", "Natasha");
            User user1 = new User();
            user1.Name = "Natasha Andova";
            user1.Sms = 077815066;
            user1.Email = "natasa.andonova@gmail.com";
            user1.PrintFullInfo();

            Console.ReadLine();
            
        }

        public static void EmailNotification(string text, string user)
        {
            Console.WriteLine($"This message {text} is send to {user} via Email");
        }
        public static void SmsNotification(string text, string user)
        {
            Console.WriteLine($"This message {text} is send to {user} via Sms");
        }
        public static void MmslNotification(string text, string user)
        {
            Console.WriteLine($"This message {text} is send to {user} via Mms");
        }
        

    }
}
