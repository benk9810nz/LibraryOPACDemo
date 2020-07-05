using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LIbraryManagementSytem.Models
{
    public class BookDetailsModel
    {
        public Book Books { get; set; }

        public IEnumerable<BookCopies> BookCopies { get; set; }
    }
}
