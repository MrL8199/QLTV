using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DTO
{
    public class Sach
    {


        private int maCuonSach;
        private string tenSach;
        private string tinhtrangCuonSach;
        private int soTrang;
        private int maDauSach;
        private int maKeSach;
        

        public int MaCuonSach { get => maCuonSach; set => maCuonSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TinhTrangCuonSach { get => tinhtrangCuonSach; set => tinhtrangCuonSach = value; }
        public int SoTrang { get => soTrang; set => soTrang = value; }
        public int MaDauSach { get => maDauSach; set => maDauSach = value; }
        public int MaKeSach { get => maKeSach; set => maKeSach = value; }


        public Sach()
        {
        }

        public Sach(int maCuonSach, string tenSach, string tinhtrangCuonSach, int soTrang, int maDauSach, int maKeSach)
        {
            MaCuonSach = maCuonSach;
            TenSach = tenSach;
            TinhTrangCuonSach = tinhtrangCuonSach;
            SoTrang = soTrang;
            MaDauSach = maDauSach;
            MaKeSach = maKeSach;
        }

        public Sach(DataRow row)
        {
            this.MaCuonSach = (int)row["MaCuonSach"];
            this.TenSach = (string)row["TenSach"];
            this.TinhTrangCuonSach = (string)row["TinhTrangCuonSach"];
            this.SoTrang = (int)row["SoTrang"];
            this.MaDauSach = (int)row["MaDauSach"];
            this.MaKeSach = (int)row["MaKeSach"];
            MaCuonSach = (int)row["maCuonSach"];
            TenSach = (string)row["tenSach"];
            TinhTrangCuonSach = (string)row["tinhtrangCuonSach"];
            SoTrang = (int)row["soTrang"];
            MaDauSach = (int)row["maDauSach"];
            MaKeSach = (int)row["maKeSach"];
        }
    }
    public class TacGia
    {
        private int maTacGia;
        private string tenTacGia;

        public int MaTacGia { get => maTacGia; set => maTacGia = value; }
        public string TenTacGia { get => tenTacGia; set => tenTacGia = value; }
        public TacGia()
        { 
        }
        public TacGia(int maTacGia,string tenTacGia)
        {
            MaTacGia = maTacGia;
            TenTacGia = tenTacGia;
        }

        public TacGia(DataRow row)
        {
            MaTacGia = (int)row["maTacGia"];
            TenTacGia = (string)row["tenTacGia"];
        }
    }
    public class TheLoai
    {
        private int maKeSach;
        private string tenTheLoai;
        

        public int MaKeSach { get => maKeSach; set => maKeSach = value; }
        public string TenTheLoai { get => tenTheLoai; set => tenTheLoai = value; }

        public TheLoai()
        {

        }
        public TheLoai(int maKeSach, string tenTheLoai)
        {
            MaKeSach = maKeSach;
            TenTheLoai = tenTheLoai;
        }

        public TheLoai(DataRow row)
        {
            MaKeSach = (int)row["maKeSach"];
            TenTheLoai = (string)row["tenTheLoai"];
        }
    }
    public class NXB
    {
        private int maNXB;
        private string tenNXB;
        private string diachiNXB;
        private int sdt;
        

        public int MaNXB { get => maNXB; set => maNXB = value; }
        public string TenNXB { get => tenNXB; set => tenNXB = value; }
        public string DiaChiNXB { get => diachiNXB; set => diachiNXB = value; }
        public int SDT { get => sdt; set => sdt = value; }

        public NXB()
        {

        }
        public NXB(int maNXB,string tenNXB,string diachiNXB,int sdt)
        {
            MaNXB = maNXB;
            TenNXB = tenNXB;
            DiaChiNXB = diachiNXB;
            SDT = sdt;
        }

        public NXB(DataRow row)
        {
            MaNXB = (int)row["maNXB"];
            TenNXB = (string)row["tenNXB"];
            DiaChiNXB = (string)row["diachiNXB"];
            SDT = (int)row["SDT_NXB"];
        }
    }
    public class DauSach
    {
        private int maDauSach;
        private string tenDauSach;
        private int maNXB;
        

        public int MaDauSach { get => maDauSach; set => maDauSach = value; }
        public string TenDauSach { get => tenDauSach; set => tenDauSach = value; }
        public int MaNXB { get => maNXB; set => maNXB = value; }
        public DauSach()
        {

        }
        public DauSach(int maDauSach,string tenDauSach,int maNXB)
        {
            MaDauSach = maDauSach;
            TenDauSach = tenDauSach;
            MaNXB = maNXB;
        }

        public DauSach(DataRow row)
        {
            MaDauSach = (int)row["maDauSach"];
            TenDauSach = (string)row["tenDauSach"];
            MaNXB = (int)row["maNXB"];
        }
    }
}