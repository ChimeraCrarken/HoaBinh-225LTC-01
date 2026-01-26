Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
string[] mang = { "C#", null, "", "Java", "Python", null };

int count = 0;
foreach (string s in mang)
{
    if (!string.IsNullOrEmpty(s))
        count++;
}

Console.WriteLine("Số chuỗi khác null và khác rỗng: " + count);