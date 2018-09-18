using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProgect
{
//    2) Утворити похідний від нього клас Цитрус, який має:
//- поле - вміст вітаміну С в грамах, 
//- конструктор з параметрами, 
//- властивість, 
//- перевизначені методи Input() та Print().

    public class Citrus: Fruit
    {
        public Citrus() { }
        public Citrus(string name, string color, int vitaminC):base(name, color)
        {
            this.VitaminC = vitaminC;
        }

        double vitaminC;
        public double VitaminC { get; set; }
        
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Write vitamin");
            VitaminC = int.Parse(Console.ReadLine());

            if (!double.TryParse(Console.ReadLine(), out vitaminC))
            {
                throw new FormatException("Vitamin C in gramm is not double value");
            }
        }
        public override void Input(string[] new_fruit)
        {
            Name = new_fruit[0];
            Color = new_fruit[1];
            vitaminC = Double.Parse(new_fruit[2]);

        }

        public override string Print()
        {            
            return base.Print()+", vitamin "+ VitaminC+"gram";           
        }
        public override string ToString()
        {
            return(Print());
        }

       

    }
}
