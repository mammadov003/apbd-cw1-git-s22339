using System;
using StatisticsApp;

class Program
{
    static void Main()
    {
        Console.WriteLine("Statistics application started.");

        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
        int sum = StatisticsHelper.CalculateSum(numbers);
        Console.WriteLine("Sum: " + sum);
    }
}