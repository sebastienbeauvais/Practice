using System;
namespace OopPractice_Library
{
	public class Book
	{
		//private readonly Page _page;
		private IEnumerable<Page> bookPagesFromActivePage = new List<Page>();

		public Book()
		{
		}

		// Attributes
		public int Id { get; set; }
		public string Title { get; set; }
		public IEnumerable<Page> Page { get; set; }
		public bool IsActiveBook { get; set; }

		// Methods
		/*
		public void SetActive()
		{
			IsActiveBook = true;
		}
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

