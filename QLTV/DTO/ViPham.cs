using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DTO
{
    public class ViPham
    {
        private int maViPham;
        private int maThe;
        private string tenDG;
        private DateTime ngaySinh;
        private string lop;
        private string tenViPham;
        private string ghiChu;

        

        public ViPham()
        {
        }

        public ViPham(DataRow row)
        {
            this.MaViPham = (int)row["MaViPham"];
            this.MaThe = (int)row["MaThe"];
            this.TenDG = (string)row["HoTenDocGia"];
            this.Lop = (string)row["Lop"];
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.TenViPham = (string)row["TenViPham"];
            this.GhiChu = (string)row["GhiChu"];
        }

        public ViPham(int maThe, string tenDG, DateTime ngaySinh, string lop, string tenViPham, string ghiChu, int maViPham)
        {
            MaViPham = maViPham;
            MaThe = maThe;
            TenDG = tenDG;
            NgaySinh = ngaySinh;
            Lop = lop;
            TenViPham = tenViPham;
            GhiChu = ghiChu;
        }

        public int MaThe { get => maThe; set => maThe = value; }
        public string TenDG { get => tenDG; set => tenDG = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Lop { get => lop; set => lop = value; }
        public string TenViPham { get => tenViPham; set => tenViPham = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int MaViPham { get => maViPham; set => maViPham = value; }
    }
}
