namespace QUANLYSACH
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnHeThong = new DevExpress.XtraBars.BarButtonItem();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.btnSaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Sach = new DevExpress.XtraBars.BarButtonItem();
            this.btnSapXep = new DevExpress.XtraBars.BarButtonItem();
            this.btnDaiLy = new DevExpress.XtraBars.BarButtonItem();
            this.btnNXB = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.menuHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.menuSach = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.menuDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.menuTienIch = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.menuHoTro = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 24, 26, 24);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barSubItem1,
            this.btnHeThong,
            this.btnSaoLuu,
            this.btn_Sach,
            this.btnSapXep,
            this.btnDaiLy,
            this.btnNXB,
            this.btnHoaDon,
            this.skinDropDownButtonItem1,
            this.skinRibbonGalleryBarItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 283;
            this.ribbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.menuHeThong,
            this.menuSach,
            this.menuDanhMuc,
            this.menuTienIch,
            this.menuHoTro});
            this.ribbon.Size = new System.Drawing.Size(686, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "dá";
            this.barSubItem1.Id = 1;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnHeThong
            // 
            this.btnHeThong.ActAsDropDown = true;
            this.btnHeThong.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnHeThong.Caption = "Đổi mật khẩu";
            this.btnHeThong.DropDownControl = this.galleryDropDown1;
            this.btnHeThong.Id = 2;
            this.btnHeThong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHeThong.ImageOptions.SvgImage")));
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnHeThong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHeThong_ItemClick);
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Name = "galleryDropDown1";
            this.galleryDropDown1.Ribbon = this.ribbon;
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Caption = "Sao lưu dữ liệu";
            this.btnSaoLuu.Id = 3;
            this.btnSaoLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.Image")));
            this.btnSaoLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.LargeImage")));
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // btn_Sach
            // 
            this.btn_Sach.Caption = "Nhập dữ liệu";
            this.btn_Sach.Id = 4;
            this.btn_Sach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sach.ImageOptions.Image")));
            this.btn_Sach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Sach.ImageOptions.LargeImage")));
            this.btn_Sach.Name = "btn_Sach";
            this.btn_Sach.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btn_Sach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Caption = "Sắp xếp";
            this.btnSapXep.Id = 5;
            this.btnSapXep.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSapXep.ImageOptions.Image")));
            this.btnSapXep.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSapXep.ImageOptions.LargeImage")));
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // btnDaiLy
            // 
            this.btnDaiLy.Caption = "Đại Lý";
            this.btnDaiLy.Id = 6;
            this.btnDaiLy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDaiLy.ImageOptions.Image")));
            this.btnDaiLy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDaiLy.ImageOptions.LargeImage")));
            this.btnDaiLy.Name = "btnDaiLy";
            this.btnDaiLy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnDaiLy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDaiLy_ItemClick);
            // 
            // btnNXB
            // 
            this.btnNXB.Caption = "Nhà Xuất Bản";
            this.btnNXB.Id = 7;
            this.btnNXB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNXB.ImageOptions.SvgImage")));
            this.btnNXB.Name = "btnNXB";
            this.btnNXB.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnNXB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNXB_ItemClick);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Caption = "Hóa Đơn";
            this.btnHoaDon.Id = 8;
            this.btnHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.ImageOptions.Image")));
            this.btnHoaDon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.ImageOptions.LargeImage")));
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoaDon_ItemClick);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 9;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            this.skinDropDownButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.skinDropDownButtonItem1_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 10;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // menuHeThong
            // 
            this.menuHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHeThong);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSaoLuu);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // menuSach
            // 
            this.menuSach.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.menuSach.Name = "menuSach";
            this.menuSach.Text = "Sách";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Sach);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSapXep);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // menuDanhMuc
            // 
            this.menuDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.menuDanhMuc.Name = "menuDanhMuc";
            this.menuDanhMuc.Text = "Danh Mục";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDaiLy);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnNXB);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHoaDon);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // menuTienIch
            // 
            this.menuTienIch.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.menuTienIch.Name = "menuTienIch";
            this.menuTienIch.Text = "Tiện Ích";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // menuHoTro
            // 
            this.menuHoTro.Name = "menuHoTro";
            this.menuHoTro.Text = "Hỗ Trợ";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 419);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(686, 24);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // frmMain
            // 
            this.ActiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::QUANLYSACH.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(686, 443);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmMain.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản Lý Sách";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage menuHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnHeThong;
        private DevExpress.XtraBars.BarButtonItem btnSaoLuu;
        private DevExpress.XtraBars.BarButtonItem btn_Sach;
        private DevExpress.XtraBars.BarButtonItem btnSapXep;
        private DevExpress.XtraBars.Ribbon.RibbonPage menuSach;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnDaiLy;
        private DevExpress.XtraBars.BarButtonItem btnNXB;
        private DevExpress.XtraBars.Ribbon.RibbonPage menuDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage menuTienIch;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage menuHoTro;
        private DevExpress.XtraBars.BarButtonItem btnHoaDon;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
    }
}