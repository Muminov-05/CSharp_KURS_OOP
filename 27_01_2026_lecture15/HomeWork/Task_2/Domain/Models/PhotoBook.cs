using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{

        public class PhotoBook
        {
            private int numPages;

            public PhotoBook()
            {
                numPages = 16;
            }

            public PhotoBook(int pages)
            {
                numPages = pages;
            }

            public int GetNumberPages()
            {
                return numPages;
            }
        }
}
