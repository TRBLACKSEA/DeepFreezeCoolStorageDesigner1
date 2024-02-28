using DeepFreeze___Cool_Storage_Designer.Context;
using DeepFreeze___Cool_Storage_Designer.Tools;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepFreeze___Cool_Storage_Designer
{
	public partial class FrmStart : DevExpress.XtraEditors.XtraForm
	{
		public FrmStart()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			FrmNewProject frmNewProject = new FrmNewProject();
			frmNewProject.Show();
			this.Hide();
		}

        private void FrmStart_Load(object sender, EventArgs e)
        {
            using (var context  = new DeepFreezeContext())
            {
                if (!context.Database.Exists())
                {
					context.Database.Create();
					InitializeStarter.CreateCities(context);
				}
            }
        }
    }
}