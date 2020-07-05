using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LIbraryManagementSytem.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, DataType(DataType.Text), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, DataType(DataType.Text), Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, DataType(DataType.Text), Display(Name = "Address Line 1")]
        public string Address1 { get; set; }

        [DataType(DataType.Text), Display(Name = "Address Line 2")]
        public string Address2 { get; set; }

        [Required, DataType(DataType.Text)]
        public string City { get; set; }

        [Required, DataType(DataType.Date), Display(Name = "Date of Birth")]
        public DateTime Date { get; set; }

        public string RFIDTag { get; set; }
    }
}
