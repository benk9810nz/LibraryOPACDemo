using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LIbraryManagementSytem.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherID { get; set; }

        [Required, DataType(DataType.Text)]
        public string Name { get; set; }

        [Required, DataType(DataType.Text), Display(Name = "Address Line 1")]
        public string Address1 { get; set; }

        [Required, DataType(DataType.Text), Display(Name = "Address Line 2")]
        public string Address2 { get; set; }

        [Required, DataType(DataType.Text), Display(Name = "Suburb")]
        public string Suburb { get; set; }

        [Required, DataType(DataType.Text), Display(Name = "City")]
        public string City { get; set; }

        [Required, Display(Name = "Postcode")]
        public int Postcode { get; set; }

        [Required, Display(Name = "Phone Number"), DataType(DataType.PhoneNumber)]
        public decimal PhoneNumber { get; set; }

        [Required, DataType(DataType.Url), Display(Name = "Website URL")]
        public string WebsiteURL { get; set; }

        public string UpdatedDateTime { get; set; }
    }
}
