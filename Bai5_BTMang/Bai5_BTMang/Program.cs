Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Nhập số phần tử: ");
if (int.TryParse(Console.ReadLine(), out int n))
{
    int[] mang = new int[n];

    if (mang.Length == 0)
        return;

    for (int i = 0; i < n; i++)
    {
        Console.Write($"N[{i + 1}] = ");
        mang[i] = int.Parse(Console.ReadLine());
    }

    int max = mang[0];
    for (int i = 1; i < mang.Length; i++)
    {
        if (mang[i] > max)
            max = mang[i];
    }

    Console.WriteLine("Giá trị lớn nhất: " + max);
}
else
{
}