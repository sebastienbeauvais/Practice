using System;
namespace OopPractice_Library.Data
{
	public class BookDataSet
	{
		private readonly PageDataSet _pageDataSet;
		public BookDataSet(PageDataSet pageDataSet)
		{
			_pageDataSet = pageDataSet;
		}
		public IEnumerable<Book> InitializeBookDataSet()
		{
			var bookPages = GetPagesForBooks();
			return CreateBookDataSet(bookPages);
		}
		private IEnumerable<Page> GetPagesForBooks()
		{
            return _pageDataSet.InitializePageDataset();
		}
		private IEnumerable<Book> CreateBookDataSet(IEnumerable<Page> pages)
		{
			IEnumerable<Book> bookDataSet = new List<Book>
			{
				new Book
				{
					Title = "The First Book In The Collection",
					Id = 1,
					IsActiveBook = false,
					Page = pages.Where(x => x.BookId == 1) // This sucks
				},
				new Book
				{
					Title = "The Lord of The Rings",
					Id = 2,
					IsActiveBook = false,
					Page = pages.Where(x => x.BookId == 2) // This sucks too
				}
			};
			return bookDataSet;
		}
	}
}

