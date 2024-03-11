using System;
using System.Collections.Generic;
using System.Linq;

public class SecondLargestFinder
{
    public static int FindSecondLargest(List<int> numbers)
    {
        if (numbers == null || numbers.Count < 2)
        {
            return int.MinValue; // Return a default value indicating an error condition
        }

        // Find the maximum and second maximum numbers in the list
        int max = int.MinValue;
        int secondMax = int.MinValue;

        foreach (int num in numbers)
        {
            if (num > max)
            {
                secondMax = max;
                max = num;
            }
            else if (num > secondMax && num != max)
            {
                secondMax = num;
            }
        }

        if (secondMax == int.MinValue)
        {
            return int.MinValue; // Return a default value indicating an error condition
        }

        return secondMax;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter the numbers (enter 'done' to finish):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }

            int number;
            if (int.TryParse(input, out number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        int secondLargest = SecondLargestFinder.FindSecondLargest(numbers);

        if (secondLargest == int.MinValue)
        {
            Console.WriteLine("Error: The list must contain at least two distinct numbers.");
        }
        else
        {
            Console.WriteLine("The second largest number is: " + secondLargest);
        }
    }
}
