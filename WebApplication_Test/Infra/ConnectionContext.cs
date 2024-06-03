﻿using Microsoft.EntityFrameworkCore;
using WebApplication_Test.Model;

namespace WebApplication_Test.Infra
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
            "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=918691;");
    }
}
