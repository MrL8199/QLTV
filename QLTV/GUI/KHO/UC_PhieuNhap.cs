using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.DAL;

namespace QLTV.GUI.KHO
{
    public partial class UC_PhieuNhap : UserControl
    {
        public UC_PhieuNhap()
        {
            InitializeComponent();
        }

        private void UC_PhieuNhap_Load(object sender, EventArgs e)
        {
            dtgvPhieuNhap.DataSource = KHO_DAL.Instance.GetListPhieuNhap(); //// Phương thức gọi ra List....();

        }

        private void dtgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dtgvPhieuNhap.CurrentRow.Selected = true;

            int Mapn = Convert.ToInt32(dtgvPhieuNhap.CurrentRow.Cells["MaPN"].Value);
            dtgvCTPhieuNhap.DataSource = KHO_DAL.Instance.GetListCTPhieuNhap(Mapn);


        }

        private void dtgvCTPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvCTPhieuNhap.CurrentRow.Selected = true;
            txtMaCTPN.Text = dtgvCTPhieuNhap.CurrentRow.Cells["MaCTPN"].Value.ToString();
            txtMaPN.Text = dtgvCTPhieuNhap.CurrentRow.Cells["MaPN"].Value.ToString();
            txtSoLuong.Text = dtgvCTPhieuNhap.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtMaKho.Text = dtgvCTPhieuNhap.CurrentRow.Cells["MaKho"].Value.ToString();
            txtMaNCC.Text = dtgvCTPhieuNhap.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtMaDauSach.Text = dtgvCTPhieuNhap.CurrentRow.Cells["MaDauSach"].Value.ToString();

            txtMaCTPN.Enabled = false;
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkNgay.Checked)
            {
                string ngaytk = txtTimKiem.Text;
                dtgvPhieuNhap.DataSource = KHO_DAL.Instance.SearchPhieuNhapTheoNgay(ngaytk);
            }
            else if (checkMaPN.Checked)
            {
                int mapn = Convert.ToInt32(txtTimKiem.Text);
                dtgvCTPhieuNhap.DataSource = KHO_DAL.Instance.SearchPhieuNhapTheoMaPN(mapn);
            }
            else
                MessageBox.Show("Mời bạn chọn tìm kiếm theo Mã Kho hay Ngày Nhập Kho", "Thông báo", MessageBoxButtons.OK);

        }

        private void btnAddCTPN_Click(object sender, EventArgs e)
        {
            if (txtMaCTPN.Enabled)
            {
                //int mactpn = Convert.ToInt32(txtMaCTPN.Text);
                int mapn = Convert.ToInt32(txtMaPN.Text);
                int soluong = Convert.ToInt32(txtSoLuong.Text);
                int makho = Convert.ToInt32(txtMaKho.Text);
                int mancc = Convert.ToInt32(txtMaNCC.Text);
                int madausach = Convert.ToInt32(txtMaDauSach.Text);

                KHO_DAL.Instance.InsertCTPhieuNhap(mapn, makho, mancc, soluong, madausach);

                dtgvCTPhieuNhap.DataSource = KHO_DAL.Instance.GetListCTPhieuNhap(mapn);
            }
            else
            {
                txtMaCTPN.Enabled = true;
                txtMaCTPN.Text = "";
                txtMaPN.Text = "";
                txtSoLuong.Text = "";
                txtMaKho.Text = "";
                txtMaNCC.Text = "";
                txtMaDauSach.Text = "";
            }
        }

        private void btnUpdateCTPN_Click(object sender, EventArgs e)
        {
            int mactpn = Convert.ToInt32(txtMaCTPN.Text);
            int mapn = Convert.ToInt32(txtMaPN.Text);
            int soluong = Convert.ToInt32(txtSoLuong.Text);
            int makho = Convert.ToInt32(txtMaKho.Text);
            int mancc = Convert.ToInt32(txtMaNCC.Text);
            int madausach = Convert.ToInt32(txtMaDauSach.Text);

            KHO_DAL.Instance.UpdateCTPhieuNhap(mactpn, mapn, makho, mancc, soluong, madausach);

            dtgvCTPhieuNhap.DataSource = KHO_DAL.Instance.GetListCTPhieuNhap(mapn);
        }

        private void btnDeleteCTPN_Click(object sender, EventArgs e)
        {
            int mapn = Convert.ToInt32(txtMaPN.Text);
            int mactpn = Convert.ToInt32(txtMaCTPN.Text);
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa không", "Warning", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                KHO_DAL.Instance.DeleteCTPhieuNhap(mactpn);
                dtgvCTPhieuNhap.DataSource = KHO_DAL.Instance.GetListCTPhieuNhap(mapn);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            txtMaCTPN.Enabled = true;
            txtMaCTPN.Text = "";
            txtMaPN.Text = "";
            txtSoLuong.Text = "";
            txtMaKho.Text = "";
            txtMaNCC.Text = "";
            txtMaDauSach.Text = "";

        }


        private void InPN_Click(object sender, EventArgs e)
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
            worksheet.Range["B1"].ColumnWidth = 8;  // mã pn
            worksheet.Range["C1"].ColumnWidth = 20;   // mã ctpn
            worksheet.Range["D1"].ColumnWidth = 20;   // tên kho
            worksheet.Range["E1"].ColumnWidth = 8;  // mã kho
            worksheet.Range["F1"].ColumnWidth = 26;  //  tên ncc
            worksheet.Range["G1"].ColumnWidth = 8;   // mã ncc
            worksheet.Range["H1"].ColumnWidth = 10;  // số lượng 
            worksheet.Range["I1"].ColumnWidth = 26;  // Tên đầu sách
            worksheet.Range["J1"].ColumnWidth = 10;  // Mã đầu sách

            // đinh dạng  FONT
            worksheet.Range["A1", "M1"].Font.Size = 18;
            worksheet.Range["A1", "M1"].MergeCells = true;
            worksheet.Range["A1", "M5"].Font.Bold = true;
            // ĐỔ dữ liệu vào Sheet:
            worksheet.Cells[1, 1] = "BÁO CÁO TỔNG HỢP NHẬP KHO";
            worksheet.Cells[3, 4] = "Nhân Viên : " + txtTenNV.Text;
            worksheet.Cells[3, 8] = "Mã Nhân Viên: " + txtMaNV.Text;

            worksheet.Cells[8, 1] = "STT";
            worksheet.Cells[8, 2] = "Mã Phiếu Nhập";
            worksheet.Cells[8, 3] = "Mã CT Phiếu Nhập";
            worksheet.Cells[8, 4] = "Tên Kho";
            worksheet.Cells[8, 5] = "Mã Kho";
            worksheet.Cells[8, 6] = "Tên NCC";
            worksheet.Cells[8, 7] = "Mã NCC";
            worksheet.Cells[8, 8] = "Số Lượng";
            worksheet.Cells[8, 9] = "Tên Đầu Sách";
            worksheet.Cells[8, 10] = "Mã Đầu Sách";

            //int Mapn = Convert.ToInt32(dtgvCTPhieuNhap.CurrentRow.Cells["MaPN"].Value);
                
                for (int i = 0; i <= dtgvCTPhieuNhap.RowCount - 1; i++)
                {
                worksheet.Cells[i + 9, 1] = i + 1;
                        for (int j = 0; j < 9; ++j)
                        {

                            worksheet.Cells[i + 9, j + 2] = dtgvCTPhieuNhap.Rows[i].Cells[j].Value;
                        }
                }
            //int index = dtgvCTPhieuNhap.RowCount + 9;

        }
    }
}
