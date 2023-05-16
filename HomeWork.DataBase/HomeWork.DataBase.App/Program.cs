using HomeWork.DataBase.App;

Application.SeedData();

Console.WriteLine("1. Get user by ID");
Console.WriteLine("2. Insert new user");

Console.Write("Enter your choice: ");
var choice = Console.ReadLine();

var application = new Application();

switch (choice)
{
    case "1":
        Console.Write("Enter user ID: ");
        var id = int.Parse(Console.ReadLine());
        
        application.GetUserById(id);
        break;
    case "2":
        Console.Write("Enter user name: ");
        var name = Console.ReadLine();
        
        Console.Write("Enter bank ID: ");
        var bankId = int.Parse(Console.ReadLine());
        
        application.InsertUser(name, bankId);
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();