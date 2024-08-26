using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoster
{
    class Person
    {
        private string firstName;
        private string lastName;
        public Person() // constructor no parameters
        {
            firstName = "";
            lastName = "";
        }

        public Person(string newFirstName, string newLastName) // constructor w/ parameters
        {
            firstName=newFirstName;
            lastName=newLastName;
        }

        public string FirstName // property for firstName
        {
            get { return firstName; } // get
            set { firstName = value; } // set
        }

        public string LastName // property for lastName
        {
            get { return lastName; } // get
            set { lastName = value; } // set
        }

    } // class Person
} // namespace