using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<Student> students = new List<Student>()
        {
            new Student{Id=1,Name="An",Score=8},
            new Student{Id=2,Name="Binh",Score=6},
            new Student{Id=3,Name="Chi",Score=9},
            new Student{Id=4,Name="Dung",Score=7}
        };

        var names = students.Select(s => s.Name);

        Console.WriteLine("Danh sách tên sinh viên:");
        foreach (var n in names)
            Console.WriteLine(n);
    }
}