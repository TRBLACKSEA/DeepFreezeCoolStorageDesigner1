using DeepFreeze___Cool_Storage_Designer.Context;
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
	public partial class FrmNewProject : DevExpress.XtraEditors.XtraForm
	{
		DeepFreezeContext context = new DeepFreezeContext();
		public static string ProjectName, ProjectPath, WarehouseLocation;
		string defaultpath = Application.StartupPath + @"\Projects\";
		private void FrmNewProject_FormClosed(object sender, FormClosedEventArgs e)
		{

		}

		private void FrmNewProject_FormClosing(object sender, FormClosingEventArgs e)
		{
			FrmStart frmStart = (FrmStart)Application.OpenForms["FrmStart"];
			frmStart.Show();
		}

		private void FrmNewProject_Load(object sender, EventArgs e)
		{
			txtProjectPath.Text = defaultpath;
			cmbWarehouseLocation.DataSource = context.Cities.ToList();
		}

		public FrmNewProject()
		{
			InitializeComponent();
		}
		private void btnCreateNewProject_Click(object sender, EventArgs e)
		{
			ProjectName = txtProjectName.Text;
			ProjectPath = txtProjectPath.Text;
			WarehouseLocation = cmbWarehouseLocation.Text;
			this.Hide();
			Form1 form1 = new Form1();
			form1.Show();
			
		}
	}
}