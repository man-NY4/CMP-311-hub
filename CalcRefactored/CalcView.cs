using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace CalcRefactored
{
    class CalcView
    {
    
        public void printString(String str) // prints a string
        {
            Console.Write(str);
        }

        public String getChar() // gets a character from user
        {
            return Console.ReadLine();
        }

        public void printResult(double result) // prints the result
        {
            Console.WriteLine("Your result: {0:0.##}\n", result);
        }

        public void printOptions() // prints the options
        {
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");
        }

    } // CalcView class
} // namespace 