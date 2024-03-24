// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 10, 15, 20, 25 };
        double average = CalculateAverage(numbers);
        Console.WriteLine("Średnia wynosi: " + average);
    }

    static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Tablica liczb nie może być pusta.");
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        return (double)sum / numbers.Length;
    }
}