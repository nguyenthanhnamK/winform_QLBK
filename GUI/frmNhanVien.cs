using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiToanBoNhanVien();
        }
        private void HienThiToanBoNhanVien()
        {
            NhanVienBLL nvbll = new NhanVienBLL();
            List<NhanVien> list = nvbll.LayToanNhanVien();
            foreach (NhanVien item in list)
            {
                
                ListViewItem lvi = new ListViewItem((lvNhanVien.Items.Count + 1) + "");
                lvi.SubItems.Add(item.NhanVienId.ToString());
                lvi.SubItems.Add(item.HoTen.ToString());
                lvi.SubItems.Add(item.GioiTinh == 0?"Nam" : "Nữ");
                lvi.SubItems.Add(item.Ngaysinh.ToString());
                lvNhanVien.Items.Add(lvi);
                lvi.Tag = item.NhanVienId;

            }

        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtNgaySinh.Text = "";
            lvNhanVien.Items.Clear();
            HienThiToanBoNhanVien();
            txtMa.Focus();
        }
      
        private void CapNhatNhanVien(int ma)
        {
            try
            {
                string ten = txtTen.Text;
                string ngaysinh = txtNgaySinh.Text;
                int gioitinh = 0;
                if (radNam.Checked == true)
                    gioitinh = 0;
                else
                    gioitinh = 1;
                NhanVienBLL nvbll = new NhanVienBLL();
                bool kq = nvbll.CapNhatNhanVien(ma, ten, ngaysinh, gioitinh);
                lvNhanVien.Items.Clear();
                if (kq)
                {

                    HienThiToanBoNhanVien();
                    MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void ThemMoiNhanVien()
        {
            
            string ten = txtTen.Text;
            string ngaysinh = txtNgaySinh.Text;
            int gioitinh = 0;
            if (radNam.Checked == true)
                gioitinh = 0;
            else
                gioitinh = 1;
            NhanVienBLL nvbll = new NhanVienBLL();
            bool kq =nvbll.ThemNhanVien(ten, ngaysinh, gioitinh);
            if (kq)
            {
                
                HienThiToanBoNhanVien();
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo");
            }

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTen.Text == "" || txtNgaySinh.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                    return;
                }
                lvNhanVien.Items.Clear();
                ThemMoiNhanVien();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count == 0)
                return;
            ListViewItem lvi = lvNhanVien.SelectedItems[0];
            int ma = (int)lvi.Tag;
            txtMa.Text = lvi.SubItems[1].Text;
            txtTen.Text = lvi.SubItems[2].Text;
            if (lvi.SubItems[3].Text == "Nam")
                radNam.Checked = true;
            else
                radNu.Checked = true;
            txtNgaySinh.Text = lvi.SubItems[4].Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTen.Text == "" || txtNgaySinh.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                    return;
                }
                int ma = int.Parse(txtMa.Text);
                NhanVienBLL nv = new NhanVienBLL();
                List<NhanVien> list = nv.LayToanNhanVien();

                foreach (NhanVien item in list)
                {

                    if (ma == item.NhanVienId)
                    {
                        CapNhatNhanVien(ma);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ThucHienXoa(int ma)
        {
            NhanVienBLL nv = new NhanVienBLL();
            bool kq =nv.XoaNhanVien(ma);
            if(kq)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                lvNhanVien.Items.Clear();
                HienThiToanBoNhanVien();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn sao xóa ?", "Thông báo");
                return;
            }
            else
            {
                ListViewItem lvi = lvNhanVien.SelectedItems[0];
                int ma = (int)lvi.Tag;
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa mã nhân viên [" + ma + "] không? Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    ThucHienXoa(ma);
                }
            }
        }
    }
}
