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



            //Array.Reverse(array);
            //var newlist = list.Count();
            //newlist = newlist.Skip(1);

            //var newlist = new List<string>();
            //foreach (string line in list)
            //{
            //    if (line.Contains("П"))
            //    {
            //        newlist.Add(line);
            //    }
            //}

            var newlist = list.Where(x => !x.Contains("П"));

            Console.WriteLine(string.Join(Environment.NewLine, newlist) + "\n");
        }
    }
}
