using DeepFreeze___Cool_Storage_Designer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFreeze___Cool_Storage_Designer.Mapping
{
	public class WallLayerMap : EntityTypeConfiguration<WallLayer>
	{
		public WallLayerMap()
		{
			this.HasKey(q => q.ID);
			this.Property(q => q.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
			this.Property(q => q.Name).HasMaxLength(100);

			this.ToTable("WallLayerMap");
			this.Property(q => q.ID).HasColumnName("ID");
			this.Property(q => q.Name).HasColumnName("Name");
			this.Property(q => q.Width).HasColumnName("Width");
			this.Property(q => q.Height).HasColumnName("Height");
		}
	}
}
