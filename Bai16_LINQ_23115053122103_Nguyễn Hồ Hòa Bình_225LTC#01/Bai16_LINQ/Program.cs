using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        int sum = numbers.Sum();

        Console.WriteLine("Tổng các số trong danh sách:");
        Console.WriteLine(sum);
    }
}