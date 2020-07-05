using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LIbraryManagementSytem.Models
{
    public class BookCopies
    {
        [Key]
        public int BookCopiesID { get; set; }

        [Required, Display(Name = "Book Barcode")]
        public decimal BookBarcode { get; set; }

        [Required, Display(Name = "Book")]
        public int BookID { get; set; }
        public Book Book { get; set; }

        [Required, Display(Name = "Retailer")]
        public int RetailerID { get; set; }
        public Retailer Retailer { get; set; }

        [Required, Display(Name = "Purchase Price")]
        public decimal PurchasePrice { get; set; }

        [Required, Display(Name = "RFID Tag Value")]
        public string RFID { get; set; }

        public string UpdatedDateTime { get; set; }
    }
}
