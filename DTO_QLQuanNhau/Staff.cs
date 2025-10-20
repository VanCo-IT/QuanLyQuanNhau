using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLQuanNhau
{
    public class Staff
    {
        public sbyte MaNV { get; set; }
        public string TenNV { get; set; }
        public string SDT { get; set; }
        public string TenDN { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public bool VaiTro { get; set; }
        public bool TrangThai { get; set; }
        public string VaiTroText => VaiTro ? "Quản lý" : "Nhân viên";
        public string TrangThaiText => TrangThai ? "Đang làm việc" : "Đã nghỉ việc";
    }
}
