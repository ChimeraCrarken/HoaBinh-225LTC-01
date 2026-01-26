Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Nhập câu: ");
string cau = Console.ReadLine();

if (string.IsNullOrWhiteSpace(cau))
{
    Console.WriteLine("Chuỗi null, không xử lý");
    return;
}

string[] words = cau.Split(' ', StringSplitOptions.RemoveEmptyEntries);

string longest = "";
foreach (string word in words)
{
    if (word.Length > longest.Length)
        longest = word;
}

Console.WriteLine("Từ dài nhất: " + longest);