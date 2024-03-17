using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {

        string inputFile = "F.txt";
        if (!File.Exists(inputFile))
        {
            File.Create(inputFile).Dispose();
        }

        StreamWriter writer = new StreamWriter(inputFile);
        writer.WriteLine(31.0);
        writer.WriteLine(5.0);
        writer.WriteLine(10.0);
        writer.WriteLine(12.0);
        writer.WriteLine(15.0);
        writer.WriteLine(18.0);
        writer.WriteLine(20.0);
        writer.WriteLine(18.0);
        writer.WriteLine(15.0);
        writer.WriteLine(12.0);
        writer.WriteLine(10.0);
        writer.WriteLine(7.0);
        writer.Close();

        List<string> lines = File.ReadLines(inputFile).ToList();

        double sum = 0;
        int monthCount = 0;
        foreach (string line in lines)
        {
            double temp = Convert.ToDouble(line);
            sum += temp;
            monthCount++;
        }
        double annualAverage = sum / monthCount;

        string outputFile = "G.txt";
        if (!File.Exists(outputFile))
        {
            File.Create(outputFile).Dispose();
        }

        monthCount = 0;
        double deviation;
        foreach (string line in lines)
        {
            double temp = Convert.ToDouble(line);
            deviation = temp - annualAverage;
            File.AppendAllText(outputFile, $"Month {monthCount + 1}: {deviation}\n");
            monthCount++;
        }
    }
}