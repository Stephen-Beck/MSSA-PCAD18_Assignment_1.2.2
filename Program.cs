/*
Write a C# Sharp program to find the sum of first 10 natural numbers.

Expected Output :
    The first 10 natural number is :
    1 2 3 4 5 6 7 8 9 10
    The Sum is : 55
 */

namespace Assignment_1._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("This program will get the sum of the first 'n' natural numbers.");
            Console.Write("How many naturals numbers do you want to sum? ");
            int numberOfNaturalNumbers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The first " + numberOfNaturalNumbers + " natural numbers are:");
            for (int i = 1; i <= numberOfNaturalNumbers; i++)
            {
                Console.Write(i + " ");
                sum = sum + i;
            }
            Console.WriteLine("\nThe sum is: " + sum);
        }
    }
}
