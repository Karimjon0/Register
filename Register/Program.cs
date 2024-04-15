using Book.CRUD.Service;
using Register.Models;

IRegisterService bookService = new RegisterService();

bool isContinue = true;
do
{
        Console.WriteLine("WELCOME :)");
        Console.WriteLine("Log In          |          Sign Up");

        Console.Write("Enter command: ");
        string command = Console.ReadLine();
        if (command.Contains("1") is true)
        {
            Console.WriteLine("- - - - - Log In - - - - -");
            Registers bookInfo = new Registers();
            Console.Write("Enter username: ");
            bookInfo.UserName = Console.ReadLine();
            Console.Write("Enter password: ");
            bookInfo.Password = Console.ReadLine();

            string str = bookInfo.UserName;
            string str2 = str.Substring(-1, -10);

            if (str2 == "@gmail.com")
            {
            System.Console.WriteLine("Welcome");
            }
            else
            {
            Console.WriteLine("Invalid");
            }



            bookService.InsertName(bookInfo);

        //karimjon@gmail.com
        }
        if (command.Contains("2") is true)
        {
            Console.WriteLine("- - - - - Sign Up - - - - -");
            Registers bookInfo = new Registers();
            Console.Write("Enter username: ");
            bookInfo.UserName = Console.ReadLine();
            Console.Write("Enter password: ");
            bookInfo.Password = Console.ReadLine();
        }
}

