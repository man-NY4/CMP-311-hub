using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CalcRefactored
{
    class CalcController
    {
        CalcModel model = new CalcModel(); // initzialize to use methods
        CalcView view = new CalcView(); // initzialize to use methods
        
        bool endApp = false;

        public CalcController()
        {
            while (!endApp) // start of program
            {
                // Display title as the C# console calculator app.
                view.printString("Console Calculator in C#\n");
                view.printString("------------------------\n");

                // Declare variables and set to empty.
                // Use Nullable types (with ?) to match type of System.Console.ReadLine
                string? numInput1 = "";
                string? numInput2 = "";
                double result = 0;

                // Ask the user to type the first number.
                view.printString("Type a number, and then press Enter: ");
                numInput1 = view.getChar();
                

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1)) // check for valid input
                {
                    view.printString("This is not valid input. Please enter a numeric value: ");
                    numInput1 = view.getChar();
                    
                }
                model.Number1 = Convert.ToDouble(numInput1); // change the model number to the input


                // Ask the user to type the second number.
                view.printString("Type another number, and then press Enter: ");
                numInput2 = view.getChar();
                

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2)) // check for valid input
                {
                    view.printString("This is not valid input. Please enter a numeric value: ");
                    numInput2 = view.getChar();
                }
                model.Number2 = Convert.ToDouble(numInput2); // change the model number to the input


                view.printOptions(); // prints options

                string op = view.getChar();

                // Validate input is not null, and matches the pattern
                if (op == null || !Regex.IsMatch(op, "[a|s|m|d]"))
                {
                    view.printString("Error: Unrecognized input.");
                }
                else
                {
                    try
                    {
                        result = model.DoOperation(op);
                        if (double.IsNaN(result))
                        {
                            view.printString("This operation will result in a mathematical error.\n");
                        }
                        else view.printResult(result);
                    }
                    catch (Exception e)
                    {
                        view.printString("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                    }
                }
                view.printString("------------------------\n");
                view.printString("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (view.getChar() == "n") endApp = true;
            }
            return;
        }
    } // CalcController class

} // namespace