This is a basic program that I created while I am teaching myself C#.  Its a basic program that asks the teacher if she wants to add a student.  Yes then it asks for the name and grade of the student.  It will keep asking to add students until she says no.  When she says no the program will display her entire class.  This is an adaptation to a tutorial on Lynda.com.
I encountered a couple of issues while making this program.

Issue one was creating a Dictionary.  
  I had this "Dictionary<string, string> students = new Dictionary<string, string>();"
  This is correct syntax however I was still getting an error.  I learned that I had to use  using System.Collections.Generic; at the top inorder to create a dictionary.
  
  Issue two was that I didn't know how to do a foreach loop and display the students inside the dictionary.  The solution is this foreach(KeyValuePair<string,string>student in students){
                    Console.WriteLine("Student ={0},Grade ={1}",student.Key,student.Value);.
                    
     I wanted to make an infinate loop so people would be able to add as many students as they wanted to.  I first did 
            do{Console.WriteLine("would you like to add a kid");
            var answer = Console.ReadLine();
            if (answer == "yes"){
                students=addStudent(students);
            }
            if (answer == "no"){
               
                    break;
                
            }}
            however that kept on throwing an error up.  I learned that if I did while(true){
            Console.WriteLine("would you like to add a kid");
            var answer = Console.ReadLine();
            if (answer == "yes"){
                students=addStudent(students);
            }
            if (answer == "no"){
               
                    break;
                
            }}
            that would fix the error.  
