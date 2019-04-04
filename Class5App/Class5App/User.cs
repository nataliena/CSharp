using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5App
{
   public class User
    {
        public string Name { get; set; }
        public int Sms { get; set; }
        public string Email { get; set; }
        public void PrintFullInfo()
        {
            Console.WriteLine($"{this.Name}, {this.Sms}, {this.Email} ");
        }
        
    };
}
