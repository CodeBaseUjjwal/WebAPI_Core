using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EntityModels
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Users> User { get; set; }
		public DbSet<UserImage> UserImage { get; set; }

		public ApplicationDbContext() : base()
		{

		}
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=StoreInventory;Trusted_Connection=True;");
			}
		}
	}
}
