using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using BLL;
using DTO;
namespace GUI
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiMaHD();
        }
        private void HienThiMaHD()
        {
            HoaDonBLL hdbll = new HoaDonBLL();
            List<HoaDon> list = hdbll.LayToanBoHD();
            List<HoaDon> list1 = list.Where(p => p.TrangThai == 1).ToList();
            list1.Reverse();
            cboMaHD.DataSource = list1;
            cboMaHD.DisplayMember = "BillId";
        }
        private void btnXuat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"server = DESKTOP-VG2CT3T\SQLEXPRESS; database = CSDL_QuanLyBanKem; uid = nhatnam99; pwd = nhatnam00");
            int a = int.Parse(cboMaHD.Text);
            string query = "select h.billid, t.Ten  , c.Soluong, t.Gia, t.Gia*c.SoLuong as [ThanhTien] ,convert(varchar(10), h.ngayvao, 103) as [ngayvao], TenBan as [Ban] from ThucAn t, HoaDon h, cthd c, ban b where t.Foodid = c.Foodid and h.Billid = c.Billid and h.TableId = b.Tableid and h.TrangThai = 1  and h.billid = " + a;
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "HoaDon");
            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportHoaDon.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
