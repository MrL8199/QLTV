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
using System.Text.RegularExpressions;

namespace QLTV.GUI.SACH
{
    public partial class Form1 : Form
    {
        private int themMoi;

        public Form1()
        {
            InitializeComponent();
        }

        private void btThemTG_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemTacGia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKeywordTacGia.Text))
            {
                dtgv_dsTacGia.DataSource = DAL.Sach_DAL.Instance.GetListTacGia();
                return;
            }
            if (rdbMaTG.Checked)
            {
                if (Regex.IsMatch(tbKeywordTacGia.Text, @"[0-9]"))
                    dtgv_dsTacGia.DataSource = DAL.Sach_DAL.Instance.SearchTacGiaByID(Convert.ToInt32(tbKeywordTacGia.Text));
            }
            if (rdbTenTG.Checked)
            {
                dtgv_dsTacGia.DataSource = DAL.Sach_DAL.Instance.SearchTacGiaByName(tbKeywordTacGia.Text);
            }
        }

        private void dtgv_dsTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaTG.Text = dtgv_dsTacGia.CurrentRow.Cells["MaTacGia"].Value.ToString();
            tbTenTG.Text = dtgv_dsTacGia.CurrentRow.Cells["TenTacGia"].Value.ToString();
        }

        private void btnThemTG_Click(object sender, EventArgs e)
        {
            btnLuuTG.Enabled = true;
            btnHuyTG.Enabled = true;
            btnThemTG.Enabled = false;
            btnSuaTG.Enabled = false;
            btnXoaTG.Enabled = false;

            this.themMoi = 1;
        }

        private void btnSuaTG_Click(object sender, EventArgs e)
        {
            btnLuuTG.Enabled = true;
            btnHuyTG.Enabled = true;
            btnThemTG.Enabled = false;
            btnSuaTG.Enabled = false;
            btnXoaTG.Enabled = false;

            this.themMoi = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;
            groupBox8.Enabled = true;
            groupBox10.Enabled = true;

            btnLuuTG.Enabled = true;
            btnHuyTG.Enabled = true;
            btnThemTG.Enabled = false;
            btnSuaTG.Enabled = false;
            btnXoaTG.Enabled = false;

            this.themMoi = 0;
        }

        public void ClearTextBoxes(Form Frm)
        {
            foreach (Control Ctl in Frm.Controls)
            {
                if (Ctl is TextBox)
                    Ctl.Text = "";

                if (Ctl is TabControl)
                {
                    foreach (Control Ctl1 in Ctl.Controls)
                    {
                        if (Ctl1 is TextBox)
                            Ctl1.Text = "";

                        if (Ctl1 is GroupBox)
                        {
                            foreach (Control Ctl2 in Ctl1.Controls)
                            {
                                if (Ctl2 is TextBox)
                                    Ctl2.Text = "";
                            }
                        }

                        if (Ctl1 is TabPage)
                        {
                            foreach (Control Ctl2 in Ctl1.Controls)
                            {
                                if (Ctl2 is GroupBox)
                                {
                                    foreach (Control Ctl3 in Ctl2.Controls)
                                    {
                                        if (Ctl3 is TextBox)
                                            Ctl3.Text = "";
                                    }
                                }
                                if (Ctl2 is TextBox)
                                    Ctl2.Text = "";
                            }
                        }
                    }
                }
            }
        }

        public void DisableBtnEdit(Form Frm)
        {
            foreach (Control Ctl in Frm.Controls)
            {
                if (Ctl is TextBox)
                    Ctl.Text = "";

                if (Ctl is TabControl)
                {
                    foreach (Control Ctl1 in Ctl.Controls)
                    {
                        if (Ctl1 is TabPage)
                        {
                            foreach (Control Ctl2 in Ctl1.Controls)
                            {
                                if (Ctl2 is Button)
                                {
                                    if (Ctl2.Text == "Lưu" || Ctl2.Text == "Hủy")
                                    {
                                        Ctl2.Enabled = true;
                                    }
                                    else
                                    {
                                        Ctl2.Enabled = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void UnDisableBtnEdit(Form Frm)
        {
            foreach (Control Ctl in Frm.Controls)
            {
                if (Ctl is TextBox)
                    Ctl.Text = "";

                if (Ctl is TabControl)
                {
                    foreach (Control Ctl1 in Ctl.Controls)
                    {
                        if (Ctl1 is TabPage)
                        {
                            foreach (Control Ctl2 in Ctl1.Controls)
                            {
                                if (Ctl2 is Button)
                                {
                                    if (Ctl2.Text == "Lưu" || Ctl2.Text == "Hủy")
                                    {
                                        Ctl2.Enabled = false;
                                    }
                                    else
                                    {
                                        Ctl2.Enabled = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;
            groupBox8.Enabled = true;
            groupBox10.Enabled = true;

            ClearTextBoxes(this);
            DisableBtnEdit(this);

            btnLuuTG.Enabled = true;
            btnHuyTG.Enabled = true;
            btnThemTG.Enabled = false;
            btnSuaTG.Enabled = false;
            btnXoaTG.Enabled = false;

            this.themMoi = 1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.themMoi = 0;

            groupBox1.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            groupBox8.Enabled = false;
            groupBox10.Enabled = false;

            ClearTextBoxes(this);
            UnDisableBtnEdit(this);

            btnLuuTG.Enabled = false;
            btnHuyTG.Enabled = false;
            btnThemTG.Enabled = true;
            btnSuaTG.Enabled = true;
            btnXoaTG.Enabled = true;
        }

        private void btnXoaTG_Click(object sender, EventArgs e)
        {            
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            bool result = false;

            if (dialogResult == DialogResult.OK)
            {
                // đồng ý xóa: xóa trong db rồi refresh dtgv
                switch (TabPage.GetTabPageOfComponent((Control)sender).Text)
                {
                    case "Tác Giả ":
                        {
                            result = DAL.Sach_DAL.Instance.DeleteTacGia(Convert.ToInt32(dtgv_dsTacGia.CurrentRow.Cells["MaTacGia"].Value));
                            break;
                        }
                    case "NXB":
                        {
                            result = DAL.Sach_DAL.Instance.DeleteNXB(Convert.ToInt32(dtgv_NXB.CurrentRow.Cells["MaNXB"].Value));
                            break;
                        }
                    case "Thể Loại":
                        {
                            result = DAL.Sach_DAL.Instance.DeleteTheLoai(Convert.ToInt32(dtgv_TheLoai.CurrentRow.Cells["MaKeSach"].Value));
                            break;
                        }
                    case "Đầu Sách ":
                        {
                            result = DAL.Sach_DAL.Instance.DeleteDauSach(Convert.ToInt32(dtgv_DauSach.CurrentRow.Cells["MaDauSach"].Value));
                            break;
                        }
                    case "Cuốn Sách":
                        {
                            result = DAL.Sach_DAL.Instance.DeleteCuonSach(Convert.ToInt32(dtgv_CuonSach.CurrentRow.Cells["MaCuonSach"].Value));
                            break;
                        }
                    default:
                        result = false;
                        break;
                }
                if (result)
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //cancel xóa
            }
        }

        private void btnLuuTG_Click(object sender, EventArgs e)
        {
            switch (TabPage.GetTabPageOfComponent((Control)sender).Text)
            {
                case "Tác Giả ":
                    {
                        #region save thông tin mới update
                        if (this.themMoi == 1)
                        {
                            DAL.Sach_DAL.Instance.InsertTacGia(
                                Convert.ToInt32(tbMaTG.Text),
                                tbTenTG.Text
                            );
                        }
                        else
                        {
                            DAL.Sach_DAL.Instance.UpdateTacGia(
                                Convert.ToInt32(tbMaTG.Text),
                                tbTenTG.Text
                            );
                        }

                        #endregion
                        break;
                    }
                case "NXB":
                    {
                        #region save thông tin mới update
                        if (this.themMoi == 1)
                        {
                            DAL.Sach_DAL.Instance.InsertNXB(
                                Convert.ToInt32(tbMaNXB.Text),
                                tbTenNXB.Text,
                                tbDiaChiNXB.Text,
                                Convert.ToInt32(tbSdtNXB.Text)
                            );
                        }
                        else
                        {
                            DAL.Sach_DAL.Instance.UpdateNXB(
                                Convert.ToInt32(tbMaNXB.Text),
                                tbTenNXB.Text,
                                tbDiaChiNXB.Text,
                                Convert.ToInt32(tbSdtNXB.Text)
                            );
                        }

                        #endregion
                        break;
                    }
                case "Thể Loại":
                    {
                        #region save thông tin mới update
                        if (this.themMoi == 1)
                        {
                            DAL.Sach_DAL.Instance.InsertTheLoai(
                                Convert.ToInt32(tbMaKeSach.Text),
                                tbTenTheLoai.Text
                            );
                        }
                        else
                        {
                            DAL.Sach_DAL.Instance.UpdateTheLoai(
                                Convert.ToInt32(tbMaKeSach.Text),
                                tbTenTheLoai.Text
                            );
                        }

                        #endregion
                        break;
                    }
                case "Đầu Sách ":
                    {
                        #region save thông tin mới update
                        if (this.themMoi == 1)
                        {
                            DAL.Sach_DAL.Instance.InsertDauSach(
                                Convert.ToInt32(tbMaDauSach.Text),
                                tbTenDauSach.Text,
                                Convert.ToInt32(tbMaNXB_DauSach.Text)
                            );
                        }
                        else
                        {
                            DAL.Sach_DAL.Instance.UpdateDauSach(
                                Convert.ToInt32(tbMaDauSach.Text),
                                tbTenDauSach.Text,
                                Convert.ToInt32(tbMaNXB_DauSach.Text)
                            );
                        }

                        #endregion
                        break;
                    }
                case "Cuốn Sách":
                    {
                        #region save thông tin mới update
                        if (this.themMoi == 1)
                        {
                            DAL.Sach_DAL.Instance.InsertCuonSach(
                                Convert.ToInt32(tbMaCuonSach.Text),
                                tbTenCuonSach.Text,
                                Convert.ToInt32(tbSoTrang.Text),
                                tbTinhTrang.Text,
                                Convert.ToInt32(tbMaDauSach_CuonSach.Text),
                                Convert.ToInt32(tbMaKeSach_CuonSach.Text)
                            );
                        }
                        else
                        {
                            DAL.Sach_DAL.Instance.UpdateCuonSach(
                                Convert.ToInt32(tbMaCuonSach.Text),
                                tbTenCuonSach.Text,
                                Convert.ToInt32(tbSoTrang.Text),
                                tbTinhTrang.Text,
                                Convert.ToInt32(tbMaDauSach_CuonSach.Text),
                                Convert.ToInt32(tbMaKeSach_CuonSach.Text)
                            );
                        }

                        #endregion
                        break;
                    }
                default:
                    break;
            }

            this.themMoi = 0;

            // save thông tin mới update
            groupBox1.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            groupBox8.Enabled = false;
            groupBox10.Enabled = false;

            ClearTextBoxes(this);
            UnDisableBtnEdit(this);

            btnLuuTG.Enabled = false;
            btnHuyTG.Enabled = false;
            btnThemTG.Enabled = true;
            btnSuaTG.Enabled = true;
            btnXoaTG.Enabled = true;

            dtgv_dsTacGia.DataSource = DAL.Sach_DAL.Instance.GetListTacGia();
            dtgv_DauSach.DataSource = DAL.Sach_DAL.Instance.GetListDauSach();
            dtgv_NXB.DataSource = DAL.Sach_DAL.Instance.GetListNXB();
            dtgv_TheLoai.DataSource = DAL.Sach_DAL.Instance.GetListTheLoai();
            dtgv_CuonSach.DataSource = DAL.Sach_DAL.Instance.GetListCuonSach();
            dtgv_dsTacGia.Refresh();
            dtgv_CuonSach.Refresh();
            dtgv_DauSach.Refresh();
            dtgv_NXB.Refresh();
            dtgv_TheLoai.Refresh();

            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuyTG_Click(object sender, EventArgs e)
        {
            btnLuuTG.Enabled = false;
            btnHuyTG.Enabled = false;
            btnThemTG.Enabled = true;
            btnSuaTG.Enabled = true;
            btnXoaTG.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UnDisableBtnEdit(this);
            dtgv_dsTacGia.DataSource = DAL.Sach_DAL.Instance.GetListTacGia();
            dtgv_DauSach.DataSource = DAL.Sach_DAL.Instance.GetListDauSach();
            dtgv_NXB.DataSource = DAL.Sach_DAL.Instance.GetListNXB();
            dtgv_TheLoai.DataSource = DAL.Sach_DAL.Instance.GetListTheLoai();
            dtgv_CuonSach.DataSource = DAL.Sach_DAL.Instance.GetListCuonSach();
        }

        private void btnTimKiemNXB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKeywordNXB.Text))
            {
                dtgv_NXB.DataSource = DAL.Sach_DAL.Instance.GetListNXB();
                return;
            }
            if (radioButton8.Checked)
            {
                if (Regex.IsMatch(tbKeywordNXB.Text, @"[0-9]"))
                    dtgv_NXB.DataSource = DAL.Sach_DAL.Instance.SearchNXBByID(Convert.ToInt32(tbKeywordNXB.Text));
            }
            if (radioButton7.Checked)
            {
                dtgv_NXB.DataSource = DAL.Sach_DAL.Instance.SearchNXBByName(tbKeywordNXB.Text);
            }
        }

        private void btnTimKiemTheloai_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKeywordTheLoai.Text))
            {
                dtgv_TheLoai.DataSource = DAL.Sach_DAL.Instance.GetListTheLoai();
                return;
            }
            if (radioButton6.Checked)
            {
                if (Regex.IsMatch(tbKeywordTheLoai.Text, @"[0-9]")) ;
                    //dtgv_TheLoai.DataSource = DAL.Sach_DAL.Instance.search(Convert.ToInt32(tbKeywordTheLoai.Text));
            }
            if (radioButton5.Checked)
            {
                dtgv_TheLoai.DataSource = DAL.Sach_DAL.Instance.SearchTheLoaiByName(tbKeywordTheLoai.Text);
            }
        }

        private void btnTimKiemDauSach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKeywordDauSach.Text))
            {
                dtgv_DauSach.DataSource = DAL.Sach_DAL.Instance.GetListDauSach();
                return;
            }
            if (radioButton4.Checked)
            {
                if (Regex.IsMatch(tbKeywordDauSach.Text, @"[0-9]"))
                    dtgv_DauSach.DataSource = DAL.Sach_DAL.Instance.SearchDauSachByID(Convert.ToInt32(tbKeywordDauSach.Text));
            }
            if (radioButton3.Checked)
            {
                dtgv_DauSach.DataSource = DAL.Sach_DAL.Instance.SearchDauSachByName(tbKeywordDauSach.Text);
            }
        }

        private void btnTimKiemCuonSach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKeywordCuonSach.Text))
            {
                dtgv_CuonSach.DataSource = DAL.Sach_DAL.Instance.GetListCuonSach();
                return;
            }
            if (radioButton1.Checked)
            {
                if (Regex.IsMatch(tbKeywordCuonSach.Text, @"[0-9]"))
                    dtgv_CuonSach.DataSource = DAL.Sach_DAL.Instance.SearchSachByID(Convert.ToInt32(tbKeywordCuonSach.Text));
            }
            if (radioButton2.Checked)
            {
                dtgv_CuonSach.DataSource = DAL.Sach_DAL.Instance.SearchSachByName(tbKeywordCuonSach.Text);
            }
        }

        private void dtgv_NXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaNXB.Text = dtgv_NXB.CurrentRow.Cells["MaNXB"].Value.ToString();
            tbTenNXB.Text = dtgv_NXB.CurrentRow.Cells["TenNXB"].Value.ToString();
            tbDiaChiNXB.Text = dtgv_NXB.CurrentRow.Cells["DiaChiNXB"].Value.ToString();
            tbSdtNXB.Text = dtgv_NXB.CurrentRow.Cells["SDT"].Value.ToString();
        }

        private void dtgv_TheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaKeSach.Text = dtgv_TheLoai.CurrentRow.Cells["MaKeSach"].Value.ToString();
            tbTenTheLoai.Text = dtgv_TheLoai.CurrentRow.Cells["TenTheLoai"].Value.ToString();
        }

        private void dtgv_DauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaDauSach.Text = dtgv_DauSach.CurrentRow.Cells["MaDauSach"].Value.ToString();
            tbTenDauSach.Text = dtgv_DauSach.CurrentRow.Cells["TenDauSach"].Value.ToString();
            tbMaNXB_DauSach.Text = dtgv_DauSach.CurrentRow.Cells["MaNXB"].Value.ToString();
        }

        private void dtgv_CuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaCuonSach.Text = dtgv_CuonSach.CurrentRow.Cells["MaCuonSach"].Value.ToString();
            tbTenCuonSach.Text = dtgv_CuonSach.CurrentRow.Cells["TenSach"].Value.ToString();
            tbSoTrang.Text = dtgv_CuonSach.CurrentRow.Cells["SoTrang"].Value.ToString();
            tbTinhTrang.Text = dtgv_CuonSach.CurrentRow.Cells["TinhTrangCuonSach"].Value.ToString();
            tbMaDauSach_CuonSach.Text = dtgv_CuonSach.CurrentRow.Cells["MaDauSach"].Value.ToString();
            tbMaKeSach_CuonSach.Text = dtgv_CuonSach.CurrentRow.Cells["MaKeSach"].Value.ToString();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                //dtgv_thongke.DataSource = DAL.Sach_DAL.Instance.();
            }
            else
            {
                //dtgv_thongke.DataSource = DAL.Sach_DAL.Instance.ThongkeSach();
            }
        }
    }
}
