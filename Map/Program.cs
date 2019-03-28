using System;

namespace Map
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dict<int, string>();
            dict.Add(new Item<int, string>(1, "Один"));
            dict.Add(new Item<int, string>(1, "Один"));
            dict.Add(new Item<int, string>(2, "Два"));
            dict.Add(new Item<int, string>(3, "Три"));
            dict.Add(new Item<int, string>(4, "Четыре"));
            dict.Add(new Item<int, string>(5, "Пять"));
            dict.Add(new Item<int, string>(101, "Сто один"));


            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(dict.Search(7) ?? "Не найдено");
            Console.WriteLine(dict.Search(3) ?? "Не найдено");
            Console.WriteLine(dict.Search(101) ?? "Не найдено");

            dict.Remove(7);
            dict.Remove(3);
            dict.Remove(1);
            dict.Remove(101);


            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.ReadLine();




            var easyMap = new EasyMap<int, string>();
            easyMap.Add(new Item<int, string>(1, "Один"));
            easyMap.Add(new Item<int, string>(2, "Два"));
            easyMap.Add(new Item<int, string>(3, "Три"));
            easyMap.Add(new Item<int, string>(4, "Четыре"));
            easyMap.Add(new Item<int, string>(5, "Пять"));

            foreach(var item in easyMap)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(easyMap.Search(7) ?? "Не найдено");
            Console.WriteLine(easyMap.Search(3) ?? "Не найдено");

            easyMap.Remove(3);
            easyMap.Remove(1);

            foreach (var item in easyMap)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
