using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<int> numbers = new List<int> { 1, 2, 2, 2, 3, 4, 4 };

        var result = numbers
            .GroupBy(x => x)
            .OrderByDescending(g => g.Count())
            .First().Key;

        Console.WriteLine("Số xuất hiện nhiều nhất trong danh sách là:");
        Console.WriteLine(result);
    }
}