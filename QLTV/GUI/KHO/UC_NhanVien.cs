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
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
        }

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            dtgvNhanVien.DataSource = KHO_DAL.Instance.GetListNhanVien();
        }


        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvNhanVien.CurrentRow.Selected = true;
            txtMaNV.Text = dtgvNhanVien.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txtTenNV.Text = dtgvNhanVien.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            txtMaKho.Text = dtgvNhanVien.CurrentRow.Cells["MaKho"].Value.ToString();

            txtMaNV.Enabled = false;
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Enabled)
            {
                int manv = Convert.ToInt32(txtMaNV.Text);
                string tennv = txtTenNV.Text.ToString();
                int makho = Convert.ToInt32(txtMaKho.Text);
                KHO_DAL.Instance.InsertNhanVien(manv, tennv, makho);

                dtgvNhanVien.DataSource = KHO_DAL.Instance.GetListNhanVien();
            }
            else
            {
                txtMaNV.Enabled = true;
                txtMaNV.Text = "";
                txtTenNV.Text = "";
                txtMaKho.Text = "";

            }
                
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            int manv = Convert.ToInt32(txtMaNV.Text);
            string tennv = txtTenNV.Text.ToString();
            int makho = Convert.ToInt32(txtMaKho.Text);
            KHO_DAL.Instance.UpdateNhanVien(manv,tennv, makho);

            dtgvNhanVien.DataSource = KHO_DAL.Instance.GetListNhanVien();
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {

            int manv = Convert.ToInt32(txtMaNV.Text);
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa không", "Warning", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                KHO_DAL.Instance.DeleteNhanVien(manv);
                dtgvNhanVien.DataSource = KHO_DAL.Instance.GetListNhanVien();
            }
                
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = true;
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtMaKho.Text = "";
            txtTimKiem.Text = "";
            dtgvNhanVien.DataSource = KHO_DAL.Instance.GetListNhanVien();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkTen.Checked)
            {
                string tennv = txtTimKiem.Text;
                dtgvNhanVien.DataSource = KHO_DAL.Instance.SearchNhanVienByName(tennv);
            }
            else if (checkMa.Checked)
            {
                int manv = Convert.ToInt32(txtTimKiem.Text);
                dtgvNhanVien.DataSource = KHO_DAL.Instance.SearchNhanVienByID(manv);
            }
            else
                MessageBox.Show("Mời bạn chọn tìm kiếm theo Mã Kho hay Ngày Nhập Kho", "Thông báo", MessageBoxButtons.OK);

        }
    }
}
