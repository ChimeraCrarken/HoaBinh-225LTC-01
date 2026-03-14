using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<int> numbers = new List<int> { 8, 3, 5, 1, 7 };

        var result = numbers.OrderByDescending(n => n);

        Console.WriteLine("Danh sách giảm dần:");
        foreach (var n in result)
            Console.WriteLine(n);
    }
}