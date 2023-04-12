using BookApp.App.Services;

BookService BookService = new BookService();

Console.WriteLine("0.Close App");
Console.WriteLine("1.Show Books");
Console.WriteLine("2.Create Book");

string RequestNumber=Console.ReadLine();

while (RequestNumber != "0")
{
    switch (RequestNumber)
    {
        case "1":
            BookService.ShowBooks();
            break;
        case "2":
            BookService.CreateBook();
            break;
        default:
            Console.WriteLine("Select valid option");
            break;
    }
    Console.WriteLine("0.Close App");
    Console.WriteLine("1.Show Books");
    Console.WriteLine("2.Create Book");

    RequestNumber = Console.ReadLine();
}