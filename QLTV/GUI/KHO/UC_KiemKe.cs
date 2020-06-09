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
    }
}
