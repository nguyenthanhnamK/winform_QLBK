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
    public partial class frmQuanLyBan : Form
    {
        public frmQuanLyBan()
        {
            InitializeComponent();
        }

        private void frmQuanLyBan_Load(object sender, EventArgs e)
        {
            HienThiToanBoBan();
        }
        private void HienThiToanBoBan()
        {
            TableBLL tbbll = new TableBLL();
            List<Table> list = tbbll.LayToanBoBan();
            foreach (Table item in list)
            {

                ListViewItem lvi = new ListViewItem((lvBan.Items.Count + 1) + "");
                lvi.SubItems.Add(item.TableId.ToString());
                lvi.SubItems.Add(item.TenBan.ToString());

                lvi.SubItems.Add(item.TrangThai.ToString());
                lvBan.Items.Add(lvi);
                lvi.Tag = item.TableId;

            }

        }

        private void lvBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBan.SelectedItems.Count == 0)
                return;
            ListViewItem lvi = lvBan.SelectedItems[0];
            int ma = (int)lvi.Tag;
            txtMa.Text = lvi.SubItems[1].Text;
            txtTen.Text = lvi.SubItems[2].Text;

            cboTrangThai.Text = lvi.SubItems[3].Text;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            cboTrangThai.Text = "Trống";
            lvBan.Items.Clear();
            HienThiToanBoBan();
            txtMa.Focus();
        }

        private void ThemMoiBan()
        {
            string ten = txtTen.Text;
            string trangthai = cboTrangThai.Text;

            TableBLL tbbll = new TableBLL();
            bool kq = tbbll.ThemBan(ten, trangthai);
            if (kq)
            {

                HienThiToanBoBan();
                MessageBox.Show("Thêm bàn thành công", "Thông báo");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTen.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                    return;
                }
                lvBan.Items.Clear();
                ThemMoiBan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CapNhatBan(int ma, int ten, string trangthai)
        {

            TableBLL tbbll = new TableBLL();
            bool kq = tbbll.CapNhatBan(ma, ten, trangthai);
            lvBan.Items.Clear();
            if (kq)
            {

                HienThiToanBoBan();
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTen.Text == "" || txtMa.Text == "" || cboTrangThai.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                    return;

                }
                Table tb = new Table();
                int ten = int.Parse(txtTen.Text);
                string trangthai = cboTrangThai.Text;
                int ma = int.Parse(txtMa.Text);
                TableBLL nv = new TableBLL();
                List<Table> list = nv.LayToanBoBan();

                foreach (Table item in list)
                {

                    if (ma == item.TableId)
                    {
                        CapNhatBan(ma, ten, trangthai);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ThucHienXoa(int ma)
        {
            TableBLL tbbll = new TableBLL();
            bool kq = tbbll.XoaBan(ma);
            if (kq)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                lvBan.Items.Clear();
                HienThiToanBoBan();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvBan.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Chưa chọn sao xóa ?", "Thông báo");
                    return;
                }
                else
                {
                    ListViewItem lvi = lvBan.SelectedItems[0];
                    int ma = (int)lvi.Tag;
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa mã bàn [" + ma + "] không? Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        ThucHienXoa(ma);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
