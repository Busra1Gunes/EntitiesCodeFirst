using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;
using System.Data.Entity.Infrastructure;

namespace EntitiesCodeFirst.Entity
{
	public class Context:DbContext
	{
	
		public DbSet<Urunler> Urunlers { get; set; }
	}
}
