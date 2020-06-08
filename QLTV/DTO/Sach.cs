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
        private DataRow item;

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

        public Sach(DataRow item)
        {
            this.item = item;
        }
    }
    public class TacGia
    {
        private int maTacGia;
        private string tenTacGia;
        private DataRow item;

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

        public TacGia(DataRow item)
        {
            this.item = item;
        }
    }
    public class TheLoai
    {
        private int maKeSach;
        private string tenTheLoai;
        private DataRow item;

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

        public TheLoai(DataRow item)
        {
            this.item = item;
        }
    }
    public class NXB
    {
        private int maNXB;
        private string tenNXB;
        private string diachiNXB;
        private int sdt;
        private DataRow item;

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

        public NXB(DataRow item)
        {
            this.item = item;
        }
    }
    public class DauSach
    {
        private int maDauSach;
        private string tenDauSach;
        private int maNXB;
        private DataRow item;

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

        public DauSach(DataRow item)
        {
            this.item = item;
        }
    }
}