using System;
using System.Linq;
using System.Collections.Generic;

namespace StudentGradeManager
{
    class Students
    {
        public string? Name ;
        public int Rollno;
        const int Subjectcount = 5;
        public int total;
        public double percentage;
        public Dictionary<string, int> Subject = new Dictionary<string, int>();
        public Students()
        {
            Console.WriteLine("Student Grade");

        }
        public void GetInput(){
            Console.Write("Enter your name: ");
            Name = Console.ReadLine();
            Console.Write("Enter your Roll Number: ");
            while (!int.TryParse(Console.ReadLine(), out Rollno) || Rollno <= 0)
            {
                Console.WriteLine("Invalid Input!");
            }
        }
        public void GetSubjects(){
            for (int i = 1; i <= Subjectcount; i++){
                string? subjectName;
                Console.Write($"Enter The Subject Name {i}: ");
                subjectName = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(subjectName) || Subject.ContainsKey(subjectName))
                {
                    Console.Write("Empty or duplicate name.\nEnter Again:");
                    subjectName = Console.ReadLine();
                }
                int marks;
                Console.Write($"Enter Marks For {subjectName} (0- 100): ");
                while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > 100){
                    Console.WriteLine("Invalid.\nEnter marks from 0 to 100");
                }
                Subject[subjectName] = marks;
            }
        }
        public int CalculateTotal()
        {
            total = Subject.Values.Sum();
            return total;
        } 
        public double CalculatePercentage(){
            percentage = (double)CalculateTotal() / Subjectcount;
            return percentage;
        }
        public string ShowGrade()
        {
            int band = (int)CalculatePercentage()/10;
            switch (band){
                case 10:
                case 9:
                       return "A";
                case 8:
                    return "B";
                case 7:
                case 6:
                    return "C";
                case 5:
                case 4:
                    return "D";
                default:
                return "Fail";
            }
        }
        public void Display(){
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine($"Name            : {Name}");
            Console.WriteLine($"Roll Number     : {Rollno}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Subject          Marks");
            foreach (KeyValuePair<string,int> items in Subject)
            {
                Console.WriteLine($"{items.Key,-15} {items.Value}");
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Total           :{CalculateTotal()}/{100*Subjectcount}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Percentage      :{CalculatePercentage():f2}%");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Grade           :{ShowGrade()}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
            
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Students student = new Students();
            student.GetInput();
            student.GetSubjects();
            student.Display();
        }
    }
}