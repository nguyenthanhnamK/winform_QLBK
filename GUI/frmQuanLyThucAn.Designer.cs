namespace GUI
{
    partial class frmQuanLyThucAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyThucAn));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvThucAn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbThucAn = new System.Windows.Forms.GroupBox();
            this.txtMaThucAn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMaDM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenThucAn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvDanhMuc = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbDanhMuc = new System.Windows.Forms.GroupBox();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnSuaDM = new System.Windows.Forms.Button();
            this.btnLuuDM = new System.Windows.Forms.Button();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnTaoMoiDM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbThucAn.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbDanhMuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.grbThucAn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.grbDanhMuc);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1168, 575);
            this.splitContainer1.SplitterDistance = 584;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvThucAn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 313);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thức ăn";
            // 
            // lvThucAn
            // 
            this.lvThucAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvThucAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvThucAn.FullRowSelect = true;
            this.lvThucAn.GridLines = true;
            this.lvThucAn.HideSelection = false;
            this.lvThucAn.Location = new System.Drawing.Point(3, 22);
            this.lvThucAn.Name = "lvThucAn";
            this.lvThucAn.Size = new System.Drawing.Size(578, 288);
            this.lvThucAn.TabIndex = 0;
            this.lvThucAn.UseCompatibleStateImageBehavior = false;
            this.lvThucAn.View = System.Windows.Forms.View.Details;
            this.lvThucAn.SelectedIndexChanged += new System.EventHandler(this.lvThucAn_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên thức ăn";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã danh mục";
            this.columnHeader5.Width = 100;
            // 
            // grbThucAn
            // 
            this.grbThucAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grbThucAn.Controls.Add(this.txtMaThucAn);
            this.grbThucAn.Controls.Add(this.label6);
            this.grbThucAn.Controls.Add(this.cboMaDM);
            this.grbThucAn.Controls.Add(this.label1);
            this.grbThucAn.Controls.Add(this.btnSua);
            this.grbThucAn.Controls.Add(this.btnLuu);
            this.grbThucAn.Controls.Add(this.btnXoa);
            this.grbThucAn.Controls.Add(this.btnTaoMoi);
            this.grbThucAn.Controls.Add(this.txtGia);
            this.grbThucAn.Controls.Add(this.txtTenThucAn);
            this.grbThucAn.Controls.Add(this.label3);
            this.grbThucAn.Controls.Add(this.label2);
            this.grbThucAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbThucAn.Location = new System.Drawing.Point(0, 0);
            this.grbThucAn.Name = "grbThucAn";
            this.grbThucAn.Size = new System.Drawing.Size(584, 262);
            this.grbThucAn.TabIndex = 0;
            this.grbThucAn.TabStop = false;
            this.grbThucAn.Text = "Thông tin thức ăn";
            // 
            // txtMaThucAn
            // 
            this.txtMaThucAn.Location = new System.Drawing.Point(135, 153);
            this.txtMaThucAn.Name = "txtMaThucAn";
            this.txtMaThucAn.Size = new System.Drawing.Size(373, 26);
            this.txtMaThucAn.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Mã thức ăn";
            // 
            // cboMaDM
            // 
            this.cboMaDM.FormattingEnabled = true;
            this.cboMaDM.Location = new System.Drawing.Point(135, 109);
            this.cboMaDM.Name = "cboMaDM";
            this.cboMaDM.Size = new System.Drawing.Size(373, 28);
            this.cboMaDM.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã danh mục";
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
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(135, 72);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(373, 26);
            this.txtGia.TabIndex = 23;
            // 
            // txtTenThucAn
            // 
            this.txtTenThucAn.Location = new System.Drawing.Point(135, 33);
            this.txtTenThucAn.Name = "txtTenThucAn";
            this.txtTenThucAn.Size = new System.Drawing.Size(373, 26);
            this.txtTenThucAn.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên thức ăn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvDanhMuc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 313);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách danh mục";
            // 
            // lvDanhMuc
            // 
            this.lvDanhMuc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhMuc.FullRowSelect = true;
            this.lvDanhMuc.GridLines = true;
            this.lvDanhMuc.HideSelection = false;
            this.lvDanhMuc.Location = new System.Drawing.Point(3, 22);
            this.lvDanhMuc.Name = "lvDanhMuc";
            this.lvDanhMuc.Size = new System.Drawing.Size(574, 288);
            this.lvDanhMuc.TabIndex = 1;
            this.lvDanhMuc.UseCompatibleStateImageBehavior = false;
            this.lvDanhMuc.View = System.Windows.Forms.View.Details;
            this.lvDanhMuc.SelectedIndexChanged += new System.EventHandler(this.lvDanhMuc_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "STT";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã danh mục";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tên danh mục";
            this.columnHeader8.Width = 200;
            // 
            // grbDanhMuc
            // 
            this.grbDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grbDanhMuc.Controls.Add(this.btnSuaDM);
            this.grbDanhMuc.Controls.Add(this.btnLuuDM);
            this.grbDanhMuc.Controls.Add(this.btnXoaDM);
            this.grbDanhMuc.Controls.Add(this.btnTaoMoiDM);
            this.grbDanhMuc.Controls.Add(this.txtTenDM);
            this.grbDanhMuc.Controls.Add(this.label4);
            this.grbDanhMuc.Controls.Add(this.txtMaDM);
            this.grbDanhMuc.Controls.Add(this.label5);
            this.grbDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.grbDanhMuc.Name = "grbDanhMuc";
            this.grbDanhMuc.Size = new System.Drawing.Size(580, 262);
            this.grbDanhMuc.TabIndex = 1;
            this.grbDanhMuc.TabStop = false;
            this.grbDanhMuc.Text = "Thông tin danh mục";
            // 
            // txtTenDM
            // 
            this.txtTenDM.Location = new System.Drawing.Point(147, 72);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(356, 26);
            this.txtTenDM.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mã danh mục";
            // 
            // txtMaDM
            // 
            this.txtMaDM.Location = new System.Drawing.Point(147, 33);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(356, 26);
            this.txtMaDM.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tên danh mục";
            // 
            // btnSua
            // 
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImageKey = "edit.png";
            this.btnSua.ImageList = this.imageList1;
            this.btnSua.Location = new System.Drawing.Point(12, 188);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 52);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageKey = "diskette.png";
            this.btnLuu.ImageList = this.imageList1;
            this.btnLuu.Location = new System.Drawing.Point(277, 188);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(130, 52);
            this.btnLuu.TabIndex = 27;
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
            this.btnXoa.Location = new System.Drawing.Point(428, 188);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 52);
            this.btnXoa.TabIndex = 28;
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
            this.btnTaoMoi.Location = new System.Drawing.Point(141, 188);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(130, 52);
            this.btnTaoMoi.TabIndex = 26;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDM.ImageKey = "edit.png";
            this.btnSuaDM.ImageList = this.imageList1;
            this.btnSuaDM.Location = new System.Drawing.Point(23, 188);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.Size = new System.Drawing.Size(120, 52);
            this.btnSuaDM.TabIndex = 38;
            this.btnSuaDM.Text = "Sửa";
            this.btnSuaDM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaDM.UseVisualStyleBackColor = true;
            this.btnSuaDM.Click += new System.EventHandler(this.btnSuaDM_Click);
            // 
            // btnLuuDM
            // 
            this.btnLuuDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuDM.ImageKey = "diskette.png";
            this.btnLuuDM.ImageList = this.imageList1;
            this.btnLuuDM.Location = new System.Drawing.Point(283, 188);
            this.btnLuuDM.Name = "btnLuuDM";
            this.btnLuuDM.Size = new System.Drawing.Size(130, 52);
            this.btnLuuDM.TabIndex = 36;
            this.btnLuuDM.Text = "Thêm";
            this.btnLuuDM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuDM.UseVisualStyleBackColor = true;
            this.btnLuuDM.Click += new System.EventHandler(this.btnLuuDM_Click);
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDM.ImageKey = "cross.png";
            this.btnXoaDM.ImageList = this.imageList1;
            this.btnXoaDM.Location = new System.Drawing.Point(419, 188);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(130, 52);
            this.btnXoaDM.TabIndex = 37;
            this.btnXoaDM.Text = "Xóa";
            this.btnXoaDM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDM.UseVisualStyleBackColor = true;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
            // 
            // btnTaoMoiDM
            // 
            this.btnTaoMoiDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoMoiDM.ImageKey = "document.png";
            this.btnTaoMoiDM.ImageList = this.imageList1;
            this.btnTaoMoiDM.Location = new System.Drawing.Point(147, 188);
            this.btnTaoMoiDM.Name = "btnTaoMoiDM";
            this.btnTaoMoiDM.Size = new System.Drawing.Size(130, 52);
            this.btnTaoMoiDM.TabIndex = 35;
            this.btnTaoMoiDM.Text = "Tạo mới";
            this.btnTaoMoiDM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoMoiDM.UseVisualStyleBackColor = true;
            this.btnTaoMoiDM.Click += new System.EventHandler(this.btnTaoMoiDM_Click);
            // 
            // frmQuanLyThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 575);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmQuanLyThucAn";
            this.Text = "Quản lý thức ăn";
            this.Load += new System.EventHandler(this.frmQuanLyThucAn_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grbThucAn.ResumeLayout(false);
            this.grbThucAn.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grbDanhMuc.ResumeLayout(false);
            this.grbDanhMuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grbDanhMuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvThucAn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvDanhMuc;
        private System.Windows.Forms.GroupBox grbThucAn;
        private System.Windows.Forms.ComboBox cboMaDM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenThucAn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSuaDM;
        private System.Windows.Forms.Button btnLuuDM;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnTaoMoiDM;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaThucAn;
        private System.Windows.Forms.ImageList imageList1;
    }
}