using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFreeze___Cool_Storage_Designer.Entities
{
	public class HatchBrushTypes
	{
		private int _ID;

		public int ID
		{
			get { return _ID; }
			set { _ID = value; }
		}
		private HatchStyle _DrawingHatchBrushType;

		public HatchStyle DrawingHatchBrushType
		{
			get { return _DrawingHatchBrushType; }
			set { _DrawingHatchBrushType = value; }
		}

	}
}
