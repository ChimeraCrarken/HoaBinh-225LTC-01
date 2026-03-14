using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

        var result = numbers.Distinct();

        Console.WriteLine("Danh sách mới:");
        foreach (var n in result)
            Console.WriteLine(n);
    }
}