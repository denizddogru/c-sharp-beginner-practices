// Simple calculator program using switch statement
// First commit

using System;

namespace calculatorApp
{
    class switchCase
    {
        public static void Main(string[] args)
        {

            char op;
            double first,second, result;

            Console.Write("Enter first number: ");
            first = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second: ");
            second = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+,-,*,/): ");
            /*
            Read is used to read only single character from the standard output device,
            while Console. ReadLine is used to read a line or string from the 
            standard output device.Read is used to read only single character from the standard output device,

            while Console.
            ReadLine is used to read a line or string from the standard output device.
            */
            op = (char)Console.Read();


        switch(op)
        {
            case '+':
            result=first+second;
            Console.WriteLine("{0} + {1} = {2} ", first, second, result );
            break;

            case '-':
            result=first-second;
            Console.WriteLine("{0} - {1} = {2} ", first, second , result );
            break;  

            case '*':
            result=first*second;
            Console.WriteLine("{0} * {1} = {2} ", first, second, result);
            break;

            case '/':
            result=first/second;
            Console.WriteLine("{0} / {1} = {2} ", first, second ,result);
            break;

            default:
            Console.WriteLine("Invalid operator.");
            break;
        } 


        }
    }
}