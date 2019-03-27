using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace StudentsApp
{
    class Program

    {
        public static void PrintStudentsList(List<Student> students, string name)
        {
            Console.WriteLine($"Elements from collection {name}");
            foreach (var s in students)
            {
              
                s.GetInfo();
            }
            Console.WriteLine();

        }


            static void Main(string[] args)
        {
            /*create a list that have 20 students.

            Create a user interface with the following functionalities:
	        Print info for all female students
	        Print info for all male students info
	        Print info for all students with a first letter of a name ( user should input a letter )
	        Print info for all students that are in group ( user should input a number of group )
	        Print info for student with id ( user should input an id )*/
            List<Student> students = new List<Student>();
            students.Add(new Student("Natasha", "Andova", 36, Gender.Female, 1, "G1", "C# Advanced"));
            students.Add(new Student("Valentina", "Palkovska", 35, Gender.Female, 2, "G1", "C# Basic"));
            students.Add(new Student("Krsitina", "Spasevska", 33, Gender.Female, 3, "G1", "HTML"));
            students.Add(new Student("Marijan", "Pinev", 30, Gender.Male, 4, "G2", "C# Basic"));
            students.Add(new Student("Tose", "Todorov", 25, Gender.Male, 5, "G2", "JavaScript Advanced"));
            students.Add(new Student("Martina", "Panova", 29, Gender.Female, 6, "G3", "CSS"));
            students.Add(new Student("Goran", "Kuzmanov", 30, Gender.Male, 7, "G6", "JavaScript Advanced"));
            students.Add(new Student("Jovan", "Jovanovski", 22, Gender.Male, 8, "G5", "C# Basic"));
            students.Add(new Student("Marija", "Temelkova", 27, Gender.Female, 9, "G6", "C# Advanced"));
            students.Add(new Student("Trajan", "Popov", 35, Gender.Male, 10, "G4", "JavaScript Basic"));
            students.Add(new Student("Dejan", "Angelov", 25, Gender.Male, 11, "G3", "CSS"));
            students.Add(new Student("Pavlina", "Petrova", 29, Gender.Female, 12, "G1", "HTML"));
            students.Add(new Student("Jane", "Kostov", 35, Gender.Male, 13, "G2", "C# Basic"));
            students.Add(new Student("Jana", "Plotnikova", 31, Gender.Female, 14, "G6", "C# Advanced"));
            students.Add(new Student("Viki", "Trajkova", 19, Gender.Female, 15, "G5", "CSS"));
            students.Add(new Student("Martin", "Panov", 28, Gender.Male, 16, "G7", "HTML"));

            students.Add(new Student("Joana", "Neshova", 38, Gender.Female, 17, "G1", "C# Basic"));
            students.Add(new Student("Kristijan", "Kolev", 24, Gender.Male, 18, "G1", "C# Basic"));
            students.Add(new Student("Ivana", "Radeva", 36, Gender.Female, 19, "G1", "C# Basic"));
            students.Add(new Student("Zoran", "Kocev", 26, Gender.Male, 20, "G1", "C# Basic"));

            List<Student> femaleList = students
                                        .Where(s => s.Gender == Gender.Female)
                                       .ToList();
            PrintStudentsList(femaleList, "Female Students");

            List<Student> maleList = students
                    .Where(s => s.Gender == Gender.Male)
                    .ToList();
            PrintStudentsList(maleList, "Male Students");

            Console.WriteLine("Please enter a letter");
            string letter = Console.ReadLine().ToUpper();
            List<Student> firtsLetterName = students
                .Where(s => s.FirstName.StartsWith(letter))
                .ToList();
        PrintStudentsList(firtsLetterName, "Students filtered by first letter");

            Console.WriteLine("Please enter a group");
            string group = Console.ReadLine().ToUpper();
            List<Student> studentsListGroup = students
                .Where(s => s.Group==group)
                .ToList();
            PrintStudentsList(studentsListGroup, "Students filtered by Group");

            Console.WriteLine("Please enter Id ");
            int id = int.Parse(Console.ReadLine());
            List<Student> studentsListByID = students
                .Where(s => s.Id == id)
                .ToList();

           PrintStudentsList(studentsListByID, "Students filtered by Id");

                               
            Console.ReadLine();




        }
    }
}
