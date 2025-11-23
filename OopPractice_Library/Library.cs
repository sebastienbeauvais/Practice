using System;
using OopPractice_Library.Data;

namespace OopPractice_Library
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
		public void LaunchApp()
		{
			Console.WriteLine("Opening your library....");
			var bookCollection = InitializeLibraryBooks();

			TestLogic(bookCollection);
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
			var newPage = _book.TurnPage(activeBook);
			Console.WriteLine(newPage.Content.ToString());
			return newPage;
		}

        private void ClearCurrentActiveBook(Book currentActiveBook)
		{
			if (currentActiveBook != null)
			{
				_book.SetInActiveBook(currentActiveBook);
			}
		}
		private void TestLogic(IEnumerable<Book> libraryCollection)
		{
            //Testing setting an active book
            var bookId = 1;
            var bookId2 = 2;

            PrintLibraryToScreen(libraryCollection);

            SetActiveBook(libraryCollection, bookId);
            var activeBook = SetActiveBook(libraryCollection, bookId2);

            var activePage = OpenToActiveBookPage(activeBook);
            Console.WriteLine($"{activePage.Content.ToString()}");
            TurnPage(activeBook);
        }
	}
}

