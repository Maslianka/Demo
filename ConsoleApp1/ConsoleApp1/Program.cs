using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProgect
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit();
            fruit.Input();
            Console.WriteLine(fruit.Print());

            Citrus citrus = new Citrus();
            citrus.Input();
            Console.WriteLine(citrus.Print());
            Console.ReadLine();
        }
    }
}
