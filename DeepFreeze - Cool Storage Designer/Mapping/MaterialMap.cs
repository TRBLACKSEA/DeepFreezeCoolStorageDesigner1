using DeepFreeze___Cool_Storage_Designer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFreeze___Cool_Storage_Designer.Mapping
{
	public class MaterialMap : EntityTypeConfiguration<Material>
	{
		public MaterialMap()
		{
			this.HasKey(q => q.ID);
			this.Property(q => q.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
			this.Property(q => q.MaterialName).HasMaxLength(50);
			this.Property(q => q.IsiIletimKatsayisi).HasPrecision(8, 2);


			this.ToTable("Materials");
			this.Property(q => q.ID).HasColumnName("ID");
			this.Property(q => q.MaterialName).HasColumnName("MaterialName");

		}
	}
}
