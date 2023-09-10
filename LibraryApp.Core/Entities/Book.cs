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
        public int CategoryId { get; set; }
        public int Stock { get; set; }
        public double Discount { get; set; }
        public bool StockState { get; set; }

        //..
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
    }
}
