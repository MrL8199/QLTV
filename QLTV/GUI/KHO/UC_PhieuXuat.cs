using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLTV.DAL;

namespace QLTV.GUI.KHO
{
    public partial class UC_PhieuXuat : UserControl
    {
        public UC_PhieuXuat()
        {
            InitializeComponent();
        }

        private void UC_PhieuXuat_Load(object sender, EventArgs e)
        {
            dtgvPhieuXuat.DataSource = KHO_DAL.Instance.GetListPhieuXuat();
        }

        private void dtgvPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dtgvPhieuXuat.CurrentRow.Selected = true;

            int Mapx = Convert.ToInt32(dtgvPhieuXuat.CurrentRow.Cells["MaPX"].Value);
            dtgvCTPhieuXuat.DataSource = KHO_DAL.Instance.GetListCTPhieuXuat(Mapx);


        }

        private void dtgvCTPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvCTPhieuXuat.CurrentRow.Selected = true;
            txtMaCTPX.Text = dtgvCTPhieuXuat.CurrentRow.Cells["MaCTPX"].Value.ToString();
            txtMaPX.Text = dtgvCTPhieuXuat.CurrentRow.Cells["MaPX"].Value.ToString();
            txtSoLuong.Text = dtgvCTPhieuXuat.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtMaKho.Text = dtgvCTPhieuXuat.CurrentRow.Cells["MaKho"].Value.ToString();
            txtMaKeSach.Text = dtgvCTPhieuXuat.CurrentRow.Cells["MakeSach"].Value.ToString();
            txtMaDauSach.Text = dtgvCTPhieuXuat.CurrentRow.Cells["MaDauSach"].Value.ToString();

            txtMaCTPX.Enabled = false;
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkNgay.Checked)
            {
                string ngaytk = txtTimKiem.Text;
                dtgvPhieuXuat.DataSource = KHO_DAL.Instance.SearchPhieuXuatTheoNgay(ngaytk);
            }
            else if (checkMa.Checked)
            {
                int mapx = Convert.ToInt32(txtTimKiem.Text);
                dtgvCTPhieuXuat.DataSource = KHO_DAL.Instance.SearchPhieuXuatTheoMaPN(mapx);
            }
            else
                MessageBox.Show("Mời bạn chọn tìm kiếm theo Mã phiếu hay Ngày Xuất phiếu", "Thông báo", MessageBoxButtons.OK);

        }

        private void btnAddCTPN_Click(object sender, EventArgs e)
        {
            if (txtMaCTPX.Enabled)
            {
                //int mactpn = Convert.ToInt32(txtMaCTPX.Text);
                int mapn = Convert.ToInt32(txtMaPX.Text);
                int soluong = Convert.ToInt32(txtSoLuong.Text);
                int makho = Convert.ToInt32(txtMaKho.Text);
                int mancc = Convert.ToInt32(txtMaKeSach.Text);
                int madausach = Convert.ToInt32(txtMaDauSach.Text);

                KHO_DAL.Instance.InsertCTPhieuXuat(mapn, makho, mancc, soluong, madausach);

                dtgvCTPhieuXuat.DataSource = KHO_DAL.Instance.GetListCTPhieuXuat(mapn);
            }
            else
            {
                txtMaCTPX.Enabled = true;
                txtMaCTPX.Text = "";
                txtMaPX.Text = "";
                txtSoLuong.Text = "";
                txtMaKho.Text = "";
                txtMaKeSach.Text = "";
                txtMaDauSach.Text = "";
            }
        }

        private void btnUpdateCTPN_Click(object sender, EventArgs e)
        {
            int mactpn = Convert.ToInt32(txtMaCTPX.Text);
            int mapn = Convert.ToInt32(txtMaPX.Text);
            int soluong = Convert.ToInt32(txtSoLuong.Text);
            int makho = Convert.ToInt32(txtMaKho.Text);
            int mancc = Convert.ToInt32(txtMaKeSach.Text);
            int madausach = Convert.ToInt32(txtMaDauSach.Text);

            KHO_DAL.Instance.UpdateCTPhieuXuat(mactpn, mapn, makho, mancc, soluong, madausach);

            dtgvCTPhieuXuat.DataSource = KHO_DAL.Instance.GetListCTPhieuXuat(mapn);
        }

        private void btnDeleteCTPN_Click(object sender, EventArgs e)
        {
            int mapn = Convert.ToInt32(txtMaPX.Text);
            int mactpn = Convert.ToInt32(txtMaCTPX.Text);
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa không", "Warning", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                KHO_DAL.Instance.DeleteCTPhieuXuat(mactpn);
                dtgvCTPhieuXuat.DataSource = KHO_DAL.Instance.GetListCTPhieuXuat(mapn);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            txtMaCTPX.Enabled = true;
            txtMaCTPX.Text = "";
            txtMaPX.Text = "";
            txtSoLuong.Text = "";
            txtMaKho.Text = "";
            txtMaKeSach.Text = "";
            txtMaDauSach.Text = "";
            txtTimKiem.Text = "";

            dtgvPhieuXuat.DataSource = KHO_DAL.Instance.GetListPhieuXuat();


        }

        private void InPX_Click(object sender, EventArgs e)
        {
            //  khởi tạo excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // khởi tạo WorkBook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // khởi tạo WorkSheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            app.Visible = true;

            // đinh dạng côt

            worksheet.Range["A1"].ColumnWidth = 4;  // STT
            worksheet.Range["B1"].ColumnWidth = 8;  // mã px
            worksheet.Range["C1"].ColumnWidth = 20;   // mã ctpx
            worksheet.Range["D1"].ColumnWidth = 20;   // tên kho
            worksheet.Range["E1"].ColumnWidth = 8;  // mã kho
            worksheet.Range["F1"].ColumnWidth = 26;  //  tên ncc
            worksheet.Range["G1"].ColumnWidth = 8;   // mã ncc
            worksheet.Range["H1"].ColumnWidth = 10;  // số lượng 
            worksheet.Range["I1"].ColumnWidth = 26; // tên đầu sách
            worksheet.Range["J1"].ColumnWidth = 6;  // mã đầu sách

            // đinh dạng  FONT
            worksheet.Range["A1", "M1"].Font.Size = 18;
            worksheet.Range["A1", "M1"].MergeCells = true;
            worksheet.Range["A1", "M5"].Font.Bold = true;
            // ĐỔ dữ liệu vào Sheet:
            worksheet.Cells[1, 1] = "BÁO CÁO TỔNG HỢP Xuất KHO";
            worksheet.Cells[3, 4] = "Nhân Viên : " + txtTenNV.Text;
            worksheet.Cells[3, 8] = "Mã Nhân Viên: " + txtMaNV.Text;

            worksheet.Cells[8, 1] = "STT";
            worksheet.Cells[8, 2] = "Mã Phiếu Xuất";
            worksheet.Cells[8, 3] = "Mã CT Phiếu Xuất";
            worksheet.Cells[8, 4] = "Tên Kho";
            worksheet.Cells[8, 5] = "Mã Kho";
            worksheet.Cells[8, 6] = "Tên kệ sách";
            worksheet.Cells[8, 7] = "Mã kệ sách";
            worksheet.Cells[8, 8] = "Số Lượng";
            worksheet.Cells[8, 9] = "Tên Đầu Sách";
            worksheet.Cells[8, 10] = "Mã Đầu Sách";

            //int Mapn = Convert.ToInt32(dtgvCTPhieuXuat.CurrentRow.Cells["MaPN"].Value);

            for (int i = 0; i <= dtgvCTPhieuXuat.RowCount - 1; i++)
            {
                worksheet.Cells[i + 9, 1] = i + 1;
                for (int j = 0; j < 9; ++j)
                {

                    worksheet.Cells[i + 9, j + 2] = dtgvCTPhieuXuat.Rows[i].Cells[j].Value;
                }
            }
            //int index = dtgvCTPhieuNhap.RowCount + 9;
        }
    }
}
