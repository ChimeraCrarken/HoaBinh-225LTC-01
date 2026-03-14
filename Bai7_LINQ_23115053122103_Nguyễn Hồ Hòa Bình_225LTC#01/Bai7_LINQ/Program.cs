using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 11 };

        bool result = numbers.Any(n => n > 10);

        Console.WriteLine("Danh sách có số lớn hơn 10?");
        Console.WriteLine(result);
    }
}