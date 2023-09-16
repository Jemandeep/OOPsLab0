using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Task 1: Creating Variables
        int LowNumber, HighNumber;

        // Prompt the user to enter the low number
        Console.Write("Enter the low number: ");
        LowNumber = int.Parse(Console.ReadLine());

        // Prompt the user to enter the high number
        Console.Write("Enter the high number: ");
        HighNumber = int.Parse(Console.ReadLine());

        // Calculate and print the difference
        int difference = HighNumber - LowNumber;
        Console.WriteLine($"The difference between {HighNumber} and {LowNumber} is: {difference}");

        // Task 2: Looping and Input Validation
        // Loop to ensure a positive low number
        while (true)
        {
            Console.Write("Enter a positive low number: ");
            LowNumber = int.Parse(Console.ReadLine());
            if (LowNumber > 0)
                break;
        }

        // Loop to ensure a high number greater than lowNumber
        while (true)
        {
            Console.Write($"Enter a high number greater than {LowNumber}: ");
            HighNumber = int.Parse(Console.ReadLine());
            if (HighNumber > LowNumber)
                break;
        }

        // Task 3: Using Arrays and File I/O
        int[] numbersArray = new int[HighNumber - LowNumber + 1];

        for (int i = 0; i < numbersArray.Length; i++)
        {
            numbersArray[i] = LowNumber + i;
        }

        // Write numbers to the file in reverse order
        Array.Reverse(numbersArray);
        File.WriteAllLines("numbers.txt", numbersArray.Select(n => n.ToString()));

        // Read the numbers from the file and calculate the sum
        int sum = numbersArray.Sum();
        Console.WriteLine($"Sum of numbers from file: {sum}");

        // Additional Tasks
        List<int> numbersList = numbersArray.ToList();
        double[] doubleArray = numbersArray.Select(n => (double)n).ToArray();

        Console.WriteLine("Prime numbers:");
        foreach (int num in numbersArray)
        {
            if (IsPrime(num))
            {
                Console.Write(num + " ");
            }
        }
    }

    // Method to check if a number is prime
    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}
