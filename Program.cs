using System;
using System.Collections.Generic;
namespace StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to your gradebook");
            Dictionary<string, string> students = new Dictionary<string, string>();
            while(true){
            Console.WriteLine("would you like to add a kid");
            var answer = Console.ReadLine();
            if (answer == "yes"){
                students=addStudent(students);
            }
            if (answer == "no"){
               
                    break;
                
            }
            }
            foreach(KeyValuePair<string,string>student in students){
                    Console.WriteLine("Student ={0},Grade ={1}",student.Key,student.Value);
                }

        }
        static Dictionary<string,string> addStudent(Dictionary<string,string>classroom){
            Console.WriteLine("What is his name");
            var name = Console.ReadLine();
            Console.WriteLine("What is his grade");
            var grade = Console.ReadLine();
            classroom.Add(name,grade);
            return classroom;
        }
        
    }
}
