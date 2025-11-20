using System;
namespace OopPractice_Library.Data
{
	public class Library
	{
		private BookDataSet _bookDataSet;

		public Library(BookDataSet bookDataSet)
		{
			_bookDataSet = bookDataSet;
		}
		public IEnumerable<Book> InitializeLibraryBooks()
		{
			return _bookDataSet.InitializeBookDataSet();
		}
		public void PrintLibraryToScreen(IEnumerable<Book> libraryBooks)
		{
			foreach(var book in libraryBooks)
			{
				Console.WriteLine($"{book.Title}: {book.Page.First().Content}");
			}
		}
	}
}

