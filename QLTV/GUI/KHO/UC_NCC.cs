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
    public partial class UC_NCC : UserControl
    {
        public UC_NCC()
        {
            InitializeComponent();
        }

        private void UC_NCC_Load(object sender, EventArgs e)
        {
            dtgvNCC.DataSource = KHO_DAL.Instance.GetListNCC();
        }
        private void dtgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvNCC.CurrentRow.Selected = true;
            txtMaNCC.Text = dtgvNCC.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtTenNCC.Text = dtgvNCC.CurrentRow.Cells["TenNCC"].Value.ToString();
            txtDiaChi.Text = dtgvNCC.CurrentRow.Cells["DiaChiNCC"].Value.ToString();
            txtSDT.Text = dtgvNCC.CurrentRow.Cells["SDT_NCC"].Value.ToString();

            txtMaNCC.Enabled = false;
        }

        private void btnAddNCC_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Enabled)
            {
                int mancc = Convert.ToInt32(txtMaNCC.Text);
                string tenncc = txtTenNCC.Text.ToString();
                string diachi = txtDiaChi.Text.ToString();
                int SDT = Convert.ToInt32(txtSDT.Text);
                KHO_DAL.Instance.InsertNCC(mancc, tenncc,diachi, SDT);

                dtgvNCC.DataSource = KHO_DAL.Instance.GetListNCC();
            }
            else
            {
                txtMaNCC.Enabled = true;
                txtMaNCC.Text = "";
                txtTenNCC.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";

            }

        }

        private void btnUpdateNCC_Click(object sender, EventArgs e)
        {
            int mancc = Convert.ToInt32(txtMaNCC.Text);
            string tenncc = txtTenNCC.Text.ToString();
            string diachi = txtDiaChi.Text.ToString();
            int SDT = Convert.ToInt32(txtSDT.Text);
            KHO_DAL.Instance.UpdateNCC(mancc, tenncc,diachi, SDT);

            dtgvNCC.DataSource = KHO_DAL.Instance.GetListNCC();
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {

            int mancc = Convert.ToInt32(txtMaNCC.Text);
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa không", "Warning", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                KHO_DAL.Instance.DeleteNCC(mancc);
                dtgvNCC.DataSource = KHO_DAL.Instance.GetListNCC();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = true;
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTimKiem.Text = "";

            dtgvNCC.DataSource = KHO_DAL.Instance.GetListNCC();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkTen.Checked)
            {
                string tenncc = txtTimKiem.Text;
                dtgvNCC.DataSource = KHO_DAL.Instance.SearchNCCByName(tenncc);
            }
            else if (checkMa.Checked)
            {
                int mancc = Convert.ToInt32(txtTimKiem.Text);
                dtgvNCC.DataSource = KHO_DAL.Instance.SearchNCCByID(mancc);
            }
            else
                MessageBox.Show("Mời bạn chọn tìm kiếm theo Mã nhà cung cấp hay tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK);

        }

    }
}
