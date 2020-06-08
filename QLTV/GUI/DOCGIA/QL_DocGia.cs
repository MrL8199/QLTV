using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.GUI.DOCGIA
{
    public partial class QL_DocGia : Form
    {
        private int themMoi = 0;

        public QL_DocGia()
        {
            InitializeComponent();
        }

        private void QL_DocGia_Load(object sender, EventArgs e)
        {
            dtgv_docgia.DataSource = DAL.DocGia_DAL.Instance.GetListDocGia();
            dtgv_vipham.DataSource = DAL.DocGia_DAL.Instance.GetListViPham();
            //dtgv_docgia.Refresh();
        }

        private void dtgv_docgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gb_thongtin.Enabled == true)
            {
                gb_thongtin.Enabled = false;
            }
            tbMaThe.Text = dtgv_docgia.CurrentRow.Cells["MaThe"].Value.ToString();
            tbHoTen.Text = dtgv_docgia.CurrentRow.Cells["TenDG"].Value.ToString();
            tbLop.Text = dtgv_docgia.CurrentRow.Cells["Lop"].Value.ToString();
            tbSDT.Text = dtgv_docgia.CurrentRow.Cells["SDT"].Value.ToString();
            tbDiaChi.Text = dtgv_docgia.CurrentRow.Cells["DiaChi"].Value.ToString();
            dtpk_dob.Value = Convert.ToDateTime(dtgv_docgia.CurrentRow.Cells["NgaySinh"].Value);
            dtpk_expire.Value = Convert.ToDateTime(dtgv_docgia.CurrentRow.Cells["NgayHetHan"].Value);
        }

        private void dtgv_docgia_Click(object sender, EventArgs e)
        {
            if (gb_thongtin.Enabled)
            {
                MessageBox.Show("Chưa lưu thông tin độc giả", "Thông báo");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            #region save thông tin mới update
            if (!Regex.IsMatch(tbSDT.Text, @"[0-9]"))
            {
                MessageBox.Show("Số điện thoại chỉ được phép là số", "Thông báo");
                return;
            }
            else
            {
                if (this.themMoi == 1)
                {
                    DAL.DocGia_DAL.Instance.InsertDocGia(
                        tbHoTen.Text,
                        tbDiaChi.Text,
                        tbLop.Text,
                        Convert.ToInt32(tbSDT.Text),
                        dtpk_dob.Value.ToString("MM/dd/yyyy"),
                        dtpk_expire.Value.ToString("MM/dd/yyyy")
                    );
                }
                else
                {
                    DAL.DocGia_DAL.Instance.UpdateDocGia(
                        Convert.ToInt32(tbMaThe.Text),
                        tbHoTen.Text,
                        tbDiaChi.Text,
                        tbLop.Text,
                        Convert.ToInt32(tbSDT.Text),
                        dtpk_dob.Value.ToString("MM/dd/yyyy"),
                        dtpk_expire.Value.ToString("MM/dd/yyyy")
                    );
                }
            }
            #endregion

            this.themMoi = 0;

            gb_thongtin.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnEdit.Enabled = true;
            btnXoa.Enabled = true;

            dtgv_docgia.DataSource = DAL.DocGia_DAL.Instance.GetListDocGia();
            dtgv_docgia.Refresh();
            dtgv_vipham.DataSource = DAL.DocGia_DAL.Instance.GetListViPham();
            dtgv_vipham.Refresh();

            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLuuVP_Click(object sender, EventArgs e)
        {
            #region save thông tin mới update
            if (this.themMoi == 1)
            {
                DAL.DocGia_DAL.Instance.InsertViPham(
                    tbTenVP.Text,
                    tbGhiChu.Text,
                    Convert.ToInt32(tbMaVP.Text)
                );
            }
            else
            {
                DAL.DocGia_DAL.Instance.UpdateViPham(
                    Convert.ToInt32(tbMaVP.Text),
                    tbTenVP.Text,
                    tbGhiChu.Text,
                    Convert.ToInt32(tbMaTheVP.Text)
                );
            }

            #endregion

            this.themMoi = 0;

            // save thông tin mới update
            gb_ThongTinVP.Enabled = false;
            btnLuuVP.Enabled = false;
            btnHuyVP.Enabled = false;
            btnThemVP.Enabled = true;
            btnEditVP.Enabled = true;
            btnXoaVP.Enabled = true;

            dtgv_vipham.DataSource = DAL.DocGia_DAL.Instance.GetListViPham();
            dtgv_vipham.Refresh();

            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //unsave thông tin mới update + clean tb
            tbMaThe.Text = "";
            tbHoTen.Text = "";
            tbLop.Text = "";
            tbSDT.Text = "";
            tbDiaChi.Text = "";
            dtpk_dob.Value = DateTime.Now;
            dtpk_expire.Value = DateTime.Now;

            this.themMoi = 0;

            gb_thongtin.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnEdit.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnHuyVP_Click(object sender, EventArgs e)
        {
            tbMaTheVP.Text = "";
            tbMaVP.Text = "";
            tbLopDGVP.Text = "";
            tbTenDGVP.Text = "";
            tbGhiChu.Text = "";
            tbTenVP.Text = "";

            this.themMoi = 0;

            //unsave thông tin mới update
            gb_ThongTinVP.Enabled = false;
            btnLuuVP.Enabled = false;
            btnHuyVP.Enabled = false;
            btnThemVP.Enabled = true;
            btnEditVP.Enabled = true;
            btnXoaVP.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtgv_docgia.DataSource = DAL.DocGia_DAL.Instance.GetListDocGia();
            dtgv_docgia.Refresh();
            dtgv_vipham.DataSource = DAL.DocGia_DAL.Instance.GetListViPham();
            dtgv_vipham.Refresh();
        }

        private void addViPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbMaVP.Text = dtgv_docgia.CurrentRow.Cells["MaThe"].Value.ToString();
        }

        private void dtgv_docgia_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Cut"));
                m.MenuItems.Add(new MenuItem("Copy"));
                m.MenuItems.Add(new MenuItem("Paste"));

                int currentMouseOverRow = dtgv_docgia.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                }

                m.Show(dtgv_docgia, new Point(e.X, e.Y));
            }
        }

        private void tbKeywordDG_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKeywordDG.Text))
            {
                dtgv_docgia.DataSource = DAL.DocGia_DAL.Instance.GetListDocGia();
                return;
            }
            if (radioButton1.Checked)
            {
                if (Regex.IsMatch(tbKeywordDG.Text, @"[0-9]"))
                    dtgv_docgia.DataSource = DAL.DocGia_DAL.Instance.SearchDocGiaByID(Convert.ToInt32(tbKeywordDG.Text));
            }
            if (radioButton2.Checked)
            {
                dtgv_docgia.DataSource = DAL.DocGia_DAL.Instance.SearchDocGiaByName(tbKeywordDG.Text);
            }
        }

        private void tbKeyWordVP_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKeyWordVP.Text))
            {
                dtgv_vipham.DataSource = DAL.DocGia_DAL.Instance.GetListViPham();
                return;
            }
            if (radioButton3.Checked)
            {
                if (Regex.IsMatch(tbKeyWordVP.Text, @"[0-9]"))
                    dtgv_vipham.DataSource = DAL.DocGia_DAL.Instance.SearchViPhamByID(Convert.ToInt32(tbKeyWordVP.Text));
            }
            if (radioButton4.Checked)
            {
                dtgv_vipham.DataSource = DAL.DocGia_DAL.Instance.SearchViPhamByName(tbKeyWordVP.Text);
            }
        }

        private void btnThemVP_Click(object sender, EventArgs e)
        {
            gb_ThongTinVP.Enabled = true;
            btnLuuVP.Enabled = true;
            btnHuyVP.Enabled = true;
            btnThemVP.Enabled = false;
            btnEditVP.Enabled = false;
            btnXoaVP.Enabled = false;

            this.themMoi = 1;
        }

        private void btnXoaVP_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                // đồng ý xóa: xóa trong db rồi refresh dtgv

                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //cancel xóa
            }
        }

        private void btnEditVP_Click(object sender, EventArgs e)
        {
            gb_ThongTinVP.Enabled = true;
            btnLuuVP.Enabled = true;
            btnHuyVP.Enabled = true;
            btnThemVP.Enabled = false;
            btnEditVP.Enabled = false;
            btnXoaVP.Enabled = false;
        }

        private void btnRefreshVP_Click(object sender, EventArgs e)
        {
            dtgv_vipham.DataSource = DAL.DocGia_DAL.Instance.GetListViPham();
            dtgv_vipham.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gb_thongtin.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnEdit.Enabled = false;
            btnXoa.Enabled = false;
            this.themMoi = 1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            gb_thongtin.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnEdit.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                // đồng ý xóa: xóa trong db rồi refresh dtgv
                DAL.DocGia_DAL.Instance.DeleteDocGia(Convert.ToInt32(tbMaThe.Text));

                dtgv_docgia.DataSource = DAL.DocGia_DAL.Instance.GetListDocGia();
                dtgv_docgia.Refresh();
                dtgv_vipham.DataSource = DAL.DocGia_DAL.Instance.GetListViPham();
                dtgv_vipham.Refresh();

                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //cancel xóa
            }
        }

        private void tbMaTheVP_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaTheVP.Text))
            {
                return;
            }
            List<DTO.DocGia> docGias = new List<DTO.DocGia>();
            docGias = DAL.DocGia_DAL.Instance.SearchDocGiaByID(Convert.ToInt32(tbMaTheVP.Text));

            if (docGias.Count > 0)
            {
                tbTenDGVP.Text = docGias[0].TenDG;
                tbLopDGVP.Text = docGias[0].Lop;
            }
            else
            {
                tbTenDGVP.Text = "";
                tbLopDGVP.Text = "";
            }
        }

        private void dtgv_vipham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gb_ThongTinVP.Enabled == true)
            {
                gb_ThongTinVP.Enabled = false;
            }
            tbMaVP.Text = dtgv_vipham.CurrentRow.Cells["MaVP"].Value.ToString();
            tbMaTheVP.Text = dtgv_vipham.CurrentRow.Cells["maTheVP"].Value.ToString();
            tbTenDGVP.Text = dtgv_vipham.CurrentRow.Cells["HoTenVP"].Value.ToString();
            tbLopDGVP.Text = dtgv_vipham.CurrentRow.Cells["LopDGVP"].Value.ToString();
            tbTenVP.Text = dtgv_vipham.CurrentRow.Cells["TenVP"].Value.ToString();
            tbGhiChu.Text = dtgv_vipham.CurrentRow.Cells["GhiChu"].Value.ToString();
        }

        private void tab_TK_Enter(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                dtgv_thongke.DataSource = DAL.DocGia_DAL.Instance.ThongKeSachMuonDG();
            }
            else
            {
                dtgv_thongke.DataSource = DAL.DocGia_DAL.Instance.ThongKeViPham();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                dtgv_thongke.DataSource = DAL.DocGia_DAL.Instance.ThongKeSachMuonDG();
            }
            else
            {
                dtgv_thongke.DataSource = DAL.DocGia_DAL.Instance.ThongKeViPham();
            }
        }

        private void btnXuLyVP_Click(object sender, EventArgs e)
        {
            tbGhiChu.Text = "Đã xử lý";
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            dtpk_expire.Value = dtpk_expire.Value.AddYears(2);
        }
    }
}
