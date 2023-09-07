using LibraryApp.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        //..
        public ICollection<Book> Books { get; set; }

    }
}
