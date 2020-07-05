using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LIbraryManagementSytem.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }

        [Required, DataType(DataType.Text)]
        public string Name { get; set; }

        [Required, DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required, Display(Name = "Minimum Age")]
        public int MinimumAge { get; set; }

        public string UpdatedDateTime { get; set; }
    }
}
