using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class GenericClassOne<T>
    {
        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public void Display()
        {
            foreach (T item in items)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
