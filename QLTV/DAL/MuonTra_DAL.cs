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
        public List<PhieuMuon> GetPhieuMuonByCategoryID(int id)
        {
            List<PhieuMuon> list = new List<PhieuMuon>();

            string query = "select * from PhieuMuon where idCategory = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuMuon phieumuon = new PhieuMuon(item);
                list.Add(phieumuon);
            }
             
            return list;
        }

        public List<PhieuMuon> GetListPhieuMuon()
        {
            List<PhieuMuon> list = new List<PhieuMuon>();

            string query = "select * from PhieuMuon";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuMuon phieumuon = new PhieuMuon(item);
                list.Add(phieumuon);
            }

            return list;
        }

        public List<PhieuMuon> SearchPhieuMuonById(int id)
        {

            List<PhieuMuon> list = new List<PhieuMuon>();

            string query = string.Format("SELECT * FROM dbo.PhieuMuon WHERE dbo.fuConvertToUnsign1(id) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuMuon phieumuon = new PhieuMuon(item);
                list.Add(phieumuon);
            }

            return list;
        }
        public bool InsertPhieuMuon(int idPhieuMuon, DateTime ngayMuon, DateTime NgayHanTra, int idThe)
        {
            string query = string.Format("INSERT dbo.PhieuMuon ( idPhieuMuon, ngayMuon, NgayHanTra,idThe  )VALUES  ( N'{0}', {1}, {2}, {3})", idPhieuMuon, ngayMuon, NgayHanTra, idThe);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdatePhieuMuon(int idPhieuMuon, DateTime ngayMuon, DateTime ngayHanTra, int idThe)
        {
            string query = string.Format("UPDATE dbo.PhieuMuon SET idPhieuMuon = N'{0}', ngayMuon = {1}, ngayHanTra = {2} WHERE idThe = {3}", idPhieuMuon, ngayMuon, ngayHanTra, idThe);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
