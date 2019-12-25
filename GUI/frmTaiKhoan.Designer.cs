namespace GUI
{
    partial class frmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            this.grbThongTinAcc = new System.Windows.Forms.GroupBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboQuyen = new System.Windows.Forms.ComboBox();
            this.txtMaNv = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbDanhSachBan = new System.Windows.Forms.GroupBox();
            this.lvTK = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbThongTinAcc.SuspendLayout();
            this.grbDanhSachBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongTinAcc
            // 
            this.grbThongTinAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grbThongTinAcc.Controls.Add(this.txtTen);
            this.grbThongTinAcc.Controls.Add(this.label1);
            this.grbThongTinAcc.Controls.Add(this.cboQuyen);
            this.grbThongTinAcc.Controls.Add(this.txtMaNv);
            this.grbThongTinAcc.Controls.Add(this.btnSua);
            this.grbThongTinAcc.Controls.Add(this.label6);
            this.grbThongTinAcc.Controls.Add(this.btnLuu);
            this.grbThongTinAcc.Controls.Add(this.btnXoa);
            this.grbThongTinAcc.Controls.Add(this.btnTaoMoi);
            this.grbThongTinAcc.Controls.Add(this.txtPass);
            this.grbThongTinAcc.Controls.Add(this.txtUser);
            this.grbThongTinAcc.Controls.Add(this.label4);
            this.grbThongTinAcc.Controls.Add(this.label3);
            this.grbThongTinAcc.Controls.Add(this.label2);
            this.grbThongTinAcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbThongTinAcc.Location = new System.Drawing.Point(0, 0);
            this.grbThongTinAcc.Name = "grbThongTinAcc";
            this.grbThongTinAcc.Size = new System.Drawing.Size(800, 316);
            this.grbThongTinAcc.TabIndex = 2;
            this.grbThongTinAcc.TabStop = false;
            this.grbThongTinAcc.Text = "Thông tin chi tiết tài khoản";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(129, 211);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(533, 26);
            this.txtTen.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên nhân viên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboQuyen
            // 
            this.cboQuyen.FormattingEnabled = true;
            this.cboQuyen.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên"});
            this.cboQuyen.Location = new System.Drawing.Point(129, 166);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(533, 28);
            this.cboQuyen.TabIndex = 17;
            // 
            // txtMaNv
            // 
            this.txtMaNv.Location = new System.Drawing.Point(129, 122);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.Size = new System.Drawing.Size(533, 26);
            this.txtMaNv.TabIndex = 16;
            // 
            // btnSua
            // 
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImageKey = "edit.png";
            this.btnSua.ImageList = this.imageList1;
            this.btnSua.Location = new System.Drawing.Point(123, 258);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 52);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Đổi pass";
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
            this.label6.Location = new System.Drawing.Point(15, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quyền";
            // 
            // btnLuu
            // 
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageKey = "diskette.png";
            this.btnLuu.ImageList = this.imageList1;
            this.btnLuu.Location = new System.Drawing.Point(385, 258);
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
            this.btnXoa.Location = new System.Drawing.Point(532, 258);
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
            this.btnTaoMoi.Location = new System.Drawing.Point(249, 258);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(130, 52);
            this.btnTaoMoi.TabIndex = 11;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(129, 75);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(533, 26);
            this.txtPass.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(129, 36);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(533, 26);
            this.txtUser.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // grbDanhSachBan
            // 
            this.grbDanhSachBan.Controls.Add(this.lvTK);
            this.grbDanhSachBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDanhSachBan.Location = new System.Drawing.Point(0, 316);
            this.grbDanhSachBan.Name = "grbDanhSachBan";
            this.grbDanhSachBan.Size = new System.Drawing.Size(800, 315);
            this.grbDanhSachBan.TabIndex = 4;
            this.grbDanhSachBan.TabStop = false;
            this.grbDanhSachBan.Text = "Danh sách tài khoản";
            // 
            // lvTK
            // 
            this.lvTK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader1});
            this.lvTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTK.FullRowSelect = true;
            this.lvTK.GridLines = true;
            this.lvTK.HideSelection = false;
            this.lvTK.Location = new System.Drawing.Point(3, 22);
            this.lvTK.Name = "lvTK";
            this.lvTK.Size = new System.Drawing.Size(794, 290);
            this.lvTK.TabIndex = 0;
            this.lvTK.UseCompatibleStateImageBehavior = false;
            this.lvTK.View = System.Windows.Forms.View.Details;
            this.lvTK.SelectedIndexChanged += new System.EventHandler(this.lvTK_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "STT";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Username";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Password";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên nhân viên";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quyền";
            this.columnHeader1.Width = 100;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.grbDanhSachBan);
            this.Controls.Add(this.grbThongTinAcc);
            this.Name = "frmTaiKhoan";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.grbThongTinAcc.ResumeLayout(false);
            this.grbThongTinAcc.PerformLayout();
            this.grbDanhSachBan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinAcc;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbDanhSachBan;
        private System.Windows.Forms.ListView lvTK;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ComboBox cboQuyen;
        private System.Windows.Forms.TextBox txtMaNv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
    }
}