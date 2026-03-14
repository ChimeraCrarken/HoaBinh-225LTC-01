using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Random rd = new Random();

        List<string> tenList = new List<string>()
        { "An","Binh","Cuong","Dung","Huy","Lan","Mai","Nam","Phuong","Trang","Tuan","Vy" };

        List<string> khoaList = new List<string>()
        { "CNS", "KT", "QTKD" };

        List<SinhVien> dsSV = new List<SinhVien>();

        // Tạo 30 sinh viên random
        for (int i = 0; i < 30; i++)
        {
            SinhVien sv = new SinhVien(
                tenList[rd.Next(tenList.Count)],
                rd.Next(18, 26),
                khoaList[rd.Next(khoaList.Count)],
                Math.Round(rd.NextDouble() * 5 + 5, 2),
                rd.Next(1, 5)
            );

            dsSV.Add(sv);
        }

        // 
        Console.WriteLine("Danh sách sinh viên:");
        foreach (var sv in dsSV)
            Console.WriteLine(sv);

        // Câu 1
        Console.WriteLine("\n\nCâu 1:");

        var maxTuoi = dsSV.OrderBy(s => s.Tuoi).Last();
        var minTuoi = dsSV.OrderBy(s => s.Tuoi).First();

        Console.WriteLine("\nSinh viên lớn tuổi nhất:");
        Console.WriteLine(maxTuoi);

        Console.WriteLine("\nSinh viên nhỏ tuổi nhất");
        Console.WriteLine(minTuoi);


        // Câu 2
        Console.WriteLine("\n\nCâu 2:");
        Console.WriteLine("Danh sách sinh viên khoa CNS:\n");

        var svCNS = dsSV.Where(s => s.Khoa == "CNS");

        foreach (var sv in svCNS)
            Console.WriteLine(sv);


        // Câu 3
        Console.WriteLine("\n\nCâu 3:");
        Console.WriteLine("Top 10 sinh viên điểm cao nhất:\n");

        var top10 = dsSV
            .OrderByDescending(s => s.DiemTB)
            .Take(10);

        foreach (var sv in top10)
            Console.WriteLine(sv);


        // Câu 4
        Console.WriteLine("\n\nCâu 4:");
        Console.WriteLine("Danh sách sinh viên không phải năm cuối:\n");

        var svConLai = dsSV.Where(s => s.NamHoc != 4);

        foreach (var sv in svConLai)
            Console.WriteLine(sv);


        Console.ReadKey();
    }
}