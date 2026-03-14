using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        var result = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Số chẵn:");
        foreach (var n in result)
            Console.WriteLine(n);
    }
}