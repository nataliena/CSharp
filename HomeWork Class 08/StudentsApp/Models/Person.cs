using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person
    {
        /*Create a class Person that will have 4 properties 
         *(FirstName, LastName, Age, Gender-that will be enumeration).
          The person class should have a virtual method GetInfo that will print the information of that person.*/
          public string FirstName { get; set; }
          public string LastName { get; set; }
          public int Age { get; set; }
          public Gender Gender { get; set; }
          
          public Person (string firstName,string lastName,int age, Gender gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;


        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"FirstName:{FirstName}, LastName: {LastName},Age:{Age}, Gender: {Gender}");
        }
          

    }
}
