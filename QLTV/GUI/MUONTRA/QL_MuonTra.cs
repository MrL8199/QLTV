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
        private int themMoi = 0;

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
            DAL.MuonTra_DAL.Instance.InsertPhieuMuon(
                Convert.ToInt32(tbMaThe1.Text),
                tbNgayMuon1.Value,
                tbNgayHanTra1.Value,
                Convert.ToInt32(tbCuonSach1.Text),
                Convert.ToInt32(tbNhanVien1.Text)
               );
            dataGridView1.DataSource = DAL.DataProvider.Instance.ExecuteQuery("select * from PhieuMuon_View");
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
            tbNhanVien1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            tbTTCuonSach1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
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
            tbNhanVien2.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();

            tbTTCuonSach2.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();

        }

        private void tbTTCuonSach1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTTCuonSach1.Text))
            {
                return;
            }
            List<DTO.Sach> sachs = new List<DTO.Sach>();
            sachs = DAL.Sach_DAL.Instance.SearchSachByID1(Convert.ToInt32(tbTTCuonSach1.Text));

            if (sachs.Count > 0)
            {
                tbTenSach1.Text = sachs[0].TenSach;
                tbSoTrang1.Text = sachs[0].SoTrang.ToString();
                tbTinhTrang1.Text = sachs[0].TinhTrangCuonSach;
                tbMaDauSach1.Text = sachs[0].MaDauSach.ToString();
                tbMaKeSach1.Text = sachs[0].MaKeSach.ToString();
            }
            else
            {
                tbTenSach1.Text = "";
                tbSoTrang1.Text = "";
                tbTinhTrang1.Text = "";
                tbMaDauSach1.Text = "";
                tbMaKeSach1.Text = "";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTTCuonSach2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTTCuonSach2.Text))
            {
                return;
            }
            List<DTO.Sach> sachs = new List<DTO.Sach>();
            sachs = DAL.Sach_DAL.Instance.SearchSachByID1(Convert.ToInt32(tbTTCuonSach2.Text));

            if (sachs.Count > 0)
            {
                tbTenSach2.Text = sachs[0].TenSach;
                tbSoTrang2.Text = sachs[0].SoTrang.ToString();
                tbTinhTrang2.Text = sachs[0].TinhTrangCuonSach;
                tbMaDauSach2.Text = sachs[0].MaDauSach.ToString();
                tbMaKeSach2.Text = sachs[0].MaKeSach.ToString();
            }
            else
            {
                tbTenSach2.Text = "";
                tbSoTrang2.Text = "";
                tbTinhTrang2.Text = "";
                tbMaDauSach2.Text = "";
                tbMaKeSach2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DAL.MuonTra_DAL.Instance.UpdatePhieuMuon(
                Convert.ToInt32(dataGridView1.CurrentRow.Cells["Mã Phiếu Mượn"].Value.ToString()),
                Convert.ToInt32(tbMaThe1.Text),
                tbNgayMuon1.Value,
                tbNgayHanTra1.Value,
                Convert.ToInt32(dataGridView1.CurrentRow.Cells["Mã Cuốn Sách"].Value.ToString()),
                Convert.ToInt32(tbNhanVien1.Text),
                Convert.ToInt32(tbCuonSach1.Text)
               );
            dataGridView1.DataSource = DAL.DataProvider.Instance.ExecuteQuery("select * from PhieuMuon_View");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DAL.MuonTra_DAL.Instance.DeletePhieuMuon(
                Convert.ToInt32(dataGridView1.CurrentRow.Cells["Mã Phiếu Mượn"].Value.ToString())
               );
            dataGridView1.DataSource = DAL.DataProvider.Instance.ExecuteQuery("select * from PhieuMuon_View");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DAL.MuonTra_DAL.Instance.InsertPhieuTra(
                Convert.ToInt32(tbMaThe2.Text),
               tbNgayTra2.Value,
               Convert.ToInt32(tbCuonSach2.Text),
               Convert.ToInt32(tbNhanVien2.Text)
               );
            dataGridView2.DataSource = DAL.DataProvider.Instance.ExecuteQuery("select * from PhieuTra_View");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DAL.MuonTra_DAL.Instance.UpdatePhieuTra(
               Convert.ToInt32(dataGridView2.CurrentRow.Cells["Mã Phiếu Trả"].Value.ToString()),
               Convert.ToInt32(tbMaThe2.Text),
               tbNgayTra2.Value,
               Convert.ToInt32(dataGridView2.CurrentRow.Cells["Mã Cuốn Sách"].Value.ToString()),
               Convert.ToInt32(tbNhanVien2.Text),
               Convert.ToInt32(tbCuonSach2.Text)
              );
            dataGridView2.DataSource = DAL.DataProvider.Instance.ExecuteQuery("select * from PhieuTra_View");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DAL.MuonTra_DAL.Instance.DeletePhieuTra(
               Convert.ToInt32(dataGridView2.CurrentRow.Cells["Mã Phiếu Trả"].Value.ToString())
              );
            dataGridView2.DataSource = DAL.DataProvider.Instance.ExecuteQuery("select * from PhieuTra_View");
        }
    }
}
