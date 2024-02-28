using DeepFreeze___Cool_Storage_Designer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFreeze___Cool_Storage_Designer.Mapping
{
	public class CitiesMap : EntityTypeConfiguration<Cities>
	{
		public CitiesMap()
		{
			this.HasKey(q => q.ID);
			this.Property(q => q.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
			this.Property(q => q.Name).HasMaxLength(50);
			this.Property(q => q.KuruTermometreSicaklik).HasPrecision(5, 2);
			this.Property(q => q.YasTermometreSicaklik).HasPrecision(5, 2);

			this.ToTable("Cities");
			this.Property(q => q.ID).HasColumnName("ID");
			this.Property(q => q.Name).HasColumnName("Name");
			this.Property(q => q.KuruTermometreSicaklik).HasColumnName("KuruTermometreSicaklik");
			this.Property(q => q.YasTermometreSicaklik).HasColumnName("YasTermometreSicaklik");
		}
	}
}
