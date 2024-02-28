using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFreeze___Cool_Storage_Designer.Entities
{
	public class Material
	{
		private int _ID;

		public int ID
		{
			get { return _ID; }
			set { _ID = value; }
		}
		private string _MaterialName;

		public string MaterialName
		{
			get { return _MaterialName; }
			set { _MaterialName = value; }
		}

		private decimal _IsiIletimKatsayisi;

		public decimal IsiIletimKatsayisi
		{
			get { return _IsiIletimKatsayisi; }
			set { _IsiIletimKatsayisi = value; }
		}
		public string HatcBrushColor;

		public HatchStyle HatchBrushStyle = new HatchStyle();

		public string PenColorCode;

		private float _PenThickness;

		public float PenThickness
		{
			get { return _PenThickness; }
			set { _PenThickness = value; }
		}

	}
}
