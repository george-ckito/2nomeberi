using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nomeberi
{
    internal class Check
    {
        public void Execute()
        {
            Console.WriteLine("arraylist or list<t>? (a/l)");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "a":
                    ArrayList list = new ArrayList(new int[5] { 20, 39, 12, 28, 93 });
                    Console.Write("Before: ");
                    foreach (var item in list)
                    {
                        Console.Write(item + "\t");
                    }
                    Console.WriteLine("which check");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (list.Contains(input))
                    {
                        Console.WriteLine("found");
                    }
                    else
                    {
                        Console.WriteLine("not found");
                    }
                    break;
                case "l":
                    List<int> list2 = new List<int>(new int[5] { 20, 39, 12, 28, 93 });
                    Console.Write("Before: ");
                    foreach (var item in list2)
                    {
                        Console.Write(item + "\t");
                    }
                    Console.WriteLine("which check");
                    int input2 = Convert.ToInt32(Console.ReadLine());
                    if (list2.Contains(input2))
                    {
                        Console.WriteLine("found");
                    }
                    else
                    {
                        Console.WriteLine("not found");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
