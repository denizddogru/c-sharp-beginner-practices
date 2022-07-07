// Simple calculator program using lists and less error prone


using System;

namespace calculatorApp
{
    class Operations
    {
        public static void Main(string[] args)
        {
          
            Console.WriteLine("----------CALC APP---------");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication  ");
            Console.WriteLine("4. Division");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Please select an operation from the menu.");
            var action = Console.ReadLine();

            // checks if the input is empty
            while (string.IsNullOrEmpty(action))
            {
                Console.WriteLine("Selection cannot be empty. Please enter a value between 1-4 .");
                action = Console.ReadLine();
            }

            while (true)
            {
                if (action == "1")
                {
                    Console.WriteLine($"Operation, {action} is selected!");
                    // list of numbers
                    List<int> numbers = new List<int>();
                    // input number(n), sum total(sum)
                    int n,sum = 0;

                    // This while loop waits for user input and converts that input to an integer
                    while (int.TryParse(Console.ReadLine(), out n))
                    {
                        // here we add the entered number to the sum
                        sum += n;
                        // and to the list to track how many we've added.
                        numbers.Add(n);
                    }
                    //Finally we make sure that we have more than 0 numbers and print to the console.
                    Console.WriteLine("Sum: " + (numbers.Count > 0 ? sum : 0));
                    break;
                }
                if (action == "2")
                {
                    Console.WriteLine($"Operation, {action} is selected!");

                    List<int> numbers = new List<int>();
                    int n,sum=0;

                    while(int.TryParse(Console.ReadLine(), out n))
                    {
                        sum = n ;
                        numbers.Add(n);
                    }
                    Console.WriteLine("Substraction: " +(numbers.Count > 0? sum : 0));
                    break;
                }
                if (action == "3")
                {
                    Console.WriteLine($"Operation, {action} is selected!");
                    Console.WriteLine("Enter integers to multiplicate. ");

                    List<int> numbers = new List<int>();
                    int n = 0, sum=1;

                    while(int.TryParse(Console.ReadLine(), out n))
                    {
                        sum *= n ;
                        numbers.Add(n);
                    }
                    Console.WriteLine("Multiplication: " +(numbers.Count > 0? sum : 0));
                    break;
                }
                if (action == "4")
                {
                    Console.WriteLine($"Operation, {action} is selected!");
                    Console.WriteLine("Enter integers to divide. ");

                    List<int> numbers = new List<int>();
                    int n = 0, sum=1;

                    while(int.TryParse(Console.ReadLine(), out n))
                    {
                        
                        numbers.Add(n);
                        sum /= n ;
                    }
                    Console.WriteLine("Division: " +(numbers.Count > 0? sum : 0));
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input! Enter a value between 1-4.");
                    action = Console.ReadLine();
                }
            }
        }
    }
}
