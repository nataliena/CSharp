using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witchcraft_and_Wizardry
{
    class Program

    {   public static void Duel(Wizards[] wizards,Creatures[] creatures)
        {
            for (int i = 0; i < wizards.Length; i++)
            {
                for (int j = 0; j < creatures.Length; j++)
                {
                    if (wizards[i].PowerLevel > creatures[j].PowerLevel)
                    {
                        creatures[j].isTamed = true;
                        Console.WriteLine(" The Wizard {0} has tamed the Creature {1}", wizards[i].Name, creatures[j].Name);
                    }
                    else
                    {
                        Console.WriteLine(" The Wizard {0} did not tame the Creature {1}", wizards[i].Name, creatures[j].Name);
                    }

                }


            }

            for (int i = 0; i < creatures.Length; i++)
            {
                if (creatures[i].isTamed == false)
                {
                    Console.WriteLine(" The Creatures {0} cant' be tamed by these Wizards", creatures[i].Name);
                }
            }
        }



        static void Main(string[] args)
        {
            Wizards[] wizards = new Wizards[]
            {
                new Wizards("Alatar",100,200,new DateTime(1600,2,12),true),
                new Wizards("Gandalf",150,230,new DateTime(1650,12,2),true),
                new Wizards("Ganon",170,300,new DateTime(1550,3,13),true),
            };
            Creatures[] creatures = new Creatures[]
            {
                new Creatures("Pallando",80,90,false ),
                new Creatures("Saruman",70,160,false),
                new Creatures("Puck",60,50,false),
                new Creatures("Oscar",50,300,false),
            };


            Duel(wizards, creatures);

            Console.ReadLine();
        }
    }
}

    

