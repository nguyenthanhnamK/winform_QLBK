namespace GUI
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbThongTinNV = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbDanhSachNV = new System.Windows.Forms.GroupBox();
            this.lvNhanVien = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.grbThongTinNV.SuspendLayout();
            this.grbDanhSachNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.grbThongTinNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 316);
            this.panel1.TabIndex = 0;
            // 
            // grbThongTinNV
            // 
            this.grbThongTinNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grbThongTinNV.Controls.Add(this.btnSua);
            this.grbThongTinNV.Controls.Add(this.txtNgaySinh);
            this.grbThongTinNV.Controls.Add(this.label6);
            this.grbThongTinNV.Controls.Add(this.btnLuu);
            this.grbThongTinNV.Controls.Add(this.btnXoa);
            this.grbThongTinNV.Controls.Add(this.btnTaoMoi);
            this.grbThongTinNV.Controls.Add(this.radNu);
            this.grbThongTinNV.Controls.Add(this.radNam);
            this.grbThongTinNV.Controls.Add(this.txtTen);
            this.grbThongTinNV.Controls.Add(this.txtMa);
            this.grbThongTinNV.Controls.Add(this.label4);
            this.grbThongTinNV.Controls.Add(this.label3);
            this.grbThongTinNV.Controls.Add(this.label2);
            this.grbThongTinNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThongTinNV.Location = new System.Drawing.Point(0, 0);
            this.grbThongTinNV.Name = "grbThongTinNV";
            this.grbThongTinNV.Size = new System.Drawing.Size(690, 316);
            this.grbThongTinNV.TabIndex = 1;
            this.grbThongTinNV.TabStop = false;
            this.grbThongTinNV.Text = "Thông tin chi tiết nhân viên";
            // 
            // btnSua
            // 
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImageIndex = 3;
            this.btnSua.ImageList = this.imageList1;
            this.btnSua.Location = new System.Drawing.Point(113, 227);
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
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(113, 163);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(549, 26);
            this.txtNgaySinh.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày sinh:";
            // 
            // btnLuu
            // 
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageKey = "diskette.png";
            this.btnLuu.ImageList = this.imageList1;
            this.btnLuu.Location = new System.Drawing.Point(385, 227);
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
            this.btnXoa.Location = new System.Drawing.Point(532, 227);
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
            this.btnTaoMoi.ImageIndex = 2;
            this.btnTaoMoi.ImageList = this.imageList1;
            this.btnTaoMoi.Location = new System.Drawing.Point(249, 227);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(130, 52);
            this.btnTaoMoi.TabIndex = 11;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(312, 120);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(54, 24);
            this.radNu.TabIndex = 6;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(113, 122);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(67, 24);
            this.radNam.TabIndex = 5;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới tính:";
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
            // grbDanhSachNV
            // 
            this.grbDanhSachNV.Controls.Add(this.lvNhanVien);
            this.grbDanhSachNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDanhSachNV.Location = new System.Drawing.Point(0, 316);
            this.grbDanhSachNV.Name = "grbDanhSachNV";
            this.grbDanhSachNV.Size = new System.Drawing.Size(690, 344);
            this.grbDanhSachNV.TabIndex = 1;
            this.grbDanhSachNV.TabStop = false;
            this.grbDanhSachNV.Text = "Danh sách nhân viên";
            // 
            // lvNhanVien
            // 
            this.lvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNhanVien.FullRowSelect = true;
            this.lvNhanVien.GridLines = true;
            this.lvNhanVien.HideSelection = false;
            this.lvNhanVien.Location = new System.Drawing.Point(3, 22);
            this.lvNhanVien.Name = "lvNhanVien";
            this.lvNhanVien.Size = new System.Drawing.Size(684, 319);
            this.lvNhanVien.TabIndex = 0;
            this.lvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvNhanVien.View = System.Windows.Forms.View.Details;
            this.lvNhanVien.SelectedIndexChanged += new System.EventHandler(this.lvNhanVien_SelectedIndexChanged);
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
            this.columnHeader8.Text = "Tên nhân viên";
            this.columnHeader8.Width = 250;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Giới tính";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ngày sinh";
            this.columnHeader10.Width = 200;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 660);
            this.Controls.Add(this.grbDanhSachNV);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhanVien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.grbThongTinNV.ResumeLayout(false);
            this.grbThongTinNV.PerformLayout();
            this.grbDanhSachNV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbThongTinNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbDanhSachNV;
        private System.Windows.Forms.ListView lvNhanVien;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ImageList imageList1;
    }
}