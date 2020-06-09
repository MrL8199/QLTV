using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DTO
{
    /////// Kho     ////////
    public class Kho
    {
        private int maKho;
        private string tenKho;
        private string diaChiKho;

        public Kho()
        {
        }
        public Kho(DataRow row)
        {
            this.DiaChiKho = (string)row["DiaChiKho"];
            this.MaKho = (int)row["MaKho"];
            this.TenKho = (string)row["TenKho"];

        }
        public Kho(int maKho, string tenKho, string diaChiKho)
        {
            MaKho = maKho;
            TenKho = tenKho;
            DiaChiKho = diaChiKho;

        }

        public int MaKho { get => maKho; set => maKho = value; }
        public string TenKho { get => tenKho; set => tenKho = value; }
        public string DiaChiKho { get => diaChiKho; set => diaChiKho = value; }

    }

    ////// Nhà Cung Cấp ///////////
    public class NCC
    {
        private int maNCC;
        private string tenNCC;
        private string diaChiNCC;
        private int sdtNCC;

        public NCC()
        {
        }
        public NCC(DataRow row)
        {
            this.MaNCC = (int)row["MaNCC"];
            this.TenNCC = (string)row["TenNCC"];
            this.DiaChiNCC = (string)row["DiaChiNCC"];
            this.SDT_NCC = (int)row["SDT_NCC"];

        }
        public NCC(int maNCC, string tenNCC, string diaChiNCC, int sdtNCC)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
            DiaChiNCC = diaChiNCC;
            SDT_NCC = sdtNCC;

        }

        public int MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChiNCC { get => diaChiNCC; set => diaChiNCC = value; }
        public int SDT_NCC { get => sdtNCC; set => sdtNCC = value; }

    }

    //// Kệ sách ///////////////////
    public class KeSach
    {
        private int maKeSach;
        private string tenKeSach;

        public KeSach()
        {
        }
        public KeSach(DataRow row)
        {
            this.MaKeSach = (int)row["MaKeSach"];
            this.TenKeSach = (string)row["TenKeSach"];

        }
        public KeSach(int maKeSach, string tenKeSach)
        {
            MaKeSach = maKeSach;
            TenKeSach = tenKeSach;

        }

        public int MaKeSach { get => maKeSach; set => maKeSach = value; }
        public string TenKeSach { get => tenKeSach; set => tenKeSach = value; }
    }
    
    ////// ////////////////////////////////           Nhân Viên   ////////
    public class NhanVien
    {
        private int maNhanVien;
        private string tenNhanVien;
        private int maKho;

        public NhanVien()
        {

        }
        public NhanVien(DataRow row)
        {
            this.MaNhanVien = (int)row["MaNhanVien"];
            this.TenNhanVien = (string)row["TenNhanVien"];
            this.MaKho = (int)row["MaKho"];

        }
        public NhanVien(int maNhanVien, string tenNhanVien, int maKho)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            MaKho = maKho;
        }
        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public int MaKho { get => maKho; set => maKho = value; }
    }

    //////// Phiếu Nhập ///////////////
    public class PhieuNhap
    {
        private int maPN;
        private DateTime ngayNhap;

        public PhieuNhap()
        {
        }

        public PhieuNhap(DataRow row)
        {
            this.MaPN = (int)row["MaPN"];
            this.NgayNhap = (DateTime)row["NgayNhap"];
        }

        public PhieuNhap(int maPN, DateTime ngayNhap)
        {
            MaPN = maPN;
            NgayNhap = ngayNhap;

        }

        public int MaPN { get => maPN; set => maPN = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
    }

    // CHI tiết phiếu nhập


    public class CTPhieuNhap
    {
        private int maCTPN;
        public int maPN;
        public string tenKho;
        public int maKho;
        public string tenNCC;
        public int maNCC;
        public int soLuong;
        private string tenDauSach;
        public int maDauSach;
        public CTPhieuNhap()
        {
        }

        public CTPhieuNhap(DataRow row)
        {
            this.MaCTPN = (int)row["MaCTPN"];
            this.MaPN = (int)row["MaPN"];
            this.TenKho = (string)row["TenKho"];
            this.MaKho = (int)row["MaKho"];
            this.TenNCC = (string)row["TenNCC"];
            this.MaNCC = (int)row["MaNCC"];
            this.SoLuong = (int)row["SoLuong"];
            this.TenDauSach = (string)row["TenDauSach"];
            this.MaDauSach = (int)row["MaDauSach"];

        }

        public CTPhieuNhap(int maCTPN, int maPN, int maKho,int maNCC, int maDauSach, string tenKho, string tenNCC, int soLuong, string tenDauSach)
        {
            MaCTPN = maCTPN;
            MaPN = maPN;
            TenKho = tenKho;
            TenNCC = tenNCC;
            SoLuong = soLuong;
            TenDauSach = tenDauSach;
            MaKho = maKho;
            MaNCC = maNCC;
            MaDauSach = maDauSach;
        }

        public int MaPN { get => maPN; set => maPN = value; }
        public int MaCTPN { get => maCTPN; set => maCTPN = value; }
        public string TenKho { get => tenKho; set => tenKho = value; }
        public int MaKho { get => maKho; set => maKho = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public int MaNCC { get => maNCC; set => maNCC = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string TenDauSach { get => tenDauSach; set => tenDauSach = value; }
        public int MaDauSach { get => maDauSach; set => maDauSach = value; }
    }

    //////// Phiếu Xuất ///////////////
    public class PhieuXuat
    {
        private int maPX;
        private DateTime ngayXuat;


        public PhieuXuat()
        {
        }

        public PhieuXuat(DataRow row)
        {
            this.MaPX = (int)row["MaPX"];
            this.NgayXuat = (DateTime)row["NgayXuat"];

        }

        public PhieuXuat(int maPX, DateTime ngayXuat)
        {
            MaPX= maPX;
            NgayXuat = ngayXuat;
        }

        public int MaPX { get => maPX; set => maPX = value; }
        public DateTime NgayXuat { get => ngayXuat; set => ngayXuat = value; }
    }

    // CHI tiết phiếu xuất 


    public class CTPhieuXuat
    {
        private int maCTPX;
        public int maPX;
        public string tenKho;
        public int maKho;
        public string tenKeSach;
        public int maKeSach;
        public int soLuong;
        public string tenDauSach;
        public int maDauSach;
        public CTPhieuXuat()
        {
        }

        public CTPhieuXuat(DataRow row)
        {
            this.MaCTPX = (int)row["MaCTPX"];
            this.MaPX = (int)row["MaPX"];
            this.TenKho = (string)row["TenKho"];
            //this.MaKho = (int)row["MaKho"];
            this.TenKeSach = (string)row["TenKeSach"];
            //this.MaKeSach = (int)row["MaKeSach"];
            this.SoLuong = (int)row["SoLuong"];
            this.TenDauSach = (string)row["TenDauSach"];
            //this.MaDauSach = (int)row["MaDauSach"];

        }

        public CTPhieuXuat(int maCTPX,int maPX,string tenKho, int maKho, string tenKeSach,int maKeSach, int soLuong, string tenDauSach, int maDauSach)
        {
            MaCTPX = maCTPX;
            MaPX = maPX;
            TenKho = tenKho;
            this.MaKho = maKho;
            TenKeSach = tenKeSach;
            this.MaKeSach = maKeSach;
            SoLuong = soLuong;
            TenDauSach = tenDauSach;
            this.MaDauSach = maDauSach;
        }

        public int MaPX { get => maPX; set => maPX = value; }
        public int MaCTPX { get => maCTPX; set => maCTPX = value; }
        public string TenKho { get => tenKho; set => tenKho = value; }
        public int MaKho { get => maKho; set => maKho = value; }
        public string TenKeSach { get => tenKeSach; set => tenKeSach = value; }
        public int MaKeSach { get => maKeSach; set => maKeSach = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string TenDauSach { get => tenDauSach; set => tenDauSach = value; }
        public int MaDauSach { get => maDauSach; set => maDauSach = value; }
    }

    //////// Phiếu Kiểm Kê ///////////////
    public class PhieuKiemKe
    {
        private int maPhieuKiemKe;
        private DateTime ngayKiemKe;
        private int soLuongDau;
        private int soLuongCuoi;
        private int maKho;
        private string tenKho;

        public PhieuKiemKe()
        {
        }
        public PhieuKiemKe(DataRow row)
        {
            this.MaPhieuKiemKe = (int)row["MaPhieuKiemKe"];
            this.NgayKiemKe = (DateTime)row["NgayKiemKe"];
            this.TenKho = (string)row["TenKho"];
            this.SoLuongDau = (int)row["SO LUONG VAO"];
            this.SoLuongCuoi = (int)row["SO LUONG RA"];
            this.MaKho = (int)row["MaKho"];

        }
        public PhieuKiemKe(int maPhieuKiemKe,string tenKho, int soLuongDau, DateTime ngayKiemKe, int soLuongCuoi, int maKho)
        {
            MaPhieuKiemKe = maPhieuKiemKe;
            NgayKiemKe = ngayKiemKe;
            SoLuongDau = soLuongDau;
            SoLuongCuoi = soLuongCuoi;
            MaKho = maKho;
            TenKho = tenKho;

        }

        public int MaPhieuKiemKe { get => maPhieuKiemKe; set => maPhieuKiemKe = value; }
        public DateTime NgayKiemKe { get => ngayKiemKe; set => ngayKiemKe = value; }
        public int MaKho { get => maKho; set => maKho = value; }
        public string TenKho { get => tenKho; set => tenKho = value; }
        public int SoLuongDau { get => soLuongDau; set => soLuongDau = value; }
        
        public int SoLuongCuoi { get => soLuongCuoi; set => soLuongCuoi = value; }
        
    }


}

