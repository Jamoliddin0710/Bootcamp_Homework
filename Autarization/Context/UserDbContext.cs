using Autarization.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Dynamic;
using System.Reflection.Metadata;

namespace Autarization.Context;
    public class UserDbContext : DbContext
    {
       public DbSet<User> Users { get; set; }

        public UserDbContext(DbContextOptions options) : base(options) { }
  
}

