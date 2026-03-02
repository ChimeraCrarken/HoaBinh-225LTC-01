using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Main1
    {
        static void Main(string[] args)
        {
            // Generic với int
            GenericClassOne<int> intList = new GenericClassOne<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Display();

            // Generic với double
            GenericClassOne<double> doubleList = new GenericClassOne<double>();
            doubleList.Add(1.5);
            doubleList.Add(2.8);
            doubleList.Display();

            // Generic với string
            GenericClassOne<string> stringList = new GenericClassOne<string>();
            stringList.Add("Hello");
            stringList.Add("CSharp");
            stringList.Display();

            // Generic với object
            GenericClassOne<object> objectList = new GenericClassOne<object>();
            objectList.Add(100);
            objectList.Add("Hi");
            objectList.Add(3.14);
            objectList.Display();
        }

    }
}
