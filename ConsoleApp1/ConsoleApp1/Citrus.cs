using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DemoProgect
{
//    2) Утворити похідний від нього клас Цитрус, який має:
//- поле - вміст вітаміну С в грамах, 
//- конструктор з параметрами, 
//- властивість, 
//- перевизначені методи Input() та Print().
    [Serializable]
    public class Citrus: Fruit
    {
        public Citrus() { }
        public Citrus(string name, string color, double vitaminC):base(name, color)
        {
            this.vitaminC = vitaminC;
        }

        double vitaminC;
        public double VitaminC
        {
            get
            {
                return vitaminC;
            }
            set
            {
                vitaminC = value;
            }
        }
        
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Write vitamin");
            VitaminC = Convert.ToDouble(Console.ReadLine());
           
        }
        public override void Input(string[] newFruit)
        {
            Name = newFruit[0];
            Color = newFruit[1];            
            try
            {
                VitaminC = Convert.ToDouble(newFruit[2].Replace(".", ","));
            }
            catch
            {
                throw new Exception("Wrong data");
            }

        }

        public override void Print(string pathToFile)
        {
            using (StreamWriter streamWriter = new StreamWriter(pathToFile, true, System.Text.Encoding.Default))
            {
                streamWriter.WriteLine($"{Name}: {Color}: {VitaminC}");
            }
           
        }

        public override void Print()
        {
            Console.WriteLine(this);           
        }

       
        public override string ToString()
        {
            return(base.ToString() + ", vitamin " + VitaminC + " gram");
        }

       

    }
}
