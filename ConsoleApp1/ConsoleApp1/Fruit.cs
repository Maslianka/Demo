using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DemoProgect
{
    //        1) Утворити клас Фрукт, який містить:
    //- поля назва та колір,
    //- визначити конструктор з параметрами,
    //- віртуальні методи Input() та Print(), для зчитування даних з консолі та виведення даних на консоль, а також перевантажити варіанти введення-виведення з файлу.
    //- властивості для полів, 
    //- перевизначити метод ToString(). 
    public class Fruit:IThink
    {      
        public Fruit(){}

        public Fruit(string name,string color)
        {
            this.Name = name;
            this.Color = color;
        }

        public string Name { get ; set ; }
        public string Color { get; set; }

        public virtual void Input()
        {
            Console.WriteLine("Write name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Write color: ");
            Color = Console.ReadLine();
        }

        public virtual void Input(string docAddress)
        {
            using (StreamReader streamReader = new StreamReader(docAddress))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    // Do something with the line.
                    string[] parts = line.Split(',');
                }
                streamReader.Close();
            }
        }

        public virtual string Print()
        {
           return($"Name :{Name}, color: {Color}");
        }

        public override string ToString()
        {
            return Print();
        }
    }
}
