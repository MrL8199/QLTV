using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DTO
{
    public class MuonTra
    {
        // Phiếu Mượn
        public class PhieuMuon
        {
            private int maPhieuMuon;
            private DateTime ngayMuon;
            private DateTime ngayHanTra;
            private int maThe;

            public int MaPhieuMuon { get => maPhieuMuon; set => maPhieuMuon = value; }
            public DateTime NgayMuon { get => ngayMuon; set => ngayMuon = value; }
            public DateTime NgayHanTra { get => ngayHanTra; set => ngayHanTra = value; }
            public int MaThe { get => maThe; set => maThe = value; }

            public PhieuMuon()
            {
            }

            public PhieuMuon(DataRow row)
            {
                this.MaPhieuMuon = (int)row["MaPhieuMuon"];
                this.NgayMuon = (DateTime)row["NgayMuon"];
                this.NgayHanTra = (DateTime)row["NgayHanTra"];
                this.MaThe = (int)row["MaThe"];
            }

            public PhieuMuon(int maPhieuMuon, DateTime ngayMuon, DateTime ngayHanTra, int maThe)
            {
                MaPhieuMuon = maPhieuMuon;
                NgayMuon = ngayMuon;
                NgayHanTra = ngayHanTra;
                MaThe = maThe;
            }
        }

        // Phiếu Trả
        public class PhieuTra
        {
            private int maPhieuTra;
            private DateTime ngayTra;
            private int maThe;

            public int MaPhieuTra { get => maPhieuTra; set => maPhieuTra = value; }
            public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
            public int MaThe { get => maThe; set => maThe = value; }

            public PhieuTra()
            {
            }

            public PhieuTra(DataRow row)
            {
                this.MaPhieuTra = (int)row["MaPhieuTra"];
                this.NgayTra = (DateTime)row["NgayTra"];
                this.MaThe = (int)row["MaThe"];
            }

            public PhieuTra(int maPhieuTra, DateTime ngayTra, int maThe)
            {
                MaPhieuTra = maPhieuTra;
                NgayTra = ngayTra;
                MaThe = maThe;
            }
        }

        // Quản lý Mượn Sách
        public class QuanLyMuonSach
        {
            private int maPhieuMuon;
            private int maNhanVien;

            public int MaPhieuMuon { get => maPhieuMuon; set => maPhieuMuon = value; }
            public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }

            public QuanLyMuonSach()
            {
            }

            public QuanLyMuonSach(DataRow row)
            {
                this.MaPhieuMuon = (int)row["MaPhieuMuon"];
                this.MaNhanVien = (int)row["MaNhanVien"];
            }

            public QuanLyMuonSach(int maPhieuMuon, int maNhanVien)
            {
                MaPhieuMuon = maPhieuMuon;
                MaNhanVien = maNhanVien;
            }
        }

        // Quản lý Trả Sách
        public class QuanLyTraSach
        {
            private int maPhieuTra;
            private int maNhanVien;

            public int MaPhieuTra { get => maPhieuTra; set => maPhieuTra = value; }
            public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }

            public QuanLyTraSach()
            {
            }

            public QuanLyTraSach(DataRow row)
            {
                this.MaPhieuTra = (int)row["MaPhieuTra"];
                this.MaNhanVien = (int)row["MaNhanVien"];
            }

            public QuanLyTraSach(int maPhieuTra, int maNhanVien)
            {
                MaPhieuTra = maPhieuTra;
                MaNhanVien = maNhanVien;
            }
        }

        // CT_PhieuMuon
        public class CT_PhieuMuon
        {
            private int maPhieuMuon;
            private int maCuonSach;

            public int MaPhieuMuon { get => maPhieuMuon; set => maPhieuMuon = value; }
            public int MaCuonSach { get => maCuonSach; set => maCuonSach = value; }

            public CT_PhieuMuon()
            {
            }

            public CT_PhieuMuon(DataRow row)
            {
                this.MaPhieuMuon = (int)row["MaPhieuMuon"];
                this.MaCuonSach = (int)row["MaCuonSach"];
            }

            public CT_PhieuMuon(int maPhieuMuon, int maCuonSach)
            {
                MaPhieuMuon = maPhieuMuon;
                MaCuonSach = maCuonSach;
            }
        }
        // CT_PhieuTra
        public class CT_PhieuTra
        {
            private int maPhieuTra;
            private int maCuonSach;

            public int MaPhieuTra { get => maPhieuTra; set => maPhieuTra = value; }
            public int MaCuonSach { get => maCuonSach; set => maCuonSach = value; }

            public CT_PhieuTra()
            {
            }

            public CT_PhieuTra(DataRow row)
            {
                this.MaPhieuTra = (int)row["MaPhieuTra"];
                this.MaCuonSach = (int)row["MaCuonSach"];
            }

            public CT_PhieuTra(int maPhieuTra, int maCuonSach)
            {
                MaPhieuTra = maPhieuTra;
                MaCuonSach = maCuonSach;
            }
        }
    }
}
