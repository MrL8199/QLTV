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

        ////////////////////////////////////////            NHÂN VIÊN            ///////////////////////////

        // Xem danh sách tất cả Nhân Viên

        public List<NhanVien> GetListNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();

            string query = "select * from NHANVIEN";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien nhanVien = new NhanVien(item);
                list.Add(nhanVien);
            }
            return list;
        }

        // Tìm nhân viên theo tên
        public List<NhanVien> SearchNhanVienByName(string name)
        {

            List<NhanVien> list = new List<NhanVien>();

            string query = string.Format($"EXEC TKTEN_NHANVIEN '{name}'");

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
        public bool InsertNhanVien(int manv, string tennv, int makho)
        {
            string query = string.Format($"execute THEM_NHANVIEN [{manv}], [{tennv}], [{makho}]");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Sửa Nhân Viên 
        public bool UpdateNhanVien(int manv,string tennv, int makho)
        {
            string query = string.Format($" execute UPDATE_NHANVIEN [{manv}],[{tennv}], [{makho}]");
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


        //////////////////////////////////////////////          NHÀ CUNG CẤP          /////////////////////


        // Xem danh sách tất cả NCC

        public List<NCC> GetListNCC()
        {
            List<NCC> list = new List<NCC>();

            string query = "select * from NCC";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NCC ncc = new NCC(item);
                list.Add(ncc);
            }
            return list;
        }

        // Tìm nhà cung cấp theo tên
        public List<NCC> SearchNCCByName(string name)
        {

            List<NCC> list = new List<NCC>();

            string query = string.Format($"EXEC TKTEN_NCC '{name}'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NCC ncc = new NCC(item);
                list.Add(ncc);
            }

            return list;
        }

        // Tìm nhà cung cấp theo mã
        public List<NCC> SearchNCCByID(int id)
        {

            List<NCC> list = new List<NCC>();

            string query = string.Format($"EXEC TKMA_NCC '{id}'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NCC ncc = new NCC(item);
                list.Add(ncc);
            }

            return list;
        }

        // Thêm nhà cung cấp 
        public bool InsertNCC(int mancc,string tenncc, string diachi, int sdt)
        {
            string query = string.Format($" execute THEM_NCC [{mancc}] , [{tenncc}], [{diachi}], [{sdt}] ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Sửa Nhà cung cấp
        public bool UpdateNCC(int mancc, string tenncc, string diachi, int sdt)
        {
            string query = string.Format($" execute UPDATE_NCC [{mancc}] , [{tenncc}], [{diachi}], [{sdt}] ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Xóa Nhà cung cấp 
        public bool DeleteNCC(int idNhanVien)
        {

            string query = string.Format($"EXEC DELETE_NCC '{idNhanVien}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        //////////////////////////////            PHIẾU NHẬP            /////////////////////////////// 



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

        // Xuất thông tin chi tiết phiếu nhập theo mã phiếu nhập
        public List<CTPhieuNhap> GetListCTPhieuNhap(int mapn)
        {
            List<CTPhieuNhap> list = new List<CTPhieuNhap>();

            string query = string.Format($"execute XEM_CTPHIEUNHAP '{mapn}'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CTPhieuNhap ctphieuNhap = new CTPhieuNhap(item);
                list.Add(ctphieuNhap);
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

        // Tìm Kiếm Phiếu Nhập Theo Mã phiếu nhập
        public List<CTPhieuNhap> SearchPhieuNhapTheoMaPN(int mapn)
        {
            List<CTPhieuNhap> list = new List<CTPhieuNhap>();
            string query = string.Format($"EXEC XEM_CTPHIEUNHAP '{mapn}'");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CTPhieuNhap ctphieuNhap = new CTPhieuNhap(item);
                list.Add(ctphieuNhap);
            }
            return list;
        }


        // Thêm nhà chi tiết phiếu nhập
        public bool InsertCTPhieuNhap(int mapn, int makho, int mancc, int soluong, int madausach)
        {
            string query = string.Format($" execute THEM_CT_PHIEUNHAP [{mapn}] , [{makho}], [{mancc}], [{soluong}],[{madausach}] ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Sửa chi tiết phiếu nhập 
        public bool UpdateCTPhieuNhap(int mactpn,int mapn, int makho, int mancc, int soluong, int madausach)
        {
            string query = string.Format($" execute UPDATE_CTPHIEUNHAP [{mactpn}], [{mapn}] ,[{makho}], [{mancc}], [{soluong}], [{madausach}] ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Xóa phiếu nhập
        public bool DeleteCTPhieuNhap(int mactpn)
        {

            string query = string.Format($"execute DELETE_CTPHIEUNHAP '{mactpn}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }




        //  /////                           PHIẾU XUẤT      



        // Xuất thông tin tất cả các phiếu xuất
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

        // Xuất thông tin chi tiết phiếu xuất theo mã phiếu xuất
        public List<CTPhieuXuat> GetListCTPhieuXuat(int mapx)
        {
            List<CTPhieuXuat> list = new List<CTPhieuXuat>();

            string query = string.Format($"execute XEM_CTPHIEUXUAT '{mapx}'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CTPhieuXuat ctphieuXuat = new CTPhieuXuat(item);
                list.Add(ctphieuXuat);
            }

            return list;
        }

        // Tìm kiếm phiếu xuất theo ngày
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

        // Tìm Kiếm Phiếu xuất Theo Mã phiếu xuất
        public List<CTPhieuXuat> SearchPhieuXuatTheoMaPN(int mapx)
        {
            List<CTPhieuXuat> list = new List<CTPhieuXuat>();
            string query = string.Format($"EXEC XEM_CTPHIEUXUAT '{mapx}'");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CTPhieuXuat ctphieuXuat = new CTPhieuXuat(item);
                list.Add(ctphieuXuat);
            }
            return list;
        }

        // Thêm chi tiết phiếu xuất
        public bool InsertCTPhieuXuat(int mapx, int makho, int makesach, int soluong, int madausach)
        {
            string query = string.Format($" execute THEM_CT_PHIEUXUAT [{mapx}] , [{makho}], [{makesach}], [{soluong}],[{madausach}] ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Sửa chi tiết phiếu xuất
        public bool UpdateCTPhieuXuat(int mactpx, int mapx, int makho, int makesach, int soluong, int madausach)
        {
            string query = string.Format($" execute UPDATE_CTPHIEUXUAT [{mactpx}], [{mapx}] ,[{makho}], [{makesach}], [{soluong}], [{madausach}] ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Xóa phiếu xuất
        public bool DeleteCTPhieuXuat(int mactpx)
        {

            string query = string.Format($"execute DELETE_CTPHIEUXUAT '{mactpx}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
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

        // Tìm kiếm phiếu kiểm kê theo ngày
        public List<PhieuKiemKe> SearchPhieuKiemKeTheoNgay(string ngay)
        {
            List<PhieuKiemKe> list = new List<PhieuKiemKe>();
            string query = string.Format($"EXEC TKNGAY_KIEMKE '{ngay}'");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhieuKiemKe phieuKiemKe = new PhieuKiemKe(item);
                list.Add(phieuKiemKe);
            }
            return list;
        }

        // Tìm Kiếm Phiếu kiểm kê Theo Mã phiếu kiểm kê
        public List<PhieuKiemKe> SearchPhieuKiemKeTheoMaPKK(int mapkk)
        {
            List<PhieuKiemKe> list = new List<PhieuKiemKe>();
            string query = string.Format($"EXEC TKMA_KIEMKE '{mapkk}'");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhieuKiemKe phieuKiemKe = new PhieuKiemKe(item);
                list.Add(phieuKiemKe);
            }
            return list;
        }

        // thêm phiếu kiểm kê mới   THEM_CTPHIEUKIEMKE

        public bool InsertCTPhieuKiemKe(DateTime ngaykk, int makho)
        {
            string query = string.Format($" execute THEM_CTPHIEUKIEMKE [{ngaykk}] , [{makho}] ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // xóa phiếu kiểm kê 
        public bool DeleteCTPhieuKiemKe(int mapkk)
        {

            string query = string.Format($"execute DELETE_PHIEUKIEMKE '{mapkk}'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
