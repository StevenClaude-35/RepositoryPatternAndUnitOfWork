using Microsoft.EntityFrameworkCore;
using PocketBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocketBook.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }
    }
}
