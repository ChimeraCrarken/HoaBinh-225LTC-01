using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        var result = numbers.Where(n => n > 5);

        Console.WriteLine("Số lớn hơn 5:");
        foreach (var n in result)
            Console.WriteLine(n);
    }
}