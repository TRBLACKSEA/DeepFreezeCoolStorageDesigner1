using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFreeze___Cool_Storage_Designer.Entities
{
	public class WallLayer
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
		private decimal _Width;

		public decimal Width
		{
			get { return _Width; }
			set { _Width = value; }
		}
		private float _Height;

		public float Height
		{
			get { return _Height; }
			set { _Height = value; }
		}


		public Material WallMaterial = new Material();


	}
}
