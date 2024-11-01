using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nomeberi
{
    internal class Sort
    {
        public void Execute()
        {
            Console.WriteLine("arraylist or list<t>? (a/l)");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "a":
                    ArrayList list = new ArrayList(new int[5] { 20, 39, 12, 28, 93 });
                    foreach (var item in list)
                    {
                        Console.Write(item + "\t");
                    }
                    list.Sort();
                    Console.WriteLine();
                    foreach (var item in list)
                    {
                        Console.Write(item + "\t");
                    }
                    break;
                case "l":
                    List<int> list2 = new List<int>(new int[5] { 20, 39, 12, 28, 93 });
                    foreach (var item in list2)
                    {
                        Console.Write(item + "\t");
                    }
                    list2.Sort();
                    Console.WriteLine();
                    foreach (var item in list2)
                    {
                        Console.Write(item + "\t");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
