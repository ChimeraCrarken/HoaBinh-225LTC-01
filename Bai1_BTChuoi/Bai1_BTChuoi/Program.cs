class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập họ tên: ");
        string hoTen = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(hoTen))
        {
            Console.WriteLine("Lỗi: Chuỗi rỗng hoặc null!");
            return;
        }

        hoTen = hoTen.Trim();
        string[] words = hoTen.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        string ketQua = "";

        foreach (string word in words)
        {
            string chuanHoa =
                char.ToUpper(word[0]) + word.Substring(1).ToLower();
            ketQua += chuanHoa + " ";
        }

        Console.WriteLine("Họ tên chuẩn hoá: " + ketQua.Trim());
    }
}
