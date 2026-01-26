class Program
    {
        static void Main(string[] args)
        {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập chuỗi: ");
            string input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("Số từ: 0");
                return;
            }

            input = input.Trim();
            if (input == "")
            {
                Console.WriteLine("Số từ: 0");
                return;
            }

            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int count = words.Length;

            Console.WriteLine("Số từ: " + count);
        }
    }
