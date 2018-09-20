using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace DemoProgect
{
//    3) Утворити List фруктів і додати до нього 5 різних фруктів і цитрусів.
//- Видрукувати дані про ті фрукти, колір яких є 'жовтий'.
//- Посортувати список фруктів за назвою і результат вивести у файл
//- Передбачити перехоплення виняткових ситуацій
//- Сериалізувати-десериалізувати список у Xml форматі
//- Написати юніт-тести на методи класів

    class Program
    {
        const string readFileName = "Fruits.txt";
        const string saveFileName = "fruitsss.txt";
        const string saveSortesFruitsByName = "SortedFruits.txt";
        const string saveXMLFileName = "XmlSerialize.xml";

        static void Main(string[] args)
        {
           
            List<Fruit> fruitList = inputFormFile(readFileName);
            
            foreach(var s in fruitList)
            {
                if (s.Color.ToLower() == " yellow")
                {
                    s.Print(saveFileName);
                    s.Print();       
                }
            }

            Console.WriteLine("Sorted list");

            fruitList.Sort();
            foreach (var s in fruitList)
            {
                s.Print(saveSortesFruitsByName);
            }
            Console.ReadLine();
        }

        public static void XmlSer(List<Fruit> fruits, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Fruit>));
            using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fileStream, fruits);
            }
        }

        public static List<Fruit> inputFormFile(string patch)
        {
            List<Fruit> list = new List<Fruit>();
            using (StreamReader streamReader = new StreamReader(patch))
            {
                while (!streamReader.EndOfStream)
                {
                    string[] resultFruit = streamReader.ReadLine().Split(',');

                    switch (resultFruit.Length)
                    {
                        case 2:
                            Fruit fruit = new Fruit();
                            list.Add(fruit);
                            fruit.Input(resultFruit);
                            break;
                        case 3:
                            Fruit citrus = new Citrus();
                            list.Add(citrus);
                            citrus.Input(resultFruit);
                            break;
                    }                    
                }
            }
            return list;
        }
    }
}
