using BookApp.Core.Models;
namespace BookApp.App.Services
{
    internal class BookService
    {
        private Book[] Books = new Book[0];

        public void ShowBooks()
        {
            if(Books.Length == 0)
            {
                Console.WriteLine("Not available Books");
            }
            foreach(Book book in Books)
            {
                book.GetFullInfo();
            }
        }
        public void CreateBook()
        {
            Book NewBook= new Book();

            Console.WriteLine("add Name");
            NewBook.Name=Console.ReadLine();
            Console.WriteLine("add Price");
            NewBook.Price = double.Parse(Console.ReadLine());

            Array.Resize(ref Books, Books.Length+1);
            Books[Books.Length-1] = NewBook;
        }
    }
}
