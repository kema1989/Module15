using System;
using System.Linq;
using System.Collections.Generic;

namespace M15U2_8
{
    class Program
    {
        public static List<int> list = new List<int>();
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Введите число:");

                    var number = Convert.ToInt32(Console.ReadLine());

                    list.Add(number);

                    Console.WriteLine($"Количество чиел в списке: {list.Count}\nСумма всех чисел: {list.Sum()}");
                    Console.WriteLine($"Наибольшее число - {list.Max()}, наименьшее - {list.Min()}, среднее - {list.Average()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Main(args);
            }
        }

        //static void Main(string[] args)
        //{
        //    while (true)
        //    {
        //        // Читаем введенный с консоли  текст
        //        var input = Console.ReadLine();

        //        // проверяем, число ли это
        //        var isInteger = Int32.TryParse(input, out int inputNum);

        //        // если не число - показываем ошибку
        //        if (!isInteger)
        //        {
        //            Console.WriteLine();
        //            Console.WriteLine("Вы ввели не число");
        //        }
        //        // если соответствует, запускаем обработчик
        //        else
        //        {
        //            // добавляем в список
        //            Numbers.Add(inputNum);

        //            // выводим все критерии
        //            Console.WriteLine("Число " + input + " добавлено в список.");
        //            Console.WriteLine($&quot; Всего в списке  { Numbers.Count}
        //            чисел");
        //            Console.WriteLine($"Сумма:  {Numbers.Sum()}");
        //            Console.WriteLine($"Наибольшее:  {Numbers.Max()}");
        //            Console.WriteLine($"Наименьшее:  {Numbers.Min()}");
        //            Console.WriteLine($"Среднее:  {Numbers.Average()}");

        //            Console.WriteLine();
        //        }
        //    }
        //}
    }
}
