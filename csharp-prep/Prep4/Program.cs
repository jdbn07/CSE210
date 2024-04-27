using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished:");

        while (true)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                break;
            }
            numbers.Add(num);
        }
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine("The sum is: " + sum);
        double prom = sum / (double)numbers.Count;
        Console.WriteLine("The average is: " + prom);

        int max = numbers[0];
        foreach (int nu in numbers)
        {
            if (nu > max)
            {
                max = nu;
            }
        }
        Console.WriteLine("The max is: " + max);
    }
}