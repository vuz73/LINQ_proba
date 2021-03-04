using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_пробный
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>
            {
                "Первое",
                "Второе",
                "Третье",
                "Четвертое",
                "Пятое" 
            };

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

            #region MyRegion

            #endregion


        }
    }
}
