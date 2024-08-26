using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoster
{
    class Instructor : Person
    {
        private string contactInfo;

        public Instructor() : base() // constructor no parameter
        {
            contactInfo = "";
        }

        public Instructor(string newFirstName, string newLastName, string newContactInfo) // constructor w/ parameter
        {
            
            contactInfo = newContactInfo;
        }

        public string ContactInfo // property for contactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }

        public override string ToString() // override
        {
            return String.Format("First Name: {0}, Last Name: {1}, Contact Info: {2}", FirstName, LastName, ContactInfo);
        }

    } // class Instructor
} // namespace