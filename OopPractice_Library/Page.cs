using System;
namespace OopPractice_Library
{
    public class Page
    {
        //Pass a list of pages we can then filter on by book Id and active page
        private const string pageNotFoundMessage = "Sorry, you dont have an active page for this book.";
        private int activePageNumber = -1;

        public Page() { }


        // Attributes for a page
        public int BookId { get; set; }
		public string Content { get; set; }
		public int Number { get; set; }
		public bool ActivePage { get; set; }

        // Methods
        
        public Page TurnPage(Book book)
        {
            var activePageNumber = GetActivePageNumber(book);
            if (activePageNumber < book.Page.Count()+1)
            {
                return GetNextPage(book, activePageNumber);
            }
            return book.Page.First();
        }
        private int GetActivePageNumber(Book book)
        {
            return book.Page.Where(x => x.ActivePage).Select(y => y.Number).First();
        }
        private Page GetNextPage(Book book, int activePageNumber)
        {
            var nextPage = book.Page.Where(x => x.Number == activePageNumber + 1).First();
            DeactivatePreviousPage(book, activePageNumber);
            return SetActivePage(nextPage);
        }
        private void DeactivatePreviousPage(Book book, int previousPageNumber)
        {
            var previousPage = book.Page.Where(x => x.ActivePage == true).First();
            previousPage.ActivePage = false;
            Console.WriteLine($"Page {previousPage.Number} is being turned");
        }
        private Page SetActivePage(Page page)
        {
            page.ActivePage = true;
            return page;
        }


    }

	
}

