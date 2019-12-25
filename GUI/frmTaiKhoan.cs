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
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            HienThiToanBoTK();
        }
        private void HienThiToanBoTK()
        {
            TaiKhoanBLL tbbll = new TaiKhoanBLL();
            List<ThongTinTK> list = tbbll.LayToanBoTaiKhoan();
            ListViewGroup lvgVip = new ListViewGroup("Tài khoản Admin");
            ListViewGroup lvgThuong = new ListViewGroup("Tài khoản nhân viên");
            lvTK.Groups.Add(lvgVip);
            lvTK.Groups.Add(lvgThuong);
            foreach (ThongTinTK item in list)
            {

                ListViewItem lvi = new ListViewItem((lvTK.Items.Count + 1) + "");
                lvi.SubItems.Add(item.UserName.ToString());
                lvi.SubItems.Add(item.Password.ToString());

                lvi.SubItems.Add(item.HoTen.ToString());
                lvi.SubItems.Add(item.Type == 1 ? "Admin" : "Nhân viên");
                lvTK.Items.Add(lvi);
                lvi.Tag = lvTK.Columns[0].Text;
                if (item.Type == 1)
                    lvi.Group = lvgVip;
                else
                    lvi.Group = lvgThuong;

            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaNv.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            cboQuyen.Text = "Nhân viên";
            txtUser.Focus();
            lvTK.Items.Clear();
            HienThiToanBoTK();
        }

        private void ThemMoiTk()
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            int nvid = int.Parse(txtMaNv.Text);
            int type = 0;
            if (cboQuyen.SelectedItem == "Admin")
                type = 1;
            else
                type = 0;
            TaiKhoanBLL tkBLL = new TaiKhoanBLL();
            bool kq = tkBLL.ThemMoiTk(user, pass, nvid, type);
            if (kq)
            {

                HienThiToanBoTK();
                MessageBox.Show("Thêm tài khoản thành công", "Thông báo");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "" || txtPass.Text == "" || txtMaNv.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                    return;
                }
                lvTK.Items.Clear();
                ThemMoiTk();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ThucHienXoa(string user)
        {
            TaiKhoanBLL tkBLL = new TaiKhoanBLL();
            bool kq = tkBLL.XoaTk(user);
            if (kq)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                lvTK.Items.Clear();
                HienThiToanBoTK();
            }
            else
            {
                MessageBox.Show("Xóa thất bại, không thể xóa tài khoản admin","Thông báo");
            }
        }
        private void CapNhat(string user, string pass)
        {


            TaiKhoanBLL tkBLL = new TaiKhoanBLL();
            bool kq = tkBLL.CapNhatTk(user, pass);
            lvTK.Items.Clear();
            if (kq)
            {

                HienThiToanBoTK();
                MessageBox.Show("Cập nhật tài khoản thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Tài khoản admin không thê sửa", "Thông báo");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                    return;
                }
                string user = txtUser.Text;
                string pass = txtPass.Text;
                
                TaiKhoanBLL tkBLL = new TaiKhoanBLL();
                List<ThongTinTK> list = tkBLL.LayToanBoTaiKhoan();

                foreach (ThongTinTK item in list)
                {

                    if (user == item.UserName)
                    {
                        CapNhat(user, pass);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvTK.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Chưa chọn sao xóa ?", "Thông báo");
                    return;
                }
                else
                {
                    ListViewItem lvi = lvTK.SelectedItems[0];
                    string user = lvi.SubItems[1].Text;
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tên tài khoản [" + user + "] không? Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        ThucHienXoa(user);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTK.SelectedItems.Count == 0)
                return;
            ListViewItem lvi = lvTK.SelectedItems[0];
           
            txtUser.Text = lvi.SubItems[1].Text;
            txtPass.Text = lvi.SubItems[2].Text;
            txtTen.Text = lvi.SubItems[3].Text;
            if (lvi.SubItems[4].Text == "Admin")
                cboQuyen.SelectedItem = "Admin";
            else
                cboQuyen.SelectedItem = "Nhân viên";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
