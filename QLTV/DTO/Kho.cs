using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DTO
{
    /////// Kho     ////////
    public class Kho
    {
        private string maKho;
        private string tenKho;
        private string diaChiKho;

        public Kho()
        {
        }

        public Kho(string maKho, string tenKho, string diaChiKho)
        {
            MaKho = maKho;
            TenKho = tenKho;
            DiaChiKho = diaChiKho;

        }

        public string MaKho { get => maKho; set => maKho = value; }
        public string TenKho { get => tenKho; set => tenKho = value; }
        public string DiaChiKho { get => diaChiKho; set => diaChiKho = value; }

    }

    ////// Nhà Cung Cấp ///////////
    public class Ncc
    {
        private string maNCC;
        private string tenNCC;
        private string diaChiNCC;
        private string sdtNCC;

        public Ncc()
        {
        }

        public Ncc(string maNCC, string tenNCC, string diaChiNCC, string sdtNCC)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
            DiaChiNCC = diaChiNCC;
            SDT_NCC = sdtNCC;

        }

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChiNCC { get => diaChiNCC; set => diaChiNCC = value; }
        public string SDT_NCC { get => sdtNCC; set => sdtNCC = value; }

    }

    //// Kệ sách ///////////////////
    public class KeSach
    {
        private string maKeSach;
        private string tenKeSach;

        public KeSach()
        {
        }

        public KeSach(string maKeSach, string tenKeSach)
        {
            MaKeSach = maKeSach;
            TenKeSach = tenKeSach;

        }

        public string MaKeSach { get => maKeSach; set => maKeSach = value; }
        public string TenKeSach { get => tenKeSach; set => tenKeSach = value; }
    }
    
    /////  Nhân Viên   ////////
    public class NhanVien
    {
        private string maNhanVien;
        private string tenNhanVien;
        private string maKho;
        public NhanVien()
        {

        }
        public NhanVien(string maNhanVien, string tenNhanVien, string maKho)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            MaKho = maKho;
        }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string MaKho { get => maKho; set => maKho = value; }
    }

    //////// Phiếu Nhập ///////////////
    public class PhieuNhap
    {
        private string maKho;
        private string maNCC;
        private string ngayNhap;
        private string soLuong;
        private string maDauSach;

        public PhieuNhap()
        {
        }

        public PhieuNhap(string maKho, string maNCC, string ngayNhap, string soLuong, string maDauSach)
        {
            MaKho = maKho;
            MaNCC = maNCC;
            NgayNhap = ngayNhap;
            SoLuong = soLuong;
            MaDauSach = maDauSach;

        }

        public string MaKho { get => maKho; set => maKho = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public string MaDauSach { get => maDauSach; set => maDauSach = value; }
    }

    //////// Phiếu Xuất ///////////////
    public class PhieuXuat
    {
        private string maKho;
        private string maKeSach;
        private string ngayXuat;


        public PhieuXuat()
        {
        }

        public PhieuXuat(string maKho, string maKeSach, string ngayXuat)
        {
            MaKho = maKho;
            MaNCC = maKeSach;
            NgayXuat = ngayXuat;

        }

        public string MaKho { get => maKho; set => maKho = value; }
        public string MaNCC { get => maKeSach; set => maKeSach = value; }
        public string NgayXuat { get => ngayXuat; set => ngayXuat = value; }
    }
        //////// Phiếu Kiểm Kê ///////////////
    public class PhieuKiemKe
    {
        private string maPhieuKiemKe;
        private string ngayKiemKe;
        private string soLuongDau;
        private string soLuongCuoi;
        private string maKho;

        public PhieuKiemKe()
        {
        }

        public PhieuKiemKe(string maPhieuKiemKe, string soLuongDau, string ngayKiemKe, string soLuongCuoi, string maKho)
        {
            MaPhieuKiemKe = maPhieuKiemKe;
            NgayKiemKe = ngayKiemKe;
            SoLuongDau = soLuongDau;
            SoLuongCuoi = soLuongCuoi;
            MaKho = maKho;

        }

        public string MaPhieuKiemKe { get => maPhieuKiemKe; set => maPhieuKiemKe = value; }
        public string SoLuongDau { get => soLuongDau; set => soLuongDau = value; }
        public string NgayKiemKe { get => ngayKiemKe; set => ngayKiemKe = value; }
        public string SoLuongCuoi { get => soLuongCuoi; set => soLuongCuoi = value; }
        public string MaKho { get => maKho; set => maKho = value; }
    }


}

