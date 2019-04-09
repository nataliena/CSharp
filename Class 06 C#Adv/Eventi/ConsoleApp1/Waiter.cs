using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
 public class Waiter
    { 
        public int TableNumber { get; set; }
        public Waiter(int tableNumber)
        {
            TableNumber = tableNumber;
        }


        public void Listen(int table)
        {
              if (TableNumber==table)
                Console.WriteLine($"The Meals is served on table {table}!");
            }
        }
}
