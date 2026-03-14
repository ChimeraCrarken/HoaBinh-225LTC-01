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

        var result = students.OrderByDescending(s => s.Score);

        Console.WriteLine("Danh sách sinh viên được sắp xếp theo điểm số giảm dần:");
        foreach (var s in result)
            Console.WriteLine(s.Name + " " + s.Score);
    }
}