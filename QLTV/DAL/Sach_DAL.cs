using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DTO;
namespace QLTV.DAL
{
    public class Sach_DAL
    {
        private static Sach_DAL instance;

        public static Sach_DAL Instance
        {
            get { if (instance == null) instance = new Sach_DAL(); return Sach_DAL.instance; }
            private set { Sach_DAL.instance = value; }
        }
        public List<TacGia> GetListTacGia()
        {
            List<TacGia> list = new List<TacGia>();

            string query = "select * from TACGIA_View";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TacGia tacGia = new TacGia(item);
                list.Add(tacGia);
            }

            return list;
        }
        public List<NXB> GetListNXB()
        {
            List<NXB> list = new List<NXB>();

            string query = "select * from NXB_View";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NXB nxb = new NXB(item);
                list.Add(nxb);
            }

            return list;
        }
        public List<Sach> GetListCuonSach()
        {
            List<Sach> list = new List<Sach>();

            string query = "select * from CUONSACH_View";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Sach cuonsach = new Sach(item);
                list.Add(cuonsach);
            }

            return list;
        }
        public List<DauSach> GetListDauSach()
        {
            List<DauSach> list = new List<DauSach>();

            string query = "select * from DAUSACH_View";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DauSach dausach = new DauSach(item);
                list.Add(dausach);
            }

            return list;
        }
        public List<TheLoai> GetListTheLoai()
        {
            List<TheLoai> list = new List<TheLoai>();

            string query = "select * from THELOAI_View";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TheLoai theLoai = new TheLoai(item);
                list.Add(theLoai);
            }

            return list;
        }
        public List<TacGia> SearchTacGiaByID(int id)
        {

            List<TacGia> list = new List<TacGia>();

            string query = string.Format($"SELECT * FROM TimKiemTG1('{id}')");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TacGia tacGia = new TacGia(item);
                list.Add(tacGia);
            }

            return list;
        }
        public List<TacGia> SearchTacGiaByName(string name)
        {

            List<TacGia> list = new List<TacGia>();

            string query = string.Format($"SELECT * FROM TimKiemTG2(N'{name}')");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TacGia tacGia = new TacGia(item);
                list.Add(tacGia);
            }

            return list;
        }
        public List<NXB> SearchNXBByID(int id)
        {

            List<NXB> list = new List<NXB>();

            string query = string.Format($"SELECT * FROM TimKiemNXB1('{id}')");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NXB nxb = new NXB(item);
                list.Add(nxb);
            }

            return list;
        }
        public List<NXB> SearchNXBByName(string name)
        {

            List<NXB> list = new List<NXB>();

            string query = string.Format($"SELECT * FROM TimKiemNXB2(N'{name}')");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NXB nxb = new NXB(item);
                list.Add(nxb);
            }

            return list;
        }
        public List<Sach> SearchSachByID(int id)
        {

            List<Sach> list = new List<Sach>();

            string query = string.Format($"SELECT * FROM TimKiemCS1('{id}')");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Sach cuonsach = new Sach(item);
                list.Add(cuonsach);
            }

            return list;
        }
        // Hưng thay tạm
        public List<Sach> SearchSachByID1(int id)
        {

            List<Sach> list = new List<Sach>();

            string query = string.Format($"EXEC TimKiemCS '{id}'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Sach cuonsach = new Sach(item);
                list.Add(cuonsach);
            }

            return list;
        }

        public List<Sach> SearchSachByName(string name)
        {

            List<Sach> list = new List<Sach>();

            string query = string.Format($"SELECT * FROM TimKiemCS2(N'{name}')");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Sach cuonsach = new Sach(item);
                list.Add(cuonsach);
            }

            return list;
        }
        public List<DauSach> SearchDauSachByID(int id)
        {

            List<DauSach> list = new List<DauSach>();

            string query = string.Format($"SELECT * FROM TimKiemDS1('{id}')");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DauSach dausach = new DauSach(item);
                list.Add(dausach);
            }

            return list;
        }
        public List<DauSach> SearchDauSachByName(string name)
        {

            List<DauSach> list = new List<DauSach>();

            string query = string.Format($"SELECT * FROM TimKiemDS2(N'{name}')");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DauSach dausach = new DauSach(item);
                list.Add(dausach);
            }

            return list;
        }
        public List<TheLoai> SearchTheLoaiByName(string name)
        {

            List<TheLoai> list = new List<TheLoai>();

            string query = string.Format($"SELECT * FROM TimKiemTheLoai(N'{name}')");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TheLoai theloai = new TheLoai(item);
                list.Add(theloai);
            }

            return list;
        }
        public bool InsertTacGia(int MaTacGia,string TenTG)
        {
            string query = string.Format($"EXEC ThemTacGia '{MaTacGia}', [{TenTG}]");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool InsertNXB(int MaNXB, string TenNXB,string diachiNXB,int sdt)
        {
            string query = string.Format($"EXEC ThemNXB '{MaNXB}', [{TenNXB}],[{diachiNXB}],'{sdt}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool InsertCuonSach(int MaCuonSach, string TenSach, int page, string tinhtrang,int madausach,int makesach)
        {
            string query = string.Format($"EXEC themCuonSach '{MaCuonSach}', [{TenSach}],'{page}',[{tinhtrang}],'{madausach}','{makesach}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool InsertDauSach(int MaDauSach, string TenDauSach, int MaNXB)
        {
            string query = string.Format($"EXEC themDauSach '{MaDauSach}', [{TenDauSach}],'{MaNXB}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool InsertTheLoai(int MaKeSach, string TenTheLoai)
        {
            string query = string.Format($"EXEC themTheLoai '{MaKeSach}', [{TenTheLoai}]");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteTacGia(int MaTG)
        {
            string query = string.Format($"EXEC xoaTG '{MaTG}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
   
        }
        public bool DeleteNXB(int MaNXB)
        {
            string query = string.Format($"EXEC deleteNXB '{MaNXB}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }
        public bool DeleteTheLoai(int MaKeSach)
        {
            string query = string.Format($"EXEC deleteTheLoai '{MaKeSach}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }
        public bool DeleteCuonSach(int MaCS)
        {
            string query = string.Format($"EXEC deleteCuonSach '{MaCS}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }
        public bool DeleteDauSach(int MaDS)
        {
            string query = string.Format($"EXEC deleteDausach '{MaDS}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }
        public bool UpdateTacGia(int MaTG,string TenTG)
        {
            string query = string.Format($"EXEC updateTG '{MaTG}',[{TenTG}]");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateNXB(int MaNXB, string TenNXB,string diachiNXB,int sdt)
        {
            string query = string.Format($"EXEC updateNXB '{MaNXB}',[{TenNXB}],[{diachiNXB}],'{sdt}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateCuonSach(int MaCuonSach, string TenSach, int page, string tinhtrang, int madausach, int makesach)
        {
            string query = string.Format($"EXEC updateCuonSach '{MaCuonSach}', [{TenSach}],'{page}',[{tinhtrang}],'{madausach}','{makesach}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateDauSach(int MaDauSach, string TenDauSach, int MaNXB)
        {
            string query = string.Format($"EXEC updateDauSach '{MaDauSach}', [{TenDauSach}],'{MaNXB}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateTheLoai(int MaKeSach, string TenTheLoai)
        {
            string query = string.Format($"EXEC updateTheLoai '{MaKeSach}', [{TenTheLoai}]");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }







    }
}
