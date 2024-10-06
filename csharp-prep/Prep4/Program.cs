using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input;

         Console.WriteLine("Enter a list of numbers, type 0 when finished.");

         while (true)
         {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                break;
            }
             numbers.Add(input);
         }
    if (numbers.Count > 0)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            double average = (double)sum / numbers.Count;

            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                   max = number;
                }
            }

            int? smallestPositive = null;
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    if (smallestPositive == null || number < smallestPositive)
                    {
                        smallestPositive = number;
                    }
                }
            }

            numbers.Sort();

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");

            if (smallestPositive.HasValue)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive.Value}");
            }
            else
            {
                Console.WriteLine("There are no positive numbers in the list.");
            }

            Console.WriteLine("The sorted list is:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }  
         else
        { 
            Console.WriteLine("No numbers were entered.");
        }
   }
}