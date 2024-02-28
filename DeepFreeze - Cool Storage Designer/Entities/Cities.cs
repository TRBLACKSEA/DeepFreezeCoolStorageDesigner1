using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFreeze___Cool_Storage_Designer.Entities
{
	public class Cities : IEntity
	{
		private int _ID;

		public int ID
		{
			get { return _ID; }
			set { _ID = value; }
		}
		private string _Name;

		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}
		private decimal _KuruTermometreSicaklik;

		public decimal KuruTermometreSicaklik
		{
			get { return _KuruTermometreSicaklik; }
			set { _KuruTermometreSicaklik = value; }
		}
		private decimal _YasTermometreSicaklik;

		public decimal YasTermometreSicaklik
		{
			get { return _YasTermometreSicaklik; }
			set { _YasTermometreSicaklik = value; }
		}

	}
}
