namespace GUI
{
    partial class frmQuanLyBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyBan));
            this.grbThongTinNV = new System.Windows.Forms.GroupBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbDanhSachBan = new System.Windows.Forms.GroupBox();
            this.lvBan = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbThongTinNV.SuspendLayout();
            this.grbDanhSachBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongTinNV
            // 
            this.grbThongTinNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grbThongTinNV.Controls.Add(this.cboTrangThai);
            this.grbThongTinNV.Controls.Add(this.btnSua);
            this.grbThongTinNV.Controls.Add(this.label6);
            this.grbThongTinNV.Controls.Add(this.btnLuu);
            this.grbThongTinNV.Controls.Add(this.btnXoa);
            this.grbThongTinNV.Controls.Add(this.btnTaoMoi);
            this.grbThongTinNV.Controls.Add(this.txtTen);
            this.grbThongTinNV.Controls.Add(this.txtMa);
            this.grbThongTinNV.Controls.Add(this.label3);
            this.grbThongTinNV.Controls.Add(this.label2);
            this.grbThongTinNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbThongTinNV.Location = new System.Drawing.Point(0, 0);
            this.grbThongTinNV.Name = "grbThongTinNV";
            this.grbThongTinNV.Size = new System.Drawing.Size(676, 268);
            this.grbThongTinNV.TabIndex = 2;
            this.grbThongTinNV.TabStop = false;
            this.grbThongTinNV.Text = "Thông tin bàn";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Có người"});
            this.cboTrangThai.Location = new System.Drawing.Point(113, 122);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(549, 28);
            this.cboTrangThai.TabIndex = 16;
            // 
            // btnSua
            // 
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImageKey = "edit.png";
            this.btnSua.ImageList = this.imageList1;
            this.btnSua.Location = new System.Drawing.Point(113, 183);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 52);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cross.png");
            this.imageList1.Images.SetKeyName(1, "diskette.png");
            this.imageList1.Images.SetKeyName(2, "document.png");
            this.imageList1.Images.SetKeyName(3, "edit.png");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Trạng thái:";
            // 
            // btnLuu
            // 
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageKey = "diskette.png";
            this.btnLuu.ImageList = this.imageList1;
            this.btnLuu.Location = new System.Drawing.Point(396, 183);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(130, 52);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Thêm";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.ImageKey = "cross.png";
            this.btnXoa.ImageList = this.imageList1;
            this.btnXoa.Location = new System.Drawing.Point(532, 183);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 52);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoMoi.ImageKey = "document.png";
            this.btnTaoMoi.ImageList = this.imageList1;
            this.btnTaoMoi.Location = new System.Drawing.Point(249, 183);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(130, 52);
            this.btnTaoMoi.TabIndex = 11;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(113, 75);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(549, 26);
            this.txtTen.TabIndex = 3;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(113, 36);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(549, 26);
            this.txtMa.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã:";
            // 
            // grbDanhSachBan
            // 
            this.grbDanhSachBan.Controls.Add(this.lvBan);
            this.grbDanhSachBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDanhSachBan.Location = new System.Drawing.Point(0, 268);
            this.grbDanhSachBan.Name = "grbDanhSachBan";
            this.grbDanhSachBan.Size = new System.Drawing.Size(676, 254);
            this.grbDanhSachBan.TabIndex = 3;
            this.grbDanhSachBan.TabStop = false;
            this.grbDanhSachBan.Text = "Danh sách bàn";
            // 
            // lvBan
            // 
            this.lvBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBan.FullRowSelect = true;
            this.lvBan.GridLines = true;
            this.lvBan.HideSelection = false;
            this.lvBan.Location = new System.Drawing.Point(3, 22);
            this.lvBan.Name = "lvBan";
            this.lvBan.Size = new System.Drawing.Size(670, 229);
            this.lvBan.TabIndex = 0;
            this.lvBan.UseCompatibleStateImageBehavior = false;
            this.lvBan.View = System.Windows.Forms.View.Details;
            this.lvBan.SelectedIndexChanged += new System.EventHandler(this.lvBan_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "STT";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tên bàn";
            this.columnHeader8.Width = 250;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Trạng thái";
            this.columnHeader9.Width = 100;
            // 
            // frmQuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 522);
            this.Controls.Add(this.grbDanhSachBan);
            this.Controls.Add(this.grbThongTinNV);
            this.Name = "frmQuanLyBan";
            this.Text = "Quản lý bàn";
            this.Load += new System.EventHandler(this.frmQuanLyBan_Load);
            this.grbThongTinNV.ResumeLayout(false);
            this.grbThongTinNV.PerformLayout();
            this.grbDanhSachBan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinNV;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbDanhSachBan;
        private System.Windows.Forms.ListView lvBan;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.ImageList imageList1;
    }
}