using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void PrintCollection(IEnumerable collection, string name)
        {
            Console.WriteLine($"Elements from collection {name}");
            foreach (var o in collection)
            {
                Console.Write($"{o}, ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region Types of generic collections
            /*IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");
            PrintCollection(dict,"Array dict");

            ArrayList arr1 = new ArrayList() { 1, "Natasha", true };
            arr1.Add(2);
            arr1.Add("Jas sum nared");
            arr1.Remove("Natasha");
            PrintCollection(arr1, "ArrayList");

            IList<string> list = new List<string>();
            list.Add("Natasha");
            list.Add("Goran");
            list.Add("Mateo");
            list.Add("Danilo");
           
            var nameHere= list.Select(s => s.Contains("Mateo"));
            PrintCollection(nameHere,"IList");*/

         /* Queue <string> name=new Queue<string>();
            name.Enqueue("Natasha");
            name.Enqueue("Goran");
            name.Enqueue("Mateo");
            name.Dequeue();
            PrintCollection(name, "Queue");
            Stack stack=new Stack();
            stack.Push("one");
            stack.Push("two");
            stack.Push("three");
            stack.Peek();
            stack.Pop();
            PrintCollection(stack,"stack");
            Console.WriteLine($"{stack.Peek()}");
            Dictionary <int,string> adrees=new Dictionary<int, string>();
            adrees.Add(1,"Jas");
            adrees.Add(2,"Goran");
            adrees.Remove(2);
            PrintCollection(adrees,"Dictionary");*/
            #endregion

            #region PhoneBook
            Dictionary<string,int> addressBook=new Dictionary<string, int>();
            addressBook.Add("Natasha",077815066);
            addressBook.Add("Goran",077954298);
            addressBook.Add("Danilo",075911565);
           /* Console.WriteLine(addressBook.ContainsKey("Natasha"));*/

            Console.WriteLine("Enter some name");
            string name=Console.ReadLine();
                          			               
			   if(addressBook.ContainsKey(name))
                    {
                    Console.WriteLine(" User {0} -Phone number- {1}",name, addressBook[name]);
                     } 
                else 
                    {
                   Console.WriteLine(" A user with that name could not be found");
	                }

               #endregion


               
            Console.ReadLine();

        
}
        
    }
}
