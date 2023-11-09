﻿using Microsoft.EntityFrameworkCore;
using SGM.Domain.Entities;
using SGM.Domain.ValueObjects;
using SGM.Infrastructure.Mapping;

namespace SGM.Infrastructure.Context
{
    public class SGMContext : DbContext
    {
        private readonly ConnectionStrings _connectionKeys;

        public SGMContext(ConnectionStrings keys)
        {
            _connectionKeys = keys;
        }

        public DbSet<Cliente> Cliente { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionKeys.SgmConnection);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMapping());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}