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
    }
}
