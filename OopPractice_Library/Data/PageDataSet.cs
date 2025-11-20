using System;
using System.Net;
using OopPractice_Library;

namespace OopPractice_Library.Data
{
	public class PageDataSet
	{
        public PageDataSet()
        {
        }
        // Initialize a list of page objects (normally this should be encapsulated in a separate class 'PageDatabase'
        public IEnumerable<Page> InitializePageDataset()
        {
            IEnumerable<Page> pageDataSet = new List<Page>
            {
                #region Book 1
                new Page
                {
                    BookId = 1,
                    Content = "Content for BookId 1 for page 1..",
                    Number = 1,
                    ActivePage = true

                },
                new Page
                {
                    BookId = 1,
                    Content = "Content for BookId 1 for page 2..",
                    Number = 2,
                    ActivePage = false

                },
                new Page
                {
                    BookId = 1,
                    Content = "Content for BookId 1 for page 3..",
                    Number = 3,
                    ActivePage = false

                },
                #endregion
                #region Book 2
                new Page
                {
                    BookId = 2,
                    Content = "Content for BookId 2 for page 1..",
                    Number = 1,
                    ActivePage = true

                },
                new Page
                {
                    BookId = 2,
                    Content = "Content for BookId 2 for page 2..",
                    Number = 2,
                    ActivePage = false

                },
                new Page
                {
                    BookId = 2,
                    Content = "Content for BookId 2 for page 3..",
                    Number = 3,
                    ActivePage = false

                }
                #endregion
            };
            return pageDataSet;
        }
	}
}

