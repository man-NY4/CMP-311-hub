using System;
using System.Collections.Generic;
using System.Text;

namespace CalcRefactored
{
    class CalcModel
    {
        private double number1;
        private double number2;
        public CalcModel() // constructor to initialize numbers to 0
        {
            number1 = 0;
            number2 = 0;
        }

        public double Number1 // property for number1
        {
            get { return number1; }
            set { number1 = value; }
        }
        public double Number2 // property for number2
        {
            get { return number2; }
            set { number2 = value; }
        }

        public double DoOperation(string op) // do operation method
        {
            double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.
          
            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Number1 + Number2;
                    break;
                case "s":
                    result = Number1 - Number2;
                    break;
                case "m":
                    result = Number1 * Number2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (Number2 != 0)
                    {
                        result = Number1 / Number2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
    } // CalcModel class
} // namespace