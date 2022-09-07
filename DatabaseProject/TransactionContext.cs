using DatabaseProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseProject
{
    public class TransactionContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        public TransactionContext(DbContextOptions<TransactionContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
