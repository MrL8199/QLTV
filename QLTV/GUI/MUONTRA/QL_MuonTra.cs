using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DAL;
using System.Windows.Forms;
using static QLTV.DTO.MuonTra;
using static QLTV.DAL.MuonTra_DAL;


namespace QLTV.GUI.MUONTRA
{
    public partial class QL_MuonTra : Form
    {
        public QL_MuonTra()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        //load
        private void QL_MuonTra_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL.DataProvider.Instance.ExecuteQuery("select * from PhieuMuon_View");
            dataGridView2.DataSource = DAL.DataProvider.Instance.ExecuteQuery("select * from PhieuTra_View");
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MuonTra_DAL.Instance.GetListPhieuMuon();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentID;
            currentID = dataGridView1.CurrentRow.Index;
            //lấy dòng hiện tại
            tbMaThe1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbNgayMuon1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbNgayHanTra1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbCuonSach1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbTenSach1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbNhanVien1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentID;
            currentID = dataGridView2.CurrentRow.Index;
            //lấy dòng hiện tại
            tbMaThe2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            tbNgayTra2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            tbCuonSach2.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            tbTenSach2.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            tbNhanVien2.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
