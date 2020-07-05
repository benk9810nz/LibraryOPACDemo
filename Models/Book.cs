using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LIbraryManagementSytem.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        [DataType(DataType.Text), Required]
        public string Name { get; set; }

        [DataType(DataType.Text), Required, Display(Name = "Author")]
        public string AuthorName { get; set; }

        [DataType(DataType.Date), Required, Display(Name = "Publication Date")]
        public string PublicationDate { get; set; }

        [Required, Display(Name = "Publisher")]
        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; }

        [Required, Display(Name = "Genre")]
        public int GenreID { get; set; }
        public Genre Genre { get; set; }

        [Required, DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string UpdatedDateTime { get; set; }

    }
}