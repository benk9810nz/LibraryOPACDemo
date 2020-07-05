using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LIbraryManagementSytem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using LIbraryManagementSytem.Controllers;

namespace LIbraryManagementSytem.Data
{
    public class LIbraryManagementSytemContext : IdentityDbContext<ApplicationUser>
    {
        public LIbraryManagementSytemContext (DbContextOptions<LIbraryManagementSytemContext> options)
            : base(options)
        {
        }

        public DbSet<LIbraryManagementSytem.Models.Book> BOOKS { get; set; }

        public DbSet<LIbraryManagementSytem.Models.Genre> GENRES { get; set; }

        public DbSet<LIbraryManagementSytem.Models.BookCopies> BOOKCOPIES { get; set; }

        public DbSet<LIbraryManagementSytem.Models.Publisher> PUBLISHERS { get; set; }

        public DbSet<LIbraryManagementSytem.Models.Retailer> RETAILERS { get; set; }
    }
}
