Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Nhập số phần tử: ");
if (int.TryParse(Console.ReadLine(), out int n))
{
    int[] mang = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"N[{i + 1}] = ");
        mang[i] = int.Parse(Console.ReadLine());
    }

    int count = 0;
    foreach (int x in mang)
    {
        if (x % 2 == 0)
            count++;
    }

    Console.WriteLine("Số phần tử chẵn: " + count);
}
else
{
    Console.WriteLine("Số phần tử chẵn: 0");
}