using Book.CRUD.Service;
using Register.Models;

IRegisterService bookService = new RegisterService();

bool isContinue = true;
do
{
    Console.WriteLine("Log In          |          Sign Up");
    
    Console.Write("Enter command: ");
    string command = Console.ReadLine();
    if (command.Contains("1") is true)
    {
        Console.WriteLine("- - - - - Log In - - - - -");
        Registers bookInfo = new Registers();
        Console.Write("Enter first name: ");
        bookInfo.FirstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        bookInfo.LastName = Console.ReadLine();
        Console.Write("Enter password: ");
        bookInfo.Password = Console.ReadLine();

        bookService.InsertName(bookInfo);
    }
    if (command.Contains("2") is true)
    {
        Console.WriteLine("- - - - - Sign Up - - - - -");
        Registers bookInfo = new Registers();
        Console.Write("Enter first name: ");
        bookInfo.FirstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        bookInfo.LastName = Console.ReadLine();
        Console.Write("Enter password: ");
        bookInfo.Password = Console.ReadLine();

        bookService.InsertName(bookInfo);
    Console.WriteLine("Will you continue?");
    string isCommand = Console.ReadLine();
    if (isCommand.ToLower().Contains("no") is true || isCommand.ToLower().Contains("yuq") is true)
    {
        isContinue = false;
    }
} while (isContinue is true);
    }
