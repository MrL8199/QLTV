using QLTV.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static QLTV.DTO.MuonTra;

namespace QLTV.DAL
{
    class MuonTra_DAL
    {

        private static MuonTra_DAL instance;
        public static MuonTra_DAL Instance
        {
            get { if (instance == null) instance = new MuonTra_DAL(); return MuonTra_DAL.instance; }
            private set { MuonTra_DAL.instance = value; }
        }

        private MuonTra_DAL()
        {
        }
        // Dưới đây là các chức năng conn DB
        // Truy vấn
       //-- PhieuMuon
        public List<PhieuMuon>GetListPhieuMuon()
        {
            List<PhieuMuon> list = new List<PhieuMuon>();

            string query = "select * from PhieuMuon_View";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach( DataRow item in data.Rows)
            {
                PhieuMuon phieumuon = new PhieuMuon(item);
                list.Add(phieumuon);
            }
            return list;
;        }
        // -- PhieuTra
        public List<PhieuTra> GetListPhieuTra()
        {
            List<PhieuTra> list = new List<PhieuTra>();

            string query = "select * from PhieuTra_View";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuTra phieutra = new PhieuTra(item);
                list.Add(phieutra);
            }
            return list;
            ;
        }
        //--Tìm kiếm Phiếu Mượn
        // By Ma The
        public List<PhieuMuon> SearchPhieuMuonByTheID(int id)
        {

            List<PhieuMuon> list = new List<PhieuMuon>();

            string query = string.Format($"EXEC TimPhieuMuon '{id}','','0'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuMuon phieumuon = new PhieuMuon(item);
                list.Add(phieumuon);
            }

            return list;
        }
        // By Ngay Muon
        public List<PhieuMuon> SearchPhieuMuonByNgayMuon(DateTime ngaymuon)
        {

            List<PhieuMuon> list = new List<PhieuMuon>();

            string query = string.Format($"EXEC TimPhieuMuon '','{ngaymuon}','1'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuMuon phieumuon = new PhieuMuon(item);
                list.Add(phieumuon);
            }

            return list;
        }
        //Phi truy vấn
        public bool UpdatePhieuMuon(int maPhieuMuon, int maThe, DateTime ngayMuon, DateTime ngayHanTra, int maCuonSach, int maNhanVien, int maCuonSachNew)
        {
            string query = string.Format($"EXEC SuaPhieuMuon '{maPhieuMuon}','{ngayMuon}', '{ngayHanTra}','{maThe}', '{maCuonSach}', '{maNhanVien}', {maCuonSachNew}");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool InsertPhieuMuon(int maThe, DateTime ngayMuon, DateTime ngayHanTra, int maCuonSach, int maNhanVien)
        {
            string query = string.Format($"EXEC ThemPhieuMuon '{ngayMuon}', '{ngayHanTra}','{maThe}', '{maCuonSach}', '{maNhanVien}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeletePhieuMuon(int maPhieuMuon)
        {
            string query = string.Format($"EXEC XoaPhieuMuon {maPhieuMuon}");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdatePhieuTra(int maPhieuTra, int maThe, DateTime ngayTra,int maCuonSach, int maNhanVien, int maCuonSachNew)
        {
            string query = string.Format($"EXEC SuaPhieuTra '{maPhieuTra}', '{ngayTra}','{maThe}', '{maCuonSach}', '{maNhanVien}', '{maCuonSachNew}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool InsertPhieuTra(int maThe, DateTime ngayTra, int maCuonSach, int maNhanVien)
        {
            string query = string.Format($"EXEC ThemPhieuTra '{ngayTra}','{maThe}', '{maCuonSach}', '{maNhanVien}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeletePhieuTra(int maPhieuTra)
        {
            string query = string.Format($"EXEC XoaPhieuTra {maPhieuTra}");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
