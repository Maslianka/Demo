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
        

        public int VitaminC{ get; set; }
        
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Write vitamin");
            VitaminC = int.Parse(Console.ReadLine());
        }

        public override string Print()
        {            
            return base.Print()+" vitamin "+ VitaminC+"gram";           
        }
        public override string ToString()
        {
            return(Print());
        }

       

    }
}
