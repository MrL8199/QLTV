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
            
            int row = e.RowIndex;
            if (row < 0)
            {
                return;
            }
            
             int MaPN = Convert.ToInt32(dtgvPhieuNhap.Rows[row].Cells["MaPN"].Value);

            if (MaPN != null)
            {
                dtgvCTPhieuNhap.DataSource = KHO_DAL.Instance.GetListCTPhieuNhap(MaPN);
            }

        }


    }
}
