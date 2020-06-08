using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DTO
{
    public class DocGia
    {
        private int maThe;
        private string tenDG;
        private string diaChi;
        private DateTime ngaySinh;
        private int sdt;
        private string lop;
        private string trangThai;
        private DateTime ngayHetHan;

        public int MaThe { get => maThe; set => maThe = value; }
        public string TenDG { get => tenDG; set => tenDG = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public string Lop { get => lop; set => lop = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }

        public DocGia()
        {
        }

        public DocGia(DataRow row)
        {
            this.MaThe = (int)row["MaThe"];
            this.TenDG = (string)row["HoTenDocGia"];
            this.Lop = (string)row["Lop"];
            this.Sdt = (int)row["Sdt"];
            this.DiaChi = (string)row["DiaChi"];
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.TrangThai = (string)row["TrangThai"];
            this.NgayHetHan = (DateTime)row["NgayHetHan"];
        }

        public DocGia(int maThe, string tenDG, string diaChi, DateTime ngaySinh, int sdt, string lop, string trangThai, DateTime ngayHetHan, int soLanGiaHan)
        {
            MaThe = maThe;
            TenDG = tenDG;
            DiaChi = diaChi;
            NgaySinh = ngaySinh;
            Sdt = sdt;
            Lop = lop;
            TrangThai = trangThai;
        }
    }
}
