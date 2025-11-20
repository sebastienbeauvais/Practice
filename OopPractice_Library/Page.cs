using System;
namespace OopPractice_Library
{
    public class Page
    {
        //Pass a list of pages we can then filter on by book Id and active page
        private string pageNotFoundMessage = "Sorry, you dont have an active page for this book.";
        private int activePageNumber = -1;

        public Page() { }


        // Attributes for a page
        public int BookId { get; set; }
		public string Content { get; set; }
		public int Number { get; set; }
		public bool ActivePage { get; set; }

        // Methods
        public bool SetActivePage()
        {
            return true;
        }
        /*
        public IEnumerable<Page> GetAllPagesByBookId(int bookId)
        {
            try
            {
                var filteredBookPages = pageDataSet.Where(x => x.BookId == bookId);
                if (filteredBookPages != null)
                {
                    activePageNumber = GetActivePage(filteredBookPages);
                }
                filteredBookPages = filteredBookPages.Where(x => x.Number >= activePageNumber).OrderBy(x => x.Number);
                return filteredBookPages;
            }
            catch(Exception ex)
            {
                throw new Exception(pageNotFoundMessage, ex);
            }
            
        }

        private int GetActivePage(IEnumerable<Page> bookPages)
        {
            return bookPages.Where(x => x.ActivePage == true).Select(y => y.Number).First();
        }
        */
        
    }

	
}

