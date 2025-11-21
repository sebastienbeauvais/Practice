using System;
namespace OopPractice_Library.Data
{
	public class Library
	{
		private BookDataSet _bookDataSet;
		private Book _book;

		public Library(BookDataSet bookDataSet, Book book)
		{
			_bookDataSet = bookDataSet;
			_book = book;
		}
		public IEnumerable<Book> InitializeLibraryBooks()
		{
			return _bookDataSet.InitializeBookDataSet();
		}
		public Book SetActiveBook(IEnumerable<Book> bookList, int BookId)
		{
			ClearCurrentActiveBook(bookList.Where(x => x.IsActiveBook == true).FirstOrDefault());
			var selectedBook = bookList.Where(x => x.Id == BookId).FirstOrDefault();
			if (selectedBook != null)
			{
                _book.SetActiveBook(selectedBook);
				return selectedBook;
            }
			return selectedBook;
		}
		public void PrintLibraryToScreen(IEnumerable<Book> libraryBooks)
		{
			foreach(var book in libraryBooks)
			{
				Console.WriteLine($"{book.Title}: {book.Page.First().Content}");
			}
		}
		public Page OpenToActiveBookPage(Book activeBook)
		{
			Console.WriteLine("Opening to active page...");
			return activeBook.Page.Where(x => x.ActivePage == true).First();
		}
		public Page TurnPage(Book activeBook)
		{
			return _book.TurnPage(activeBook);
		}

        private void ClearCurrentActiveBook(Book currentActiveBook)
		{
			if (currentActiveBook != null)
			{
				_book.SetInActiveBook(currentActiveBook);
			}
		}
	}
}

