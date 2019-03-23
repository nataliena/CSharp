using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Wizards

    {
        public string Name;
        public int PowerLevel;
        public int Age;
        public DateTime DateOfAdmission;
        public bool Graduation;
        public Wizards(string name, int powerLevel, int age, DateTime dateOfAdmission, bool graduation)
        {
            this.Name = name;
            this.PowerLevel = powerLevel;
            this.Age = age;
            this.DateOfAdmission = dateOfAdmission;
            this.Graduation = graduation;
        }


    }
}
