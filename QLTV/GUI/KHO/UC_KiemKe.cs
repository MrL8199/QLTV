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
    public partial class UC_KiemKe : UserControl
    {
        public UC_KiemKe()
        {
            InitializeComponent();
        }

        private void UC_KiemKe_Load(object sender, EventArgs e)
        {
            dtgvKiemKe.DataSource = KHO_DAL.Instance.GetListPhieuKiemKe();
        }

        private void dtgvKiemKe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvKiemKe.CurrentRow.Selected = true;
            txtMaPhieuKK.Text = dtgvKiemKe.CurrentRow.Cells["MaPhieuKiemKe"].Value.ToString();
            txtMaKho.Text = dtgvKiemKe.CurrentRow.Cells["MaKho"].Value.ToString();
            dtNgayKK.Value = (DateTime)dtgvKiemKe.CurrentRow.Cells["NgayKiemKe"].Value;

            txtMaPhieuKK.Enabled = false;
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkNgay.Checked)
            {
                string ngaytk = txtTimKiem.Text;
                dtgvKiemKe.DataSource = KHO_DAL.Instance.SearchPhieuKiemKeTheoNgay(ngaytk);
            }
            else if (checkMa.Checked)
            {
                int mapkk = Convert.ToInt32(txtTimKiem.Text);
                dtgvKiemKe.DataSource = KHO_DAL.Instance.SearchPhieuKiemKeTheoMaPKK(mapkk);
            }
            else
                MessageBox.Show("Mời bạn chọn tìm kiếm theo Mã Phiếu kiểm kê hay Ngày kiểm kê", "Thông báo", MessageBoxButtons.OK);

        }

        private void btnAddPKK_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuKK.Enabled)
            {
                //int mapkk = Convert.ToInt32(txtMaPhieuKK.Text);
                DateTime ngaykk = (DateTime)(dtNgayKK.Value);
                int makho = Convert.ToInt32(txtMaKho.Text);


                KHO_DAL.Instance.InsertCTPhieuKiemKe(ngaykk, makho);

                dtgvKiemKe.DataSource = KHO_DAL.Instance.GetListPhieuKiemKe();
            }
            else
            {
                txtMaPhieuKK.Enabled = true;
                txtMaPhieuKK.Text = "";
                dtNgayKK.Value = DateTime.Now;
                txtMaKho.Text = "";
            }
        }


        private void btnDeletePKK_Click(object sender, EventArgs e)
        {

            int mapkk = Convert.ToInt32(txtMaPhieuKK.Text);
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa không", "Warning", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                KHO_DAL.Instance.DeleteCTPhieuKiemKe(mapkk);
                dtgvKiemKe.DataSource = KHO_DAL.Instance.GetListPhieuKiemKe();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            txtMaPhieuKK.Enabled = false;
            txtMaPhieuKK.Text = "";
            txtMaKho.Text = "";
            txtTimKiem.Text = "";
            dtgvKiemKe.DataSource = KHO_DAL.Instance.GetListPhieuKiemKe();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void InPKK_Click(object sender, EventArgs e)
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
            worksheet.Cells[1, 1] = "BÁO CÁO TỔNG HỢP Kiểm Kê KHO";
            worksheet.Cells[3, 3] = "Nhân Viên : " + txtTenNV.Text;
            worksheet.Cells[3, 5] = "Mã Nhân Viên: " + txtMaNV.Text;

            worksheet.Cells[8, 1] = "STT";
            worksheet.Cells[8, 2] = "Mã Phiếu Kiểm Kê";
            worksheet.Cells[8, 3] = "Ngày Kiểm Kê";
            worksheet.Cells[8, 4] = "Mã Kho";
            worksheet.Cells[8, 5] = "Tên Kho";
            worksheet.Cells[8, 6] = "SL Đầu";
            worksheet.Cells[8, 7] = "SL Cuối";

            //int Mapn = Convert.ToInt32(dtgvCTPhieuXuat.CurrentRow.Cells["MaPN"].Value);

            for (int i = 0; i <= dtgvKiemKe.RowCount - 1; i++)
            {
                worksheet.Cells[i + 9, 1] = i + 1;
                for (int j = 0; j < 6; ++j)
                {

                    worksheet.Cells[i + 9, j + 2] = dtgvKiemKe.Rows[i].Cells[j].Value;
                }
            }
            //int index = dtgvCTPhieuNhap.RowCount + 9;
        }
    }
}
