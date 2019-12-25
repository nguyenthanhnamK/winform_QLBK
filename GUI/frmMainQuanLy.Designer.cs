namespace GUI
{
    partial class frmMainQuanLy
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboThucAn = new System.Windows.Forms.ComboBox();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip6 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip7 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip8 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip9 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip10 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemMon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mnuQLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLThucAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(550, 548);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cboThucAn
            // 
            this.cboThucAn.FormattingEnabled = true;
            this.cboThucAn.Location = new System.Drawing.Point(559, 92);
            this.cboThucAn.Name = "cboThucAn";
            this.cboThucAn.Size = new System.Drawing.Size(217, 33);
            this.cboThucAn.TabIndex = 1;
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Location = new System.Drawing.Point(966, 95);
            this.nmSoLuong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(48, 30);
            this.nmSoLuong.TabIndex = 3;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin,
            this.toolStripMenuItem1,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1183, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLNV,
            this.mnuQLBan,
            this.mnuQLThucAn,
            this.mnuQLTaiKhoan,
            this.đăngXuấtToolStripMenuItem});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(81, 29);
            this.mnuAdmin.Text = "Admin";
            this.mnuAdmin.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(559, 53);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(217, 33);
            this.cboDanhMuc.TabIndex = 0;
            this.cboDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cboDanhMuc_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvHoaDon.FullRowSelect = true;
            this.lvHoaDon.GridLines = true;
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(562, 150);
            this.lvHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(535, 310);
            this.lvHoaDon.TabIndex = 8;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 100;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnThanhToan.Location = new System.Drawing.Point(907, 481);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(124, 71);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip5.Name = "contextMenuStrip5";
            this.contextMenuStrip5.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip6
            // 
            this.contextMenuStrip6.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip6.Name = "contextMenuStrip6";
            this.contextMenuStrip6.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip7
            // 
            this.contextMenuStrip7.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip7.Name = "contextMenuStrip7";
            this.contextMenuStrip7.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip8
            // 
            this.contextMenuStrip8.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip8.Name = "contextMenuStrip8";
            this.contextMenuStrip8.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip9
            // 
            this.contextMenuStrip9.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip9.Name = "contextMenuStrip9";
            this.contextMenuStrip9.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip10
            // 
            this.contextMenuStrip10.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip10.Name = "contextMenuStrip10";
            this.contextMenuStrip10.Size = new System.Drawing.Size(61, 4);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThemMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnThemMon.Location = new System.Drawing.Point(792, 53);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(135, 72);
            this.btnThemMon.TabIndex = 10;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(941, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số lượng";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.BackColor = System.Drawing.Color.White;
            this.lblThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(755, 499);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(127, 33);
            this.lblThanhTien.TabIndex = 12;
            this.lblThanhTien.Text = "0";
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(633, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tổng tiền:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(24, 24);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // mnuQLNV
            // 
            this.mnuQLNV.Image = global::GUI.Properties.Resources.user;
            this.mnuQLNV.Name = "mnuQLNV";
            this.mnuQLNV.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuQLNV.Size = new System.Drawing.Size(320, 34);
            this.mnuQLNV.Text = "Quản lý nhân viên";
            this.mnuQLNV.Click += new System.EventHandler(this.mnuQLNV_Click);
            // 
            // mnuQLBan
            // 
            this.mnuQLBan.Image = global::GUI.Properties.Resources.square;
            this.mnuQLBan.Name = "mnuQLBan";
            this.mnuQLBan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnuQLBan.Size = new System.Drawing.Size(320, 34);
            this.mnuQLBan.Text = "Quản lý bàn";
            this.mnuQLBan.Click += new System.EventHandler(this.mnuQLBan_Click);
            // 
            // mnuQLThucAn
            // 
            this.mnuQLThucAn.Image = global::GUI.Properties.Resources.icons8_kawaii_soda_48;
            this.mnuQLThucAn.Name = "mnuQLThucAn";
            this.mnuQLThucAn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuQLThucAn.Size = new System.Drawing.Size(320, 34);
            this.mnuQLThucAn.Text = "Quản lý thức ăn";
            this.mnuQLThucAn.Click += new System.EventHandler(this.mnuQLThucAn_Click);
            // 
            // mnuQLTaiKhoan
            // 
            this.mnuQLTaiKhoan.Image = global::GUI.Properties.Resources.group;
            this.mnuQLTaiKhoan.Name = "mnuQLTaiKhoan";
            this.mnuQLTaiKhoan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.mnuQLTaiKhoan.Size = new System.Drawing.Size(320, 34);
            this.mnuQLTaiKhoan.Text = "Quản lý  tài khoản";
            this.mnuQLTaiKhoan.Click += new System.EventHandler(this.mnuQLTaiKhoan_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(16, 29);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // frmMainQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1183, 581);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.nmSoLuong);
            this.Controls.Add(this.cboThucAn);
            this.Controls.Add(this.cboDanhMuc);
            this.Controls.Add(this.lvHoaDon);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMainQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán ăn vặt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.ComboBox cboThucAn;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip10;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNV;
        private System.Windows.Forms.ToolStripMenuItem mnuQLBan;
        private System.Windows.Forms.ToolStripMenuItem mnuQLThucAn;
        private System.Windows.Forms.ToolStripMenuItem mnuQLTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
    }
}

