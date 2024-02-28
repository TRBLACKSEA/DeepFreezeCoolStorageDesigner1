
namespace DeepFreeze___Cool_Storage_Designer
{
	partial class FrmWallCreate
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("İç Duvar");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Dış Duvar");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Zemin/Döşeme");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Tavan");
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.treeDuvarlar = new System.Windows.Forms.TreeView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.treeKatmanlar = new System.Windows.Forms.TreeView();
			this.grdLookUpMalzeme = new DevExpress.XtraEditors.GridLookUpEdit();
			this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.MaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.IsiIletimKatsayisi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.PenThickness = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lblKValue = new System.Windows.Forms.Label();
			this.btnFarklıKaydet = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnEkle = new System.Windows.Forms.Button();
			this.txtIsıİletimKatsayisi = new System.Windows.Forms.TextBox();
			this.txtKalinlik = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdLookUpMalzeme.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1036, 371);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Duvar Tipi";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(3, 23);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1030, 345);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			// 
			// treeDuvarlar
			// 
			this.treeDuvarlar.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeDuvarlar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.treeDuvarlar.Location = new System.Drawing.Point(0, 371);
			this.treeDuvarlar.Name = "treeDuvarlar";
			treeNode1.Name = "Node0";
			treeNode1.Text = "İç Duvar";
			treeNode2.Name = "Node1";
			treeNode2.Text = "Dış Duvar";
			treeNode3.Name = "Node2";
			treeNode3.Text = "Zemin/Döşeme";
			treeNode4.Name = "Node3";
			treeNode4.Text = "Tavan";
			this.treeDuvarlar.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
			this.treeDuvarlar.Size = new System.Drawing.Size(168, 259);
			this.treeDuvarlar.TabIndex = 2;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.treeKatmanlar);
			this.groupBox2.Controls.Add(this.grdLookUpMalzeme);
			this.groupBox2.Controls.Add(this.lblKValue);
			this.groupBox2.Controls.Add(this.btnFarklıKaydet);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.btnKaydet);
			this.groupBox2.Controls.Add(this.btnSil);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.btnEkle);
			this.groupBox2.Controls.Add(this.txtIsıİletimKatsayisi);
			this.groupBox2.Controls.Add(this.txtKalinlik);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(168, 371);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(868, 259);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Duvar Özellikleri";
			// 
			// treeKatmanlar
			// 
			this.treeKatmanlar.Dock = System.Windows.Forms.DockStyle.Right;
			this.treeKatmanlar.Location = new System.Drawing.Point(429, 23);
			this.treeKatmanlar.Name = "treeKatmanlar";
			this.treeKatmanlar.Size = new System.Drawing.Size(436, 233);
			this.treeKatmanlar.TabIndex = 5;
			// 
			// grdLookUpMalzeme
			// 
			this.grdLookUpMalzeme.EditValue = "Seçiniz";
			this.grdLookUpMalzeme.Location = new System.Drawing.Point(122, 26);
			this.grdLookUpMalzeme.Name = "grdLookUpMalzeme";
			this.grdLookUpMalzeme.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.grdLookUpMalzeme.Properties.DataSource = this.materialBindingSource;
			this.grdLookUpMalzeme.Properties.DisplayMember = "MaterialName";
			this.grdLookUpMalzeme.Properties.PopupView = this.gridLookUpEdit1View;
			this.grdLookUpMalzeme.Properties.ValueMember = "ID";
			this.grdLookUpMalzeme.Size = new System.Drawing.Size(301, 28);
			this.grdLookUpMalzeme.TabIndex = 4;
			this.grdLookUpMalzeme.EditValueChanged += new System.EventHandler(this.grdLookUpMalzeme_EditValueChanged);
			// 
			// gridLookUpEdit1View
			// 
			this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.MaterialName,
            this.IsiIletimKatsayisi,
            this.PenThickness});
			this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
			this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
			this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			this.gridLookUpEdit1View.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridLookUpEdit1View_FocusedRowChanged);
			// 
			// ID
			// 
			this.ID.Caption = "ID";
			this.ID.FieldName = "ID";
			this.ID.Name = "ID";
			// 
			// MaterialName
			// 
			this.MaterialName.Caption = "Malzeme";
			this.MaterialName.FieldName = "MaterialName";
			this.MaterialName.Name = "MaterialName";
			this.MaterialName.Visible = true;
			this.MaterialName.VisibleIndex = 0;
			// 
			// IsiIletimKatsayisi
			// 
			this.IsiIletimKatsayisi.Caption = "Isı İletim Katsayısı";
			this.IsiIletimKatsayisi.FieldName = "IsiIletimKatsayisi";
			this.IsiIletimKatsayisi.Name = "IsiIletimKatsayisi";
			this.IsiIletimKatsayisi.Visible = true;
			this.IsiIletimKatsayisi.VisibleIndex = 1;
			// 
			// PenThickness
			// 
			this.PenThickness.Caption = "Kalem Kalınlığı";
			this.PenThickness.FieldName = "PenThickness";
			this.PenThickness.Name = "PenThickness";
			// 
			// lblKValue
			// 
			this.lblKValue.AutoSize = true;
			this.lblKValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblKValue.Location = new System.Drawing.Point(205, 143);
			this.lblKValue.Name = "lblKValue";
			this.lblKValue.Size = new System.Drawing.Size(15, 19);
			this.lblKValue.TabIndex = 0;
			this.lblKValue.Text = "-";
			// 
			// btnFarklıKaydet
			// 
			this.btnFarklıKaydet.Location = new System.Drawing.Point(246, 216);
			this.btnFarklıKaydet.Name = "btnFarklıKaydet";
			this.btnFarklıKaydet.Size = new System.Drawing.Size(177, 35);
			this.btnFarklıKaydet.TabIndex = 3;
			this.btnFarklıKaydet.Text = "Farklı Kaydet";
			this.btnFarklıKaydet.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(6, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(202, 19);
			this.label4.TabIndex = 0;
			this.label4.Text = "Toplam Isı İletim Katsayısı:";
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(246, 175);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(177, 35);
			this.btnKaydet.TabIndex = 3;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(122, 216);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(118, 35);
			this.btnSil.TabIndex = 3;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			// 
			// btnEkle
			// 
			this.btnEkle.Location = new System.Drawing.Point(122, 175);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(118, 35);
			this.btnEkle.TabIndex = 3;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// txtIsıİletimKatsayisi
			// 
			this.txtIsıİletimKatsayisi.Enabled = false;
			this.txtIsıİletimKatsayisi.Location = new System.Drawing.Point(122, 68);
			this.txtIsıİletimKatsayisi.Name = "txtIsıİletimKatsayisi";
			this.txtIsıİletimKatsayisi.Size = new System.Drawing.Size(301, 27);
			this.txtIsıİletimKatsayisi.TabIndex = 2;
			// 
			// txtKalinlik
			// 
			this.txtKalinlik.Location = new System.Drawing.Point(122, 109);
			this.txtKalinlik.Name = "txtKalinlik";
			this.txtKalinlik.Size = new System.Drawing.Size(301, 27);
			this.txtKalinlik.TabIndex = 2;
			this.txtKalinlik.TextChanged += new System.EventHandler(this.txtKalinlik_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(6, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "Isı İletim Kat.:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(6, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Kalınlık (mm):";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(40, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Malzeme:";
			// 
			// materialBindingSource
			// 
			this.materialBindingSource.DataSource = typeof(DeepFreeze___Cool_Storage_Designer.Entities.Material);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 175);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 35);
			this.button1.TabIndex = 3;
			this.button1.Text = "Hesapla";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FrmWallCreate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1036, 630);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.treeDuvarlar);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmWallCreate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Duvar Tasarımı";
			this.Load += new System.EventHandler(this.FrmWallDesign_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdLookUpMalzeme.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TreeView treeDuvarlar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnFarklıKaydet;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.TextBox txtIsıİletimKatsayisi;
		private System.Windows.Forms.TextBox txtKalinlik;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblKValue;
		private System.Windows.Forms.Label label4;
		private DevExpress.XtraEditors.GridLookUpEdit grdLookUpMalzeme;
		private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.BindingSource materialBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn ID;
		private DevExpress.XtraGrid.Columns.GridColumn MaterialName;
		private DevExpress.XtraGrid.Columns.GridColumn IsiIletimKatsayisi;
		private DevExpress.XtraGrid.Columns.GridColumn PenThickness;
		private System.Windows.Forms.TreeView treeKatmanlar;
		private System.Windows.Forms.Button button1;
	}
}