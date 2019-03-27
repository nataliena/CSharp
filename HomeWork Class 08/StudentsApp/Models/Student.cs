using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student:Person
    {
        /*Create a class Student that will derive from the Person class. Student class should have properties 
         * Id, Group, Course.
         Student class should override GetInfo method and should return 
         the Full name of student plus the id and witch group is in.*/

        public int Id { get; set; }
        public string Group { get; set; }
        public string Course { get; set; }
        public Student(string firstName, string lastName, int age, Gender gender, 
                       int id, string group, string course)
             :base(firstName, lastName, age, gender)
        {
            this.Id=id;
            this.Group=group;
            this.Course=course;
            
        }
        public override void GetInfo()
        {   

            Console.WriteLine($"Full Name: {this.FirstName } {this.LastName} Id: {this.Id} Group : {this.Group}");
        }
        



        }
}
