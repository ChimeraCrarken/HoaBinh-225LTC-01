using QuanLySanPham;

class Program
{
    static void Main(string[] args)
    {
        string name = "";
        int sum = 0;
        double tbprice = 0;

        //Bai 2: Tao list
        List<Product> products = new List<Product>();
        products.Add(new Product("P001", "LaptopA", 1500.00, "Electronics"));
        products.Add(new Product("P002", "Smartphone", 800.00, "Electronics"));
        products.Add(new Product("P003", "PC", 2000.00, "Electronics"));
        products.Add(new Product("P004", "Table", 300.00, "Furniture"));
        products.Add(new Product("P005", "Chair", 100.00, "Furniture"));
        products.Add(new Product("P006", "LaptopB", 2000.00, "Electronics"));


        //Bai 3: Truy van LINQ
        var over500 = products.Where(p => p.getPrice() > 500);
        var pricetd = products.OrderBy(p => p.getPrice());
        var cheapest = products.OrderBy(p => p.getPrice()).Take(3);

        Console.WriteLine("1. San pham > 500:");
        foreach (var product in over500)
        {
            Console.WriteLine($"{product.getName()} - {product.getPrice()}");
        }

        Console.WriteLine("\n2. San pham theo gia tang dan:");
        foreach (var product in pricetd)
        {
            Console.WriteLine($"{product.getName()} - {product.getPrice()}");
        }

        Console.WriteLine("\n3. 3 san pham re nhat:");
        foreach (var product in cheapest)
        {
            Console.WriteLine($"{product.getName()} - {product.getPrice()}");
        }

        Console.Write("\n4. Nhap ten san pham can tim: ");
        name = Console.ReadLine();
        var searchten = products.Where(p => p.getName().Contains(name, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Ket qua tim kiem:");
        foreach (var product in searchten)
        {
            Console.WriteLine($"{product.getName()} - {product.getPrice()}");
        }

        //Bai 4: Thong ke
        foreach (var product in products)
        {
            sum += (int)product.getPrice();
        }

        tbprice = Math.Round(sum*1.0 / products.Count, 2);

        Console.WriteLine($"\nTong gia tri san pham: {sum}");
        Console.WriteLine($"Gia tri trung binh san pham: {tbprice}");
    }
}