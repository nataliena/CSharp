using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void Meal(int table);
    public class Chief
    {
        public event Meal EventHandler;

        public void Order(int table)
        {
            Console.WriteLine($"Table : {table}");

            EventHandler?.Invoke(table);
           
        }
    }
}
