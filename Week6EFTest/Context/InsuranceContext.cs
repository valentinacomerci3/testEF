using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6EFTest.Models;

namespace Week6EFTest.Context
{
    class InsuranceContext:DbContext
    {
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Client> Clients { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        {
            optBuilder.UseSqlServer(@"Persist Security Info = False; Integrated Security = True; 
                                    Initial Catalog = Insurance; Server = .\SQLEXPRESS");
        }

        public InsuranceContext() : base() { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration<Policy>(new PolicyConfiguration());
            builder.ApplyConfiguration<Client>(new ClientConfiguration());
        }
    }
}
