using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;


namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the convertor direction");
            Console.WriteLine("1. From Gallon to Litar.");
            Console.WriteLine("2. From Litar  to Gallon.");
            Console.Write(":");

            string Selection = Console.ReadLine();
            double G, L = 0;

            
            switch (Selection)
            {
                case "1":
                    Console.Write("Please enter Liter: ");
                    G = LitterToGalon.LitarToGallon(Console.ReadLine());
                    Console.WriteLine("Gallons to Liter : {0:F2}", G);
                    break;

                case "2":
                    Console.Write("Please enter Gallon: ");
                    L = LitterToGalon.GallonsToLitar(Console.ReadLine());
                    Console.WriteLine("liters in Gallons: {0:F2}", L);
                    break;

                default:
                    Console.WriteLine("Please select a convertor.");
                    break;
            }


            Console.ReadLine();


        }
    }
}
