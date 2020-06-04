using QLTV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DAL
{
    public class KHO_DAL
    {
        private static KHO_DAL instance;

        public static KHO_DAL Instance
        {
            get { if (instance == null) instance = new KHO_DAL(); return KHO_DAL.instance; }
            private set { KHO_DAL.instance = value; }
        }

        private KHO_DAL() { }
        
        // Tìm nhân viên theo tên
        public List<NhanVien> SearchNhanVienByName(string name)
        {

            List<NhanVien> list = new List<NhanVien>();

            string query = string.Format($"EXEC TKTEN_NHANVIEN '',N'{name}','1'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien nhanVien = new NhanVien(item);
                list.Add(nhanVien);
            }

            return list;
        }

        // Tìm nhân viên theo mã
        public List<NhanVien> SearchNhanVienByID(int id)
        {

            List<NhanVien> list = new List<NhanVien>();

            string query = string.Format($"EXEC TKMA_NHANVIEN '{id}'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien NhanVien = new NhanVien(item);
                list.Add(NhanVien);
            }

            return list;
        }

        // Thêm nhân viên
        public bool InsertNhanVien(string name, int id, int makho)
        {
            string query = string.Format($"");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Sửa Nhân Viên 
        public bool UpdateNhanVien(int idNhanVien, string name, int makho)
        {
            string query = string.Format($"");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Xóa Nhân Viên 
        public bool DeleteNhanVien(int idNhanVien)
        {
            // delete NhanVien -> delete TheThuVien -> delete 1 đống?
            //BillInfoDAO.Instance.DeleteBillInfoByNhanVienID(idNhanVien);

            string query = string.Format($"EXEC DELETE_NHANVIEN '{idNhanVien}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }








        //                                          PHIẾU NHẬP




        // Xuất thông tin tất cả các phiếu nhập
        public List<PhieuNhap> GetListPhieuNhap()
        {
            List<PhieuNhap> list = new List<PhieuNhap>();

            string query = "select * from PHIEUNHAP";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuNhap phieuNhap = new PhieuNhap(item);
                list.Add(phieuNhap);
            }

            return list;
        }

        // Tìm kiếm phiếu nhập theo ngày
        public List<PhieuNhap> SearchPhieuNhapTheoNgay(string ngay)
        {
            List<PhieuNhap> list = new List<PhieuNhap>();
            string query = string.Format($"EXEC TKNGAY_PHIEUNHAP '{ngay}'");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhieuNhap phieuNhap = new PhieuNhap(item);
                list.Add(phieuNhap);
            }
            return list;
        }

        // Xem Chi tiết  phiếu nhập theo mã phiếu nhập
        public List<CTPhieuNhap> GetListCTPhieuNhap(int MaPN)
        {
            List<CTPhieuNhap> list = new List<CTPhieuNhap>();
            string query = string.Format($"EXEC XEM_CTPHIEUNHAP 'MaPN'");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CTPhieuNhap ctPhieuNhap = new CTPhieuNhap(item);
                list.Add(ctPhieuNhap);
            }
            return list;
        }



        //  /////                           PHIẾU XUẤT      



        // Xuất thông tin tất cả các phiếu nhập
        public List<PhieuXuat> GetListPhieuXuat()
        {
            List<PhieuXuat> list = new List<PhieuXuat>();

            string query = "select * from PHIEUXUAT";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuXuat phieuXuat = new PhieuXuat(item);
                list.Add(phieuXuat);
            }

            return list;
        }

        // tìm phiếu xuất theo ngày
        public List<PhieuXuat> SearchPhieuXuatTheoNgay(string ngay)
        {
            List<PhieuXuat> list = new List<PhieuXuat>();
            string query = string.Format($"EXEC TKNGAY_PHIEUXUAT '{ngay}'");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhieuXuat phieuXuat = new PhieuXuat(item);
                list.Add(phieuXuat);
            }
            return list;
        }


        //  /////                           PHIẾU KIỂM KÊ    



        // Xuất thông tin tất cả các phiếu kiểm kê
        public List<PhieuKiemKe> GetListPhieuKiemKe()
        {
            List<PhieuKiemKe> list = new List<PhieuKiemKe>();

            string query = "select * from VIEW_PHIEUKIEMKE";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuKiemKe phieuKiemKe = new PhieuKiemKe(item);
                list.Add(phieuKiemKe);
            }

            return list;
        }
    }
}
