using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{   /*name(string), age(int), power level(int), 
    information if they have been tamed(boolean))*/

    public class Creatures
    {
        public string Name;
        public int Age;
        public int PowerLevel;
        public bool isTamed;
        public Creatures (string name,int age, int powerLevel,bool isTamed)
        {
            this.Name = name;
            this.Age = age;
            this.PowerLevel = powerLevel;
            this.isTamed = isTamed;
        }
    }
}
