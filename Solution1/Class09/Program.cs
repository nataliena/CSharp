using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;



namespace Class09
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Dog> dogs = new List<Dog>()
            {
                new Dog("race1","sarko", 3, "red"),
                new Dog("race2","sarko1", 4, "blue"),
                new Dog("race3","sarko2", 5, "pink"),
                new Dog("race4","sarko3", 6, "black"),
            };

            List<Cat> cats = new List<Cat>()
            {
                new Cat("maca1",2,"white",true),
                new Cat("maca2",5,"red",false),
                new Cat("maca3",3,"blue",true),
                new Cat("maca4",7,"yellow",false),
            };
            List<Bird> birds = new List<Bird>()
            {
                new Bird("bird1",3,"white",false),
                new Bird("bird2",3,"red",true),
                new Bird("bird3",1,"brown",false),
                new Bird("bird4",2,"blue",true),
                

            };
            var particularRace = dogs
                            .Where(x => x.Race == "race1")
                            .ToList();

            foreach (var item in particularRace)
            {
                item.Print();
            }

            var lastlazyCat = cats
                             .Where(x => x.IsLazy == true)
                             .LastOrDefault();

            Console.WriteLine(lastlazyCat.Name);
            List<Bird> allBirds = birds
                              .Where(x => x.IsWild == true && x.Age < 3)
                              .OrderBy(x => x.Name)
                              .ToList();

            foreach (var item in allBirds)
            {
                item.Print();
            }
            string s1 = "natasha";
            Console.WriteLine(s1.GetFirstLetter());
            string s2 = "Natasha is developer";
            Console.WriteLine(s2.GetLastLetter());
            int integer = 32;
            Console.WriteLine(integer.isEven());







            Console.ReadLine();

        }
    }
}
