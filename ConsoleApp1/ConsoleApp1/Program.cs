using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using ConsoleApp1;

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
       

        static void Main(string[] args)
        {
            List<Fruit> fruitList = inputFormFile(Constant.READ_FROM_FILE);
            
            foreach(var s in fruitList)
            {
                if (s.Color.ToLower() == " yellow")
                {
                    //s.Print(Constant.SAVE_INTO_FILE);
                    s.Print();       
                }
            }
            foreach (var s in fruitList)
            {
                
                    s.Print(Constant.SAVE_INTO_FILE);
                    s.Print();
                
            }

            Console.WriteLine("Sorted list");

            fruitList.Sort();
            foreach (var s in fruitList)
            {
                s.Print(Constant.SAVE_SORTED_FRUITS_BY_NAME);
            }

            XmlSer(fruitList, Constant.SAVE_XML_FILE);
            XmlDeSer(Constant.SAVE_XML_FILE);
            Console.ReadLine();
        }

        public static void XmlSer(List<Fruit> fruits, string fileName)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Fruit>));
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Fruit>));
            using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fileStream, fruits);
            }
        }
        public static void XmlDeSer(string Patch)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Fruit>));
            using (FileStream fs = new FileStream(Patch, FileMode.OpenOrCreate))
            {
                List<Fruit> fl = (List<Fruit>)formatter.Deserialize(fs);

               Console.WriteLine("Object deserialize");
               foreach(var s in fl)
                {
                    Console.WriteLine(s);
                }
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
