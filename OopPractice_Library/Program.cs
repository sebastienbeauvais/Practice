using OopPractice_Library;
using OopPractice_Library.Data;

namespace OopPractice_Library
{
    public class Program
    {
        public Program()
        {
            
        }
        public static void Main()
        {
            #region Greetings and explaination or program
            #endregion
            PageDataSet pageDataSet = new PageDataSet();

            BookDataSet bookDataSet = new BookDataSet(pageDataSet);
            Page page = new Page();
            Book book = new Book(page);

            Library library = new Library(bookDataSet, book);
            var libraryBooks = library.InitializeLibraryBooks();
            
            //Testing setting an active book
            var bookId = 1;
            var bookId2 = 2; 
            
            library.PrintLibraryToScreen(libraryBooks);

            library.SetActiveBook(libraryBooks, bookId);
            var activeBook = library.SetActiveBook(libraryBooks, bookId2);

            library.OpenToActiveBookPage(activeBook);
            library.TurnPage(activeBook);

            Console.WriteLine("Closing program...");

        }

        
    }

}
