using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LIbraryManagementSytem.Models
{
    public class Retailer
    {
        [Key]
        public int RetailerID { get; set; }

        [Required, Display(Name = "Name"), DataType(DataType.Text)]
        public string Name { get; set; }

        [Required, Display(Name = "Address Line 1"), DataType(DataType.Text)]
        public string Address1 { get; set; }

        [Required, Display(Name = "Address Line 2")]
        public string Address2 { get; set; }

        [Required, Display(Name = "City"), DataType(DataType.Text)]
        public string City { get; set; }

        [Required, Display(Name = "Phone Number"), DataType(DataType.PhoneNumber)]
        public decimal PhoneNumber { get; set; }

        [Required, Display(Name = "Website URL"), DataType(DataType.Url)]
        public string WebsiteURL { get; set; }

        [Required, Display(Name = "Email Address"), DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        public string UpdatedDateTime { get; set; }
    }
}
