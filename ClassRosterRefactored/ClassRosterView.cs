using System;
using ClasRosterRefactored;
using ClassRoster;

namespace ClasRosterRefactored
{
	class ClassRosterView
	{
		public void printString(string str) // prints a string
		{
			Console.WriteLine(str);
		}

		public void printList(List<Student> list) //prints a list of students
		{
			foreach (Student student in list)
			{
                Console.WriteLine(student);
            }
			
		}

		public String readInput() // gets input from user
		{
			return Console.ReadLine();
		}

	} // class VIEW
} // namespace