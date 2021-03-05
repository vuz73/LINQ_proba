using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_пробный
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LIST<string>
            List<string> list = new List<string>
            {
                "Первое",
                "Второе",
                "Третье",
                "Четвертое",
                "Пятое"
            };
            #endregion

            #region Выборка без LINQ
            //var newlist = new List<string>();
            //foreach (string line in list)
            //{
            //    if (line.Contains("П"))
            //    {
            //        newlist.Add(line);
            //    }
            //}
            //Console.WriteLine(string.Join(Environment.NewLine, newlist) + "\n");
            #endregion

            #region Выборка LINQ
            //var newlist = list.Where(x => x.Contains("Ч"));
            //Console.WriteLine(string.Join(Environment.NewLine, newlist) + "\n");
            #endregion

            #region Реверс списка
            //list.Reverse();
            //Console.WriteLine(string.Join(Environment.NewLine, list) + "\n");
            #endregion

            #region Реверс списка с пропуском
            //list.Reverse();
            //var newlist = list.Skip(2);
            //Console.WriteLine(string.Join(Environment.NewLine, newlist) + "\n");
            #endregion

            #region Количество элементов списка
            //var newlist = list.Count();
            //Console.WriteLine(string.Join(Environment.NewLine, newlist) + "\n"); 
            #endregion

            #region Нумерованный список LINQ
            //int i = 1;
            //var newlist = list.Select(x => $"{i++} {x}");
            //Console.WriteLine(string.Join(Environment.NewLine, newlist) + "\n");
            #endregion

            #region OrderBy сортировка
            //var newlist = list.OrderBy(x => x.Contains("1")).ThenBy(x => x).Skip(1);
            //Console.WriteLine(string.Join(Environment.NewLine, newlist) + "\n");
            #endregion

            #region GroupBy группировка
            //var newlist = list.GroupBy(g => g).Where(g => g.Count() > 1).Select(g => g.Key);
            //Console.WriteLine(string.Join(Environment.NewLine, newlist) + "\n");
            #endregion

            #region Удаление файлов с рабочего стола
            ///* Разная инициализация объекта  list */
            //List<string> list = new List<string>
            //{
            //    @"C:\Users\Вячеслав\Desktop\Новая папка\1.txt",
            //    @"C:\Users\Вячеслав\Desktop\Новая папка\2.txt",
            //    @"C:\Users\Вячеслав\Desktop\Новая папка\3.txt"
            //};
            ///* Разная инициализация объекта  list */
            //List<string> list = new List<string>();

            //list.Add(@"C:\Users\Вячеслав\Desktop\Новая папка\1.txt");
            //list.Add(@"C:\Users\Вячеслав\Desktop\Новая папка\2.txt");
            //list.Add(@"C:\Users\Вячеслав\Desktop\Новая папка\3.txt");

            //Parallel.ForEach(list, x =>
            //{
            //    File.Delete(x);
            //});
            #endregion

            #region Пинг нескольких сайтов одновременно
            //List<string> list = new List<string>
            //{
            //    "www.vk.com",
            //    "www.yandex.ru",
            //    "www.fb.com",
            //    "www.twitter.com",
            //    "www.instagram.com"
            //};

            //Console.WriteLine(new Ping().Send(list[0]).RoundtripTime.ToString());
            //Console.WriteLine(new Ping().Send(list[1]).RoundtripTime.ToString());
            //Console.WriteLine(new Ping().Send(list[2]).RoundtripTime.ToString());
            //Console.WriteLine(new Ping().Send(list[3]).RoundtripTime.ToString());
            //Console.WriteLine(new Ping().Send(list[4]).RoundtripTime.ToString());

            //var newlist = list.Where(x => new Ping().Send(x).RoundtripTime < 55);
            //Console.WriteLine(string.Join(Environment.NewLine, newlist));

            #endregion

        }
    }
}
