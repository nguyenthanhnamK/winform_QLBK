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
    public partial class frmDangNhap : Form
    {
        
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;

            TaiKhoanBLL tkbll = new TaiKhoanBLL();

            
            try
            {
                bool a = tkbll.LayTaiKhoan(username, password);
                if (a == true)
                {
                    
                    frmMainQuanLy f = new frmMainQuanLy();
                    f.username1 = username;
                    this.Hide();
                    f.ShowDialog();
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    this.Show();
                }
                else
                    MessageBox.Show("Sai tên mật khẩu hoặc tài khoản");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

