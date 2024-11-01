using _2nomeberi;

Console.WriteLine("choose program");
Console.WriteLine("1 - Out");
Console.WriteLine("2 - CheckAndDelete");
Console.WriteLine("3 - Check");
Console.WriteLine("4 - SumOut");
Console.WriteLine("5 - Sort");

string choice = Console.ReadLine();
switch (choice)
{
    case "1":
        new Out().Execute();
        break;
    case "2":
        new CheckAndDelete().Execute();
        break;
    case "3":
        new Check().Execute();
        break;
    case "4":
        new SumOut().Execute();
        break;
    case "5":
        new _2nomeberi.Sort().Execute();
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}