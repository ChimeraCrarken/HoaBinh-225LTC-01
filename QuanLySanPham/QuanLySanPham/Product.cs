using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    //Bai 1: Tao class Product
    public class Product
    {
        string id;
        string name;
        double price;
        string category;

        public Product(string id, string name, double price, string category)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.category = category;
        }

        public string getId() { return id; }
        public string getName() { return name; }
        public double getPrice() { return price; }
        public string getCategory() { return category; }
    }
}
