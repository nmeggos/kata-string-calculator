using System;

namespace KataStringCalculator.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, welcome to Kata String Calculator.");
                Console.WriteLine("Enter a string of integers you would like to add.");
                Console.WriteLine("You can delimit the integers by a ','");

                string values = Console.ReadLine();
                
                Console.WriteLine($"You entered: {values}");

                var calculator = new StringCalculator();
                
                int sum = calculator.Add(values);
                
                Console.WriteLine($"The sum of the values you entered is: {sum}");

                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}