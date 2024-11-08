using CSharpEgitimKampi301.EntityLayer.Concrete;
using CSharpEgitimKampi301.EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccesLayer.Context
{
	public class CampContext:DbContext
	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Admin> Admins { get; set; }
	}
}
