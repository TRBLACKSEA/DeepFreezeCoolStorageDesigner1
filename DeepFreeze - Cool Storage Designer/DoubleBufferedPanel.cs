using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepFreeze___Cool_Storage_Designer
{
	public class DoubleBufferedPanel : PictureBox
	{
		public DoubleBufferedPanel()
		{
			this.DoubleBuffered = true;
		}
	}
}
