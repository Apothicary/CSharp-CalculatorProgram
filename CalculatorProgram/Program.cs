namespace CalculatorProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do {
                // Declare variables to store user input and result
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                // Display a simple calculator header
                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                // Prompt the user to enter two numbers
                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                // Display available operations
                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");

                // Use a switch statement to perform the selected operation
                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        // Check if num2 is not zero before performing division
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero. Please enter another divisor.");
                        }
                        break;

                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }

                // Ask the user if they want to continue
                Console.WriteLine("Would you like to continue? (Yes/No)");
            } while (Console.ReadLine().ToUpper() == "YES");

            // Thank the user for using the program
            Console.WriteLine("Thank you for using this program");
            Console.ReadKey();
        }
    }
}