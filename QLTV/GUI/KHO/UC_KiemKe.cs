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
    }
}
