using Desafio1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio1.Contexts
{
    public class PContext : DbContext

    {

        public PContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Users> Users { get; set; } = null!;

        public DbSet<Posts> Posts { get; set; } = null!;

        public DbSet<Comments> Comments { get; set; } = null!;
    }
}
