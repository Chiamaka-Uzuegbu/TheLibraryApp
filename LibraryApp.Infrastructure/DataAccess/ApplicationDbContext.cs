using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using LibraryApp.Core;
using LibraryApp.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LibraryApp.Infrastructure.DataAccess
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BookDetails> BookDetails { get; set; }
        public DbSet<CheckOutDetails> CheckOutDetails { get; set; }
    }
}
