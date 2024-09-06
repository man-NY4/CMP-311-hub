using ClassRosterRefactored;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoster
{
    class Student : Person
    {
        private string classRank;

        public Student() : base() // constructor no parameter
        {
            classRank = "";
        }

        public Student(string newFirstName, string newLastName, string newClassRank) : base(newFirstName, newLastName) // constructor w/ parameter
        {

            classRank = newClassRank;
        }

        public string ClassRank // property for classRank
        {
            get { return classRank; }
            set { classRank = value; }
        }

        public override string ToString() // override
        {
            return String.Format("First Name: {0}, Last Name: {1}, Class Rank: {2}", FirstName, LastName, ClassRank);
        }

    } // class Student
} // namespace