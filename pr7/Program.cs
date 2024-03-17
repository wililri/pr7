using System;
using System.IO;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];

        Console.WriteLine("Введите 10 чисел:");
        for (int i = 0; i < 10; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        File.WriteAllLines("numbers.txt", Array.ConvertAll(numbers, x => x.ToString()));

        string[] lines = File.ReadAllLines("numbers.txt");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        int lastNumber = numbers[numbers.Length - 1] + 1;
        File.AppendAllText("numbers.txt", Environment.NewLine + lastNumber.ToString());

        Console.WriteLine("Последнее число в массиве: " + lastNumber);
    }
}
