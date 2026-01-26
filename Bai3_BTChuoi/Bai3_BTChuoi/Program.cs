    class Program
    {
        static void Main(string[] args)
        {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập chuỗi: ");
            string input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("Chuỗi không đối xứng");
                return;
            }

            // Xoá khoảng trắng
            string s = "";
            foreach (char c in input)
            {
                if (c != ' ')
                    s += c;
            }

            int left = 0;
            int right = s.Length - 1;
            bool doiXung = true;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    doiXung = false;
                    break;
                }
                left++;
                right--;
            }

            if (doiXung)
                Console.WriteLine("Chuỗi đối xứng");
            else
                Console.WriteLine("Chuỗi không đối xứng");
        }
    }
