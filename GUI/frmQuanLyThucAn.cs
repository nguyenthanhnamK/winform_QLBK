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
    public partial class frmQuanLyThucAn : Form
    {
        public frmQuanLyThucAn()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmQuanLyThucAn_Load(object sender, EventArgs e)
        {
            HienThiToanBoDanhMuc();
            HienThiToanBoThucAn();
        }
        private void HienThiToanBoDanhMuc()
        {
            DanhMucBLL dmbll = new DanhMucBLL();
            List<DanhMuc> list = dmbll.LayToanBoDanhMuc();
            cboMaDM.DataSource = list;
            cboMaDM.DisplayMember = "Danhmucid";
            foreach (DanhMuc item in list)
            {

                ListViewItem lvi = new ListViewItem((lvDanhMuc.Items.Count + 1) + "");
                lvi.SubItems.Add(item.DanhMucID.ToString());
                lvi.SubItems.Add(item.TenDanhMuc.ToString());

                lvDanhMuc.Items.Add(lvi);

            }
        }
        private void HienThiToanBoThucAn()
        {
            ThucAnBLL tabll = new ThucAnBLL();
            List<ThucAn> list = tabll.LayToanBoThucAn();
            foreach (ThucAn item in list)
            {

                ListViewItem lvi = new ListViewItem((lvThucAn.Items.Count + 1) + "");
                lvi.SubItems.Add(item.FoodID.ToString());
                lvi.SubItems.Add(item.TenThucAn.ToString());
                lvi.SubItems.Add(item.DonGia.ToString());
                lvi.SubItems.Add(item.DanhMucID.ToString());
                lvThucAn.Items.Add(lvi);

                
            }
        }
        private void ThemMonAn()
        {
            string ten = txtTenThucAn.Text;
            int gia = int.Parse(txtGia.Text);
            int madm = int.Parse(cboMaDM.Text);
            
            ThucAnBLL tabll = new ThucAnBLL();
            bool kq = tabll.ThemMoiThucAn(ten, gia, madm);
            if (kq)
            {

                HienThiToanBoThucAn();
                MessageBox.Show("Thêm thức ăn thành công", "Thông báo");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenThucAn.Text == "" || txtGia.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                    return;
                }
                lvThucAn.Items.Clear();
                ThemMonAn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void XoaMonAn(int ma)
        {
            
            ThucAnBLL tabll = new ThucAnBLL();
            
            bool kq = tabll.XoaThucAn(ma);
            if (kq)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                lvThucAn.Items.Clear();
                HienThiToanBoThucAn();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvThucAn.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Chưa chọn sao xóa ?", "Thông báo");
                    return;
                }
                else
                {
                    ListViewItem lvi = lvThucAn.SelectedItems[0];
                    int ma = int.Parse(txtMaThucAn.Text);
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa mã thức ăn [" + ma + "] không? Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        XoaMonAn(ma);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {

            txtTenThucAn.Text = "";
            txtGia.Text = "";
            txtMaThucAn.Text = "";
            cboMaDM.Text = "1";
            lvThucAn.Items.Clear();
            HienThiToanBoThucAn();
            txtTenThucAn.Focus();
        }
        private void SuaMonAn(int ma)
        {
           
                string ten = txtTenThucAn.Text;
                int gia = int.Parse(txtGia.Text);
                


                ThucAnBLL tabll = new ThucAnBLL();
                bool kq = tabll.CapNhatThucAn(ten, gia, ma);
                lvThucAn.Items.Clear();
                if (kq)
                {

                    HienThiToanBoThucAn();
                    MessageBox.Show("Cập nhật thức ăn thành công", "Thông báo");
                }
            
            
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenThucAn.Text == "" || txtGia.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                    return;
                }
                
                ThucAnBLL ta = new ThucAnBLL();
                List<ThucAn> list = ta.LayToanBoThucAn();
                int ma = int.Parse(txtMaThucAn.Text);
                foreach (ThucAn item in list)
                {

                    if (ma == item.FoodID)
                    {
                        SuaMonAn(ma);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvThucAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvThucAn.SelectedItems.Count == 0)
                return;
            ListViewItem lvi = lvThucAn.SelectedItems[0];
            txtMaThucAn.Text = lvi.SubItems[1].Text;
            txtTenThucAn.Text = lvi.SubItems[2].Text;
            txtGia.Text = lvi.SubItems[3].Text;
            cboMaDM.Text = lvi.SubItems[4].Text;
           
        }

        private void btnTaoMoiDM_Click(object sender, EventArgs e)
        {
            txtMaDM.Text = "";
            txtTenDM.Text = "";
            lvDanhMuc.Items.Clear();
            HienThiToanBoDanhMuc();
            txtMaDM.Focus();
        }

        private void lvDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhMuc.SelectedItems.Count == 0)
                return;
            ListViewItem lvi = lvDanhMuc.SelectedItems[0];
            txtMaDM.Text = lvi.SubItems[1].Text;
            txtTenDM.Text = lvi.SubItems[2].Text;
            
        }
        private void ThemDanhMuc()
        {
            string ten = txtTenDM.Text;
            DanhMucBLL dmbll = new DanhMucBLL();
            bool kq = dmbll.ThemMoiDanhMuc(ten);
            if (kq)
            {

                HienThiToanBoDanhMuc();
                MessageBox.Show("Thêm danh mục thành công", "Thông báo");
            }

        }
        private void btnLuuDM_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDM.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                    return;
                }
                lvDanhMuc.Items.Clear();
                ThemDanhMuc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void XoaDanhMuc(int ma)
        {
            DanhMucBLL dmbll = new DanhMucBLL();

            bool kq = dmbll.XoaDanhMuc(ma);
            if (kq)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                lvDanhMuc.Items.Clear();
                HienThiToanBoDanhMuc();
            }
        }
        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvDanhMuc.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Chưa chọn sao xóa ?", "Thông báo");
                    return;
                }
                else
                {
                    ListViewItem lvi = lvDanhMuc.SelectedItems[0];
                    int ma = int.Parse(txtMaDM.Text);
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa mã danh mục [" + ma + "] không? Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        XoaDanhMuc(ma);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CapNhatDanhMuc(string ten, int ma)
        {
            



            DanhMucBLL dmbll = new DanhMucBLL();
            bool kq = dmbll.CapNhatDanhMuc(ten, ma);
            lvDanhMuc.Items.Clear();
            if (kq)
            {

                HienThiToanBoDanhMuc();
                MessageBox.Show("Cập nhật danh mục thành công", "Thông báo");
            }
        }
        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDM.Text == "" || txtMaDM.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                    return;
                }

                DanhMucBLL ta = new DanhMucBLL();
                List<DanhMuc> list = ta.LayToanBoDanhMuc();
                int ma = int.Parse(txtMaDM.Text);
                string ten = txtTenDM.Text;
                foreach (DanhMuc item in list)
                {

                    if (ma == item.DanhMucID)
                    {
                        CapNhatDanhMuc(ten , ma);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
