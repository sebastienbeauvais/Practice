using System;
namespace OopPractice_Library
{
	public class Book
	{
		private Page _page;
		private IEnumerable<Page> bookPagesFromActivePage = new List<Page>();

		public Book(Page page)
		{
			page = _page;
		}

		// Attributes
		public int Id { get; set; }
		public string Title { get; set; }
		public IEnumerable<Page> Page { get; set; }
		public bool IsActiveBook { get; set; }

		// Methods
		public void SetActiveBook(Book selectedBook)
		{
			selectedBook.IsActiveBook = true;
			Console.WriteLine($"Book {selectedBook.Title} is now set to the active book");
		}
		public void SetInActiveBook(Book currentActiveBook)
		{
			currentActiveBook.IsActiveBook = false;
			Console.WriteLine($"Book {currentActiveBook.Title} is no longer set to the active book");
		}
		public Page TurnPage(Book activeBook)
		{
			return _page.TurnPage(activeBook);
		}
		/*
		public IEnumerable<Page> GetBookPages(int bookId)
		{
            return bookPagesFromActivePage = _page.GetAllPagesByBookId(Id);
        }

		private string OpenToActivePage()
		{
			return bookPagesFromActivePage.First().Content;
		}
		private IEnumerable<Book> bookDataSet = new List<Book>
		{
			new Book()
			{
				Id = 1,
				Title = "The first book of the library",
				Page = new List<Page>(),
				IsActiveBook = true
			},

		};*/
	}
}

