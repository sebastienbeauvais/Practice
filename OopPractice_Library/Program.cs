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

            Library library = new Library(bookDataSet);
            var libraryBooks = library.InitializeLibraryBooks();
            library.PrintLibraryToScreen(libraryBooks);

            Console.WriteLine("Closing program...");

        }

        
    }

}
