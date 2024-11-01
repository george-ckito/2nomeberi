using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nomeberi
{
    internal class Out
    {
        public void Execute()
        {
            Console.WriteLine("arraylist or list<t>? (a/l)");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "a":
                    ArrayList list = new ArrayList();
                    list.Add(1);
                    list.Add(true);
                    list.Add("Hello");
                    list.Add(6.44d);
                    foreach (var item in list)
                    {
                        Console.Write(item + "\t");
                    }
                    break;
                case "l":
                    List<int> list2 = new List<int>();
                    list2.Add(1);
                    list2.Add(23);
                    list2.Add(13);
                    list2.Add(84);
                    foreach (var item in list2)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
