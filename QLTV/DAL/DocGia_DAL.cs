using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DTO;

namespace QLTV.DAL
{
    public class DocGia_DAL
    {
        private static DocGia_DAL instance;

        public static DocGia_DAL Instance
        {
            get { if (instance == null) instance = new DocGia_DAL(); return DocGia_DAL.instance; }
            private set { DocGia_DAL.instance = value; }
        }

        private DocGia_DAL() { }

        public List<ViPham> GetListViPham()
        {
            List<ViPham> list = new List<ViPham>();

            string query = "select * from DOCGIAVP_VIEW";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ViPham viPham = new ViPham(item);
                list.Add(viPham);
            }

            return list;
        }

        public List<DocGia> GetListDocGia()
        {
            List<DocGia> list = new List<DocGia>();

            string query = "select * from DOCGIA_VIEW";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DocGia docgia = new DocGia(item);
                list.Add(docgia);
            }

            return list;
        }

        public List<DocGia> SearchDocGiaByName(string name)
        {

            List<DocGia> list = new List<DocGia>();

            string query = string.Format($"EXEC TimDG '',N'{name}','1'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DocGia docgia = new DocGia(item);
                list.Add(docgia);
            }

            return list;
        }

        public List<DocGia> SearchDocGiaByID(int id)
        {

            List<DocGia> list = new List<DocGia>();

            string query = string.Format($"EXEC TimDG '{id}','','0'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DocGia docgia = new DocGia(item);
                list.Add(docgia);
            }

            return list;
        }

        public bool InsertDocGia(string name, int id, float price)
        {
            string query = string.Format($"");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateDocGia(int idDocGia, string name, int id, float price)
        {
            string query = string.Format($"");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteDocGia(int idDocGia)
        {
            // delete DocGia -> delete TheThuVien -> delete 1 đống?
            //BillInfoDAO.Instance.DeleteBillInfoByDocGiaID(idDocGia);

            string query = string.Format($"EXEC XoaDG '{idDocGia}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool InsertViPham(string tenVP, string ghiChu, int maThe)
        {
            string query = string.Format($"EXEC ThemVP [{tenVP}], [{ghiChu}], '{maThe}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateViPham(int idViPham, string tenVP, string ghiChu, int maThe)
        {
            string query = string.Format($"EXEC SuaVP '{idViPham}',[{tenVP}], [{ghiChu}], '{maThe}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteViPham(int idViPham)
        {
            // delete ViPham -> delete TheThuVien -> delete 1 đống?
            //BillInfoDAO.Instance.DeleteBillInfoByViPhamID(idViPham);

            string query = string.Format($"EXEC XoaVP '{idViPham}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<ViPham> SearchViPhamByName(string name)
        {

            List<ViPham> list = new List<ViPham>();

            string query = string.Format($"EXEC TimVP '',[{name}],'1'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ViPham viPham = new ViPham(item);
                list.Add(viPham);
            }

            return list;
        }

        public List<ViPham> SearchViPhamByID(int id)
        {

            List<ViPham> list = new List<ViPham>();

            string query = string.Format($"EXEC TimVP '{id}','','0'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ViPham viPham = new ViPham(item);
                list.Add(viPham);
            }

            return list;
        }
    }
}
