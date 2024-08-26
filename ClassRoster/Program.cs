using System;
using System.Collections.Generic;

namespace ClassRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("Class Roster Application in C#"); // title
            Console.WriteLine("-------------------------------------------------------------------\n");

            Instructor theInstructor = new Instructor(); // making instructor for user to input

            Console.WriteLine("Please enter the instructor's first name:");
            theInstructor.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter the instructor's last name:");
            theInstructor.LastName = Console.ReadLine();
            Console.WriteLine("Please enter the instructor's email:");
            theInstructor.ContactInfo = Console.ReadLine();

            List<Student> students = new List<Student>(); // list for students to be added to
            List<Student> sortedStudents = new List<Student>(); // ongoing list for students to be added to

            while (flag) // while
            {
                Console.WriteLine("1. Add a student."); // user prompts
                Console.WriteLine("2. Print roster.");
                Console.WriteLine("3. Quit.");
                Console.WriteLine("Please enter an option");
                string userInput = Console.ReadLine();
                Console.WriteLine("-------------------------------------------------------------------\n");

                if (userInput == "1") // checking for add student option
                {
                    Student student = new Student(); // new student
                    Console.WriteLine("Please enter the student's first name");
                    student.FirstName = Console.ReadLine();
                    while (student.LastName == "") // while to check for valid last name
                    {
                        Console.WriteLine("Please enter the student's last name");
                        student.LastName = Console.ReadLine();
                        if (student.LastName == "") // if to prompt again if invalid
                        {
                            Console.WriteLine("Try again.");
                        }
                    }
                    while (student.ClassRank == "") // while to check for valid class rank
                    {
                        Console.WriteLine("Please enter the student's class rank");
                        student.ClassRank = Console.ReadLine();
                        if (student.ClassRank == "") // if to prompt again if invalid
                        {
                            Console.WriteLine("Try again.");
                        }
                    }
                    students.Add(student); // add student to default list
                    sortedStudents.Add(student); // add student to the to be sorted list
                    Console.WriteLine("-------------------------------------------------------------------\n");
                } // option 1

                else if (userInput == "2") // print the roster option
                {
                    Console.WriteLine("Choose an option."); // begin option select
                    Console.WriteLine("1: Print the roster as entered.");
                    Console.WriteLine("2: Print the roster sorted by student last name");
                    Console.WriteLine("3: Print the roster sorted by student class rank");
                    Console.WriteLine("Please enter an option");
                    string userInputTwo = Console.ReadLine(); // input for the option select
                    if (userInputTwo == "1") // print roster as entered
                    {
                        Console.WriteLine(theInstructor); // start w/ instructor
                        
                        foreach (Student student in students) // print each student
                        {
                            Console.WriteLine(student);
                        }
                        Console.WriteLine("-------------------------------------------------------------------\n");
                    }
                    else if (userInputTwo == "2") // print roster by student last name
                    {
                        sortedStudents.Sort((x, y) => string.Compare(x.LastName, y.LastName)); // lambda expression to sort last name
                        Console.WriteLine(theInstructor);// start w/ instructor
                        
                        foreach (Student student in sortedStudents) // print each student
                        {
                            Console.WriteLine(student);
                        }
                        Console.WriteLine("-------------------------------------------------------------------\n");
                    }
                    else if (userInputTwo == "3") // print roster by class rank
                    {
                        sortedStudents.Sort((x, y) => string.Compare(x.ClassRank, y.ClassRank)); // lambda expression to sort class rank
                        Console.WriteLine(theInstructor); // start w/ instructor
                        
                        foreach (Student student in sortedStudents) // print each student
                        {
                            Console.WriteLine(student);
                        }
                        Console.WriteLine("-------------------------------------------------------------------\n");
                    }
                    else // invalid option
                    {
                        Console.WriteLine("Invalid option");
                        Console.WriteLine("-------------------------------------------------------------------\n");
                    }
                }
                else if (userInput == "3") // quit option
                {
                    Console.WriteLine("Quitting application");
                    Console.WriteLine("-------------------------------------------------------------------\n");
                    flag = false; // end while loop
                }
                else // if invalid input is entered
                {
                    Console.WriteLine("Invalid input");
                }
            } // big while
        } // Main
    } // class Program
} // namespace