using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Chief chief = new Chief();
            Waiter waiter1 = new Waiter(2);
            Waiter waiter2 = new Waiter(3);

            chief.EventHandler += waiter1.Listen;
            chief.EventHandler += waiter2.Listen;


            chief.Order(2);

            Console.ReadLine();

        }
    }
}
