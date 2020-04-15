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

        public List<DocGia> GetDocGiaByCategoryID(int id)
        {
            List<DocGia> list = new List<DocGia>();

            string query = "select * from DocGia where idCategory = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DocGia docgia = new DocGia(item);
                list.Add(docgia);
            }

            return list;
        }

        public List<DocGia> GetListDocGia()
        {
            List<DocGia> list = new List<DocGia>();

            string query = "select * from DocGia";

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

            string query = string.Format("SELECT * FROM dbo.DocGia WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

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

            string query = string.Format("SELECT * FROM dbo.DocGia WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", id);

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
            string query = string.Format("INSERT dbo.DocGia ( name, idCategory, price )VALUES  ( N'{0}', {1}, {2})", name, id, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateDocGia(int idDocGia, string name, int id, float price)
        {
            string query = string.Format("UPDATE dbo.DocGia SET name = N'{0}', idCategory = {1}, price = {2} WHERE id = {3}", name, id, price, idDocGia);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteDocGia(int idDocGia)
        {
            // delete DocGia -> delete TheThuVien -> delete 1 đống?
            //BillInfoDAO.Instance.DeleteBillInfoByDocGiaID(idDocGia);

            string query = string.Format("Delete DocGia where id = {0}", idDocGia);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
