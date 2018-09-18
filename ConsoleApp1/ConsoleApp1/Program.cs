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
        static void Main(string[] args)
        {
           
            List<Fruit> fruitList = inputFormFile();
           
            foreach (var s in fruitList)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
        public static List<Fruit> inputFormFile()
        {
            List<Fruit> list = new List<Fruit>();
            StreamReader streamReader = new StreamReader("Fruit.txt");
            string line;
            try
            {
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] cut = line.Split(',');
                    switch (cut.Length)
                    {
                        case 2:
                            Fruit f = new Fruit();
                            f.Input(cut);
                            list.Add(f);
                            break;
                        case 3:
                            Citrus f1 = new Citrus();
                            f1.Input(cut);
                            list.Add(f1);
                            break;

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                streamReader.Close();
            }
            return list;
        }

    }
}
