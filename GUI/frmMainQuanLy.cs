using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class frmMainQuanLy : Form
    {
        public static int TableWidth = 90;
        public static int TableHeight = 90;
        public string username1 = "";
        public frmMainQuanLy()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhMuc();
            LoadTable();
            PhanQuyenTK();

        }
        
        private void PhanQuyenTK()
        {
            TaiKhoanBLL tkBll = new TaiKhoanBLL();
            
            List<TaiKhoan> dstk = tkBll.LayTaiKhoanTheoUserName(username1);
            TaiKhoan tk = dstk.First(p => p.UserName == username1);
            if (tk.Type == 1)
                mnuAdmin.Enabled = true;
            else
                mnuAdmin.Enabled = false;
        }
        private void HienThiDanhMuc()
        {
            DanhMucBLL dmbll = new DanhMucBLL();
            List<DanhMuc> dsDM = dmbll.LayToanBoDanhMuc();
            lvHoaDon.Items.Clear();
            cboDanhMuc.DataSource = dsDM;
            cboDanhMuc.DisplayMember = "TenDanhMuc";
        }
        private void LoadTable()
        {
            flowLayoutPanel1.Controls.Clear();
            TableBLL tablebll = new TableBLL();
            List<Table> lsTable = tablebll.LayToanBoBan();
            foreach (Table item in lsTable)
            {
                Button btn = new Button() { Width = TableWidth, Height = TableHeight };
                btn.Text = item.TenBan + Environment.NewLine + item.TrangThai;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.SkyBlue;
                        break;
                    default:
                        btn.BackColor = Color.Orange;
                        break;
                }

                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        void btn_Click(Object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).TableId;
            lvHoaDon.Tag = (sender as Button).Tag;
            showBill(tableID);
        }
        void showBill(int id)
        {
            MenuBLL menubll = new MenuBLL();
            List<Menu1> cthd = menubll.LayMenuTheoBan(id);
            lvHoaDon.Items.Clear();
            
            int totalPrice = 0;
            foreach (Menu1 item in cthd)
            {
                ListViewItem lsvItem = new ListViewItem(item.TenThucAn.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.Gia.ToString());
                lsvItem.SubItems.Add(item.ThanhTien.ToString());
                totalPrice += item.ThanhTien;
                lvHoaDon.Items.Add(lsvItem);
                
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            lblThanhTien.Text = totalPrice.ToString("c", culture);

        }
        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThucAnBLL foodbll = new ThucAnBLL();
            if (cboDanhMuc.SelectedItem == null)
                return;
            DanhMuc dm = cboDanhMuc.SelectedItem as DanhMuc;
            int id = dm.DanhMucID;
            List<ThucAn> dsFood = foodbll.LayToanBoThucAnTheoDanhMuc(id);
            
            cboThucAn.DataSource = dsFood;
            cboThucAn.DisplayMember = "TenThucAn";
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            try
            {
                Table tb = lvHoaDon.Tag as Table;
                HoaDon hd = new HoaDon();
                if(tb == null)
                {
                    MessageBox.Show("Hãy chọn bàn", "Thông báo");
                    return;
                }
                HoaDonBLL hdbll = new HoaDonBLL();
                int idBill = hdbll.KiemTraBan(tb.TableId);
                int foodId = (cboThucAn.SelectedItem as ThucAn).FoodID;
                CTHDBLL cthd = new CTHDBLL();
                TaiKhoanBLL tkBll = new TaiKhoanBLL();

                List<TaiKhoan> dstk = tkBll.LayTaiKhoanTheoUserName(username1);
                TaiKhoan tk = dstk.First(p => p.UserName == username1);
                int sl = (int)nmSoLuong.Value;
                if (idBill == -1)
                {
                    bool kq = hdbll.InsertBill(tb.TableId, tk.NhanVienId);
                   
                    cthd.InsertCthd(hdbll.getMaxId(), foodId, sl);
                    
                }
                else
                {
                    cthd.InsertCthd(idBill, foodId, sl);
                }
                showBill(tb.TableId);
                LoadTable();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lvHoaDon.Tag as Table;
                HoaDon hd = new HoaDon();
                HoaDonBLL hdbll = new HoaDonBLL();
                int idBill = hdbll.KiemTraBan(table.TableId);
                if (idBill != -1)
                {
                    if (MessageBox.Show("Bạn có chắc muốn thanh toán hóa đơn cho bàn " + table.TenBan, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        bool kq = hdbll.ThanhToan(idBill);
                        if (kq)
                        {
                            showBill(table.TableId);
                            LoadTable();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuQLNV_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.Show();
        }

        private void mnuQLBan_Click(object sender, EventArgs e)
        {
            frmQuanLyBan frm = new frmQuanLyBan();
            frm.Show();
        }

        private void mnuQLTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan();
            frm.Show();
        }

        private void mnuQLThucAn_Click(object sender, EventArgs e)
        {
            frmQuanLyThucAn frm = new frmQuanLyThucAn();
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.Show();
        }
    }
}
