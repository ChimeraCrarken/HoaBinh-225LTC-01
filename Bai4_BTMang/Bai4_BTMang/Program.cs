Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Nhập số phần tử: ");
if (int.TryParse(Console.ReadLine(), out int n))
{
    int[] mang = new int[n];
    int S = 0;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"N[{i + 1}] = ");
        mang[i] = int.Parse(Console.ReadLine());
        S += mang[i];
    }
    Console.WriteLine($"Tổng các phần tử trong mảng là: {S}");
}
else
{
    Console.WriteLine("Mãng chưa được khởi tạo.");
    return;
}

