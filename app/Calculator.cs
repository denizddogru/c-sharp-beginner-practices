// Simple calculator program using switch statement
// First commit

using System;

namespace calculatorApp
{
    class switchCase
    {
        /* Possible error cases:

        -operation selected cannot be blank.
        -Division by 0 musnt generate an error.
        ? use try-catch blocks?
        -Im asking an integer as input and it needs input validation.
        // int.TryParse


        -User can type in any number of integers so the format should be a list
        -User should type between 1-4 to select an operation from the menu else it should give an error.
        -User must be only allowed to type in operators +,-,*,/


        */
        public static void Main(string[] args)
        {
            Console.WriteLine("Please select an operation from the menu.");
            Console.WriteLine("---------------");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication  ");
            Console.WriteLine("4. Division");
            Console.WriteLine("---------------");

            var action = Convert.ToInt32(Console.ReadLine());

            while(string.IsNullOrEmpty(action))
            {
                
                Console.WriteLine("Please enter a value between 1-4.");
                action = int.Parse(Console.ReadLine());
                //action = Console.ReadLine();
            }

            if (action == 1)
            {
                System.Console.Write(" Addition is selected");
            }
            else if(action == 2)
            {
                Console.WriteLine("Substraction is selected");
            }
              else if(action == 3)
            {
                Console.WriteLine("Multiplication is selected");
            
            }
              else if(action == 4)
            {
                Console.WriteLine("Division  is selected");
            }

            Console.WriteLine("Enter the 1st input.");
            int input_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            switch (action)
            {
                case 1:
                {
                    result = Addition(input_1, input_2);
                    break;
                }

                case 2:
                {
                    
                    result = Substraction(input_1, input_2);
                    break;
                }

                case 3:
                {
                    
                    result = Multiplication(input_1, input_2);
                    break;
                }

                case 4:
                {
                   
                    result = Division(input_1, input_2);
                    break;
                }

                default:
                    Console.WriteLine("Wrong action, try again.");
                    break;
            }

            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();
        }

        // Addition
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }

        //Substraction
        public static int Substraction(int input_1, int input_2)
        {
            int result = input_1 - input_2;
            return result;
        }

        //Multiplication
        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 * input_2;
            return result;
        }

        //Division
        public static int Division(int input_1, int input_2)
        {
            int result = input_1 / input_2;

            return result;
        }
        //     char op;
        //     double first,second, result;

        //     Console.Write("Enter first number: ");
        //     first = Convert.ToDouble(Console.ReadLine());

        //     Console.Write("Enter second: ");
        //     second = Convert.ToDouble(Console.ReadLine());

        //     Console.Write("Enter operator (+,-,*,/): ");
        //     /*
        //     Read is used to read only single character from the standard output device,
        //     while Console. ReadLine is used to read a line or string from the
        //     standard output device.Read is used to read only single character from the standard output device,

        //     while Console.
        //     ReadLine is used to read a line or string from the standard output device.
        //     */
        //     op = (char)Console.Read();


        // switch(op)
        // {
        //     case '+':
        //     result=first+second;
        //     Console.WriteLine("{0} + {1} = {2} ", first, second, result );
        //     break;

        //     case '-':
        //     result=first-second;
        //     Console.WriteLine("{0} - {1} = {2} ", first, second , result );
        //     break;

        //     case '*':
        //     result=first*second;
        //     Console.WriteLine("{0} * {1} = {2} ", first, second, result);
        //     break;

        //     case '/':
        //     result=first/second;
        //     Console.WriteLine("{0} / {1} = {2} ", first, second ,result);
        //     break;

        //     default:
        //     Console.WriteLine("Invalid operator.");
        //     break;
        // }
    }
}
