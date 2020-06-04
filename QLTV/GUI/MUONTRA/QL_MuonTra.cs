using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLTV.DTO.MuonTra;
using static QLTV.DAL.MuonTra_DAL;
using QLTV.DAL;

namespace QLTV.GUI.MUONTRA
{
    public partial class QL_MuonTra : Form
    {
        public QL_MuonTra()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DAL.MuonTra_DAL.Instance.GetPhieuMuonByCategoryID(17150035);
          
            dataGridView1.DataSource = MuonTra_DAL.Instance.GetListPhieuMuon();



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
