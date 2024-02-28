using CefSharp;
using CefSharp.WinForms;
using DeepFreeze___Cool_Storage_Designer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepFreeze___Cool_Storage_Designer
{
	public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		ChromiumWebBrowser chromiumWebBrowser1;
		public Form1()
		{
			InitializeComponent();
			CefSettings settings = new CefSettings();

			//settings.RemoteDebuggingPort = 8088;
			settings.CefCommandLineArgs.Add("disable-web-security");

			BrowserSettings browserSettings = new BrowserSettings();
			browserSettings.Javascript = CefState.Enabled;


			//Perform dependency check to make sure all relevant resources are in our output directory.
			//Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);
			Cef.Initialize(settings);

			chromiumWebBrowser1 = new ChromiumWebBrowser(@"C:\Users\kursa\source\repos\DXApplication2\DXApplication2\bin\Debug\Files\index.html");
			//BrowserContainer.Controls.Add(chromiumWebBrowser1);
		}


		private void Form1_Load(object sender, EventArgs e)
		{

			//MessageBox.Show(Application.StartupPath + @"\Templates\index.html");
			this.Text = "DeepFreeze - Cool Storage Designer" + "("+ FrmNewProject.ProjectName + ")";


		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			
		}


		private void doubleBufferedPanel1_Paint_1(object sender, PaintEventArgs e)
		{

		}


		private void doubleBufferedPanel1_MouseDown(object sender, MouseEventArgs e)
		{

		}

		private void doubleBufferedPanel1_MouseMove(object sender, MouseEventArgs e)
		{



		}

		private void barButtonItem47_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}

		private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmWallCreate frmWallCreate = new FrmWallCreate();
			frmWallCreate.ShowDialog();
		}

		private void barButtonItem50_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			
		}

		private void barButtonItem51_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}

		private void doubleBufferedPanel1_MouseUp(object sender, MouseEventArgs e)
		{


		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
