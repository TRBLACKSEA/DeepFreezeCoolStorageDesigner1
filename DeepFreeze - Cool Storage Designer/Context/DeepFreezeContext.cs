using DeepFreeze___Cool_Storage_Designer.Entities;
using DeepFreeze___Cool_Storage_Designer.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFreeze___Cool_Storage_Designer.Context
{
	public class DeepFreezeContext : DbContext
	{
		public DeepFreezeContext() : base("DeepFreezeContext")
		{

		}
		public DbSet<Cities> Cities { get; set; }
		//public DbSet<Material> Materials { get; set; }
		//public DbSet<WallLayer> WallLayers { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new CitiesMap());
			//modelBuilder.Configurations.Add(new MaterialMap());
			//modelBuilder.Configurations.Add(new WallLayerMap());
		}
	}
}
