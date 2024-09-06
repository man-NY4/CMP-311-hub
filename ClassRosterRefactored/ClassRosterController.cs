using ClassRoster;
using ClassRosterRefactored;
using System;

namespace ClasRosterRefactored
{
	class ClassRosterController
	{

		ClassRosterModel model = new ClassRosterModel();
		ClassRosterView view = new ClassRosterView();
		
		bool flag = true;
		public ClassRosterController()
		{
            view.printString("Class Roster Application in C#"); // title
            view.printString("-------------------------------------------------------------------\n");
            view.printString("Please enter the instructor's first name:");
            String iFirstName = view.readInput(); // saving inputs
            view.printString("Please enter the instructor's last name:");
            String iLastName = view.readInput();
            view.printString("Please enter the instructor's email:");
            String iContactInfo = view.readInput();
            model.addInstructor(iFirstName, iLastName, iContactInfo); // making the instructor

            while (flag)
            {
                

                view.printString("1. Add a student."); // user prompts
                view.printString("2. Print roster.");
                view.printString("3. Quit.");
                view.printString("Please enter an option");
                string userInput = view.readInput();
                view.printString("-------------------------------------------------------------------\n");


                if (userInput == "1") // checking for add student option
                {
                    view.printString("Please enter the student's first name");
                    String sFirstName = view.readInput(); // saving input
                    String sLastName = ""; // empty string for validation
                    while (sLastName == "") // while to check for valid last name
                    {
                        view.printString("Please enter the student's last name");
                        sLastName = view.readInput(); // saving input
                        if (sLastName == "") // if to prompt again if invalid
                        {
                            view.printString("Try again.");
                        }
                    }
                    String sClassRank = ""; // empty string for validation
                    while (sClassRank == "") // while to check for valid class rank
                    {
                        view.printString("Please enter the student's class rank");
                        sClassRank = view.readInput(); // saving input
                        if (sClassRank == "") // if to prompt again if invalid
                        {
                            view.printString("Try again.");
                        }
                    }
                    model.addStudent(sFirstName, sLastName, sClassRank);
                    view.printString("-------------------------------------------------------------------\n");
                } // option 1

                else if (userInput == "2") // print the roster option
                {
                    // start w/ instructor
                    view.printString(Convert.ToString(model.getInstructor()));
                    view.printList(model.getStudents());
                    view.printString("-------------------------------------------------------------------\n");
                } // option 2

                else if (userInput == "3") // quit option
                {
                    view.printString("Quitting application");
                    view.printString("-------------------------------------------------------------------\n");
                    flag = false; // end while loop
                } // option 3
                
                else // if invalid input is entered
                {
                    view.printString("Invalid input");
                } // option validation

            } // running the app
        } // constructor
	} // class CONTROLLER
} // namespace