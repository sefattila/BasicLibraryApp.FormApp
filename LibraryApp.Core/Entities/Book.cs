using LibraryApp.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core.Entities
{
    public class Book : BaseEntity
    {
        public string BookName { get; set; }
        public double Fiyat { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int AuthorId { get; set; }
        public string CategoryId { get; set; }

        //..
        public Author Author { get; set; }
        public Category Category { get; set; }
        public BookDetail BookDetail { get; set; }
    }
}
