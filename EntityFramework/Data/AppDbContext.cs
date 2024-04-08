using System;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data
{
	public class AppDbContext : DbContext
	{
        public DbSet<Setting> Settings{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=EntityFramework;User Id=sa;Password=123456Aa;");
        }
    }
}

