using DeepFreeze___Cool_Storage_Designer.Context;
using DeepFreeze___Cool_Storage_Designer.Entities;
using DeepFreeze___Cool_Storage_Designer.Tools;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepFreeze___Cool_Storage_Designer
{
	public partial class FrmWallCreate : DevExpress.XtraEditors.XtraForm
	{
		Pen pen = new Pen(Color.Blue, 1);
		SolidBrush solidBrush = new SolidBrush(Color.Black);


		DeepFreezeContext context = new DeepFreezeContext();
		List<WallLayer> WallLayers = new List<WallLayer>();

		decimal startX, startY, left;
		decimal K;
		int secilenIndex;
		List<HatchBrushTypes> hatchBrushTypes;
		List<Material> materials;

		public FrmWallCreate()
		{
			InitializeComponent();
			if (!context.Database.Exists())
			{
				context.Database.Create();
				InitializeStarter.CreateCities(context);

			}

		}

		private void grdLookUpMalzeme_EditValueChanged(object sender, EventArgs e)
		{
			txtIsıİletimKatsayisi.Text = gridLookUpEdit1View.GetRowCellValue(secilenIndex, "IsiIletimKatsayisi") + "KCal/h.°C.m";
		}

		private void txtKalinlik_TextChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			if (WallLayers.Count > 0)
			{
				e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				decimal TotalWidth = 0.0m;
				foreach (WallLayer layer in WallLayers)
				{
					TotalWidth += layer.Width;
				}
				startX = pictureBox1.Width / 2 - TotalWidth / 2;

				for (int i = 0; i < WallLayers.Count; i++)
				{
					RectangleF layerstart = new RectangleF(new PointF(Convert.ToSingle(startX), Convert.ToSingle(startY)), new SizeF(Convert.ToSingle(WallLayers[i].Width), WallLayers[i].Height));
					e.Graphics.DrawRectangle(new Pen(Color.FromName(WallLayers[i].WallMaterial.PenColorCode), WallLayers[i].WallMaterial.PenThickness), layerstart.X, layerstart.Y, layerstart.Width, layerstart.Height);
					e.Graphics.FillRectangle(new HatchBrush(WallLayers[i].WallMaterial.HatchBrushStyle, Color.FromName(WallLayers[i].WallMaterial.HatcBrushColor), Color.Transparent), layerstart);
					left = pictureBox1.Width / 2 - 130 - TotalWidth / 2;
					startX += WallLayers[i].Width;
				}
				e.Graphics.DrawString("Dış Yüzey", new Font(FontFamily.GenericSansSerif, 12), solidBrush, new PointF(Convert.ToSingle(left), pictureBox1.Height / 2));
				e.Graphics.DrawString("İç Yüzey", new Font(FontFamily.GenericSansSerif, 12), solidBrush, new PointF(Convert.ToSingle(startX + 50), pictureBox1.Height / 2));
			}

		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtKalinlik.Text))
			{
				WallLayer wallLayer = new WallLayer() { ID = WallLayers.Count, Width = Convert.ToDecimal(txtKalinlik.Text), Height = 325 };
				wallLayer.WallMaterial.MaterialName = base.Name = grdLookUpMalzeme.Text;
				int secilenMaterialID = Convert.ToInt32(gridLookUpEdit1View.GetRowCellValue(secilenIndex, "ID"));
				Material material = materials.Where(q => q.ID == secilenMaterialID).FirstOrDefault();
				wallLayer.WallMaterial = material;
				wallLayer.WallMaterial.HatchBrushStyle = material.HatchBrushStyle;
				wallLayer.WallMaterial.HatcBrushColor = material.HatcBrushColor;
				WallLayers.Add(wallLayer);
				pictureBox1.Refresh();

				treeKatmanlar.Nodes.Add(wallLayer.WallMaterial.MaterialName);
				treeKatmanlar.SelectedNode = treeKatmanlar.Nodes[wallLayer.ID];
				treeKatmanlar.SelectedNode.ForeColor = Color.FromName(wallLayer.WallMaterial.HatcBrushColor);
				decimal x = 0.001m;
				foreach (WallLayer layer in WallLayers)
				{

					K = 1 / ((1m / 7m) + (layer.Width * x / layer.WallMaterial.IsiIletimKatsayisi) + (1m / 7m));
					//decimal a = (layer.Width / layer.WallMaterial.IsiIletimKatsayisi) * 0.001m;
					//MessageBox.Show(a.ToString());


				}
				//MessageBox.Show((1m / 7m).ToString());
				lblKValue.Text = K.ToString() + " m².h.°C";
			}
			else
			{
				MessageBox.Show("Kalınlık Değeri Girmelisiniz.");
			}


		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void gridLookUpEdit1View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (e.FocusedRowHandle > -1)
			{
				secilenIndex = e.FocusedRowHandle;
			}
		}

		private void FrmWallDesign_Load(object sender, EventArgs e)
		{
            
            this.MaximumSize = this.Size;
			hatchBrushTypes = InitializeStarter.CreateBrushes();
			//CustomTool.SerializeObject(InitializeStarter.CreateMaterials());
			materials = CustomTool.DeserializeObject(CustomTool.filePath);
			grdLookUpMalzeme.Properties.DataSource = materials;


		}
	}
}