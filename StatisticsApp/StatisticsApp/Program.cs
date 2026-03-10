using System;
using StatisticsApp;

class Program
{
    static void Main()
    {
        Console.WriteLine("Statistics application started successfully!");

        int[] numbers = { 10, 20, 30, 40, 50 };

        if (numbers.Length == 0)
        {
            Console.WriteLine("Error: no numbers were provided.");
            return;
        }

        Console.WriteLine("Numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
        int sum = StatisticsHelper.CalculateSum(numbers);
        Console.WriteLine("Sum: " + sum);
        
        double average = StatisticsHelper.CalculateAverage(numbers);
        Console.WriteLine("Average: " + average);
        
        int max = StatisticsHelper.CalculateMax(numbers);
        Console.WriteLine("Max: " + max);
    }
}