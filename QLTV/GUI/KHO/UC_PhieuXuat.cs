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
                MessageBox.Show("Mời bạn chọn tìm kiếm theo Mã phiếu hay Ngày Nhập phiếu", "Thông báo", MessageBoxButtons.OK);

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
    }
}
