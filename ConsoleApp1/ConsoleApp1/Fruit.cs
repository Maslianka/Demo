using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace DemoProgect
{
    //        1) Утворити клас Фрукт, який містить:
    //- поля назва та колір,
    //- визначити конструктор з параметрами,
    //- віртуальні методи Input() та Print(), для зчитування даних з консолі та виведення даних на консоль, а також перевантажити варіанти введення-виведення з файлу.
    //- властивості для полів, 
    //- перевизначити метод ToString(). 
    [XmlInclude(typeof(Citrus))]
    public class Fruit : IComparable<Fruit>
    {      
        public Fruit(){}

        public Fruit(string name,string color)
        {
            this.Name = name;
            this.Color = color;
        }

        public string Name { get ; set ; }
        public string Color { get; set; }

        public int CompareTo(Fruit other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public virtual void Input()
        {
            Console.WriteLine("Write name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Write color: ");
            Color = Console.ReadLine();

        }

        public virtual void Input(string[] newFruit)
        {
            Name = newFruit[0];
            Color = newFruit[1];
        }


        public virtual void Print()
        {
            Console.WriteLine(this);
        }

        public virtual void Print(string pathToFile)
        {
            using (StreamWriter streamWriter = new StreamWriter(pathToFile,true, System.Text.Encoding.Default))
            {
                streamWriter.WriteLine($"{Name}:{Color}");
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, color: {Color}";
        }
    }
}
