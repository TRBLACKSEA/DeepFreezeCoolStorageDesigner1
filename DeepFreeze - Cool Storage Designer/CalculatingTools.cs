using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepFreeze___Cool_Storage_Designer
{
	public static class CalculatingTools
	{
       public enum DIMENSIONFACTOR
		{
            Millimeter,
            Centimeter,
            Decimeter,
            Metre,
            Decameter,
            Hectometer,
            Kilometer
		}
		public static DIMENSIONFACTOR dimFactor;
		static float dimfactorValue;
		public static Control control;
        public static float DPI;

        public static float SelectDimFactor()
		{
			switch (dimFactor)
			{
				case DIMENSIONFACTOR.Millimeter:
					dimfactorValue = 1f;
					break;
				case DIMENSIONFACTOR.Centimeter:
					dimfactorValue = 10f;
					break;
				case DIMENSIONFACTOR.Decimeter:
					dimfactorValue = 100f;
					break;
				case DIMENSIONFACTOR.Metre:
					dimfactorValue = 1000f;
					break;
				case DIMENSIONFACTOR.Decameter:
					dimfactorValue = 10000f;
					break;
				case DIMENSIONFACTOR.Hectometer:
					dimfactorValue = 100000f;
					break;
				case DIMENSIONFACTOR.Kilometer:
					dimfactorValue = 1000000f;
					break;
				default:
					break;
			}
			return dimfactorValue;
		} 

        public static double CalculateArea(List<PointF> vertices)
        {
            int n = vertices.Count;
            double area = 0;
            int j = n - 1;

            for (int i = 0; i < n; i++)
            {
                area += (vertices[j].X + vertices[i].Y) * (vertices[j].X - vertices[i].Y);
                j = i;
            }

            return Math.Abs(area / 2);
        }
        public static PointF PointToCartesian(Point point,Control control)
		{
            return new PointF(PixelsToMillimeter(point.X), PixelsToMillimeter(control.Height - point.Y));
		}
        public static float PixelsToMillimeter(float pixel)
		{
			SelectDimFactor();
            return pixel * 25.4f / DPI * 2 * dimfactorValue;
		}
		public static float MillimetersToPixel(float millimeter)
		{
			SelectDimFactor();
			return millimeter * DPI / 25.4f;
		}
    }
}
