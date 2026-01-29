using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface IBorrowable
    {
        public void Borrow();
        public void ReturnBook();
    }
}
