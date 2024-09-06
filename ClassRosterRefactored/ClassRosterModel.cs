using ClassRoster;
using System;

namespace ClasRosterRefactored
{
	class ClassRosterModel
	{
		Instructor instructor; // instantialize instructor
		List<Student> studentRoster; // instantialize list of students

        public ClassRosterModel() // constructor to make new instructor and students list
		{
			instructor = new Instructor();
			studentRoster = new List<Student>();
		}

		public void addInstructor(string firstName, string lastName, string contactInfo) // adds instructor
		{
			instructor.FirstName = firstName;
			instructor.LastName = lastName;
			instructor.ContactInfo = contactInfo;
		}

		public void addStudent(string firstName, string lastName, string classRank) // adds new student to the list
		{
			Student student = new Student();
			student.FirstName = firstName;
			student.LastName = lastName;
			student.ClassRank = classRank;
			studentRoster.Add(student);
		}

		public Instructor getInstructor()
		{
			return instructor;
		}

		public List<Student> getStudents()
		{
			return studentRoster;
		}

	} // class MODEL
} // namespace