using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.GUI.KHO
{
    public partial class QL_Kho : Form
    {

        public QL_Kho()
        {
            InitializeComponent();
        }
        private void QL_Kho_Load(object sender, EventArgs e)
        {
            UC_PhieuNhap uc_pn = new UC_PhieuNhap();
            Kho_MainClass.showControl(uc_pn, Content);
        }


        private void btnnhapkho_Click(object sender, EventArgs e)
        {
            UC_PhieuNhap uc_pn = new UC_PhieuNhap();
            Kho_MainClass.showControl(uc_pn, Content);
        }

        private void btnxuatkho_Click(object sender, EventArgs e)
        {
            UC_PhieuXuat uc_px = new UC_PhieuXuat();
            Kho_MainClass.showControl(uc_px, Content);
        }

        private void btnkiemkekho_Click(object sender, EventArgs e)
        {
            UC_KiemKe uc_kk = new UC_KiemKe();
            Kho_MainClass.showControl(uc_kk, Content);
        }

        private void btnqlnhanvien_Click(object sender, EventArgs e)
        {
            UC_NhanVien uc_nv = new UC_NhanVien();
            Kho_MainClass.showControl(uc_nv, Content);
        }

        private void btnqlncc_Click(object sender, EventArgs e)
        {
            UC_NCC uc_ncc = new UC_NCC();
            Kho_MainClass.showControl(uc_ncc, Content);
        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
