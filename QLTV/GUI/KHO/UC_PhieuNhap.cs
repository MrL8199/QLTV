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

            txtMaCTPN.Enabled=false;
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

            KHO_DAL.Instance.UpdateCTPhieuNhap(mactpn,mapn,makho,mancc, soluong, madausach);

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
    }
}
