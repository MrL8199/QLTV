using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DTO
{
    public class DocGia
    {
        private string maThe;
        private string tenDG;
        private string diaChi;
        private string ngaySinh;
        private string sdt;
        private string lop;
        private string trangThai;
        private string ngayHetHan;

        public DocGia()
        {
        }

        public DocGia(string maThe, string tenDG, string ngaySinh, string lop, string sdt, string diaChi, string ngayHetHan, string trangThai)
        {
            MaThe = maThe;
            TenDG = tenDG;
            NgaySinh = ngaySinh;
            Lop = lop;
            Sdt = sdt;
            DiaChi = diaChi;
            NgayHetHan = ngayHetHan;
            TrangThai = trangThai;
        }

        public string MaThe { get => maThe; set => maThe = value; }
        public string TenDG { get => tenDG; set => tenDG = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
