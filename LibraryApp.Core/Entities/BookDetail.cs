using LibraryApp.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core.Entities
{
    public class BookDetail
    {
        [Key]
        public int BookDetailId { get; set; }
        public int Stock { get; set; }
        public double Discount { get; set; }
        public bool StockState { get; set; }
        public Status Status { get; set; } = Status.Active;

        //..
        public Book Book { get; set; }
    }
}
