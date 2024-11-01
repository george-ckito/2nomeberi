using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nomeberi
{
    internal class SumOut
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
                    Console.WriteLine();
                    int sum = 0;
                    foreach(var item in list)
                    {
                        sum += (int)item;
                    }
                    Console.WriteLine("sum: " + sum);
                    break;
                case "l":
                    List<int> list2 = new List<int>(new int[5] { 20, 39, 12, 28, 93 });
                    foreach (var item in list2)
                    {
                        Console.Write(item + "\t");
                    }
                    Console.WriteLine();
                    int sum2 = 0;
                    foreach (var item in list2)
                    {
                        sum2 += item;
                    }
                    Console.WriteLine("sum: " + sum2);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
