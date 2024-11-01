using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nomeberi
{
    internal class CheckAndDelete
    {
        public void Execute()
        {
            Console.WriteLine("arraylist or list<t>? (a/l)");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "a":
                    ArrayList list = new ArrayList(new int[5] {20, 39, 12, 28, 93});
                    Console.Write("Before: ");
                    foreach (var item in list)
                    {
                        Console.Write(item + "\t");
                    }
                    Console.WriteLine("which remove");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if(list.Contains(input))
                    {
                        list.Remove(input);
                    }
                    else
                    {
                        Console.WriteLine("not found");
                    }
                    Console.Write("After: ");
                    foreach (var item in list)
                    {
                        Console.Write(item + "\t");
                    }
                    break;
                case "l":
                    List<int> list2 = new List<int>(new int[5] { 20, 39, 12, 28, 93 });
                    Console.Write("Before: ");
                    foreach (var item in list2)
                    {
                        Console.Write(item + "\t");
                    }
                    Console.WriteLine("which remove");
                    int input2 = Convert.ToInt32(Console.ReadLine());
                    if (list2.Contains(input2))
                    {
                        list2.Remove(input2);
                    }
                    else
                    {
                        Console.WriteLine("not found");
                    }
                    Console.Write("\nAfter: ");
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
