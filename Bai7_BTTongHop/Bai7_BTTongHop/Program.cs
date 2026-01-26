Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.Write("Nhập họ tên: ");
string hoTen = Console.ReadLine();

if (string.IsNullOrEmpty(hoTen))
{
    Console.WriteLine("Chuỗi null");
    return;
}

string[] words = hoTen.Split(' ', StringSplitOptions.RemoveEmptyEntries);

if (words == null || words.Length == 0)
{
    Console.WriteLine("Mảng kết quả null");
    return;
}

foreach (string word in words)
{
    Console.WriteLine(word);
}