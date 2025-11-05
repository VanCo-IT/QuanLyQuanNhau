using DAL_QLQuanNhau;
using DTO_QLQuanNhau;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_QLQuanNhau
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKhachHang = new DAL_KhachHang();
        public List<KhachHang> GetKhachHangList()
        {
            return dalKhachHang.selectAll();
        }
        public string InsertKhachHang(KhachHang kh)
        {
            try
            {
                kh.MaKH = dalKhachHang.generateMaKhachHang();
                if (string.IsNullOrEmpty(kh.MaKH))
                {
                    return "Mã khách hàng không hợp lệ.";
                }

                dalKhachHang.insertKhachHang(kh);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Thêm mới không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
        public string UpdateKhachHang(KhachHang kh)
        {
            try
            {
                if (string.IsNullOrEmpty(kh.MaKH))
                {
                    return "Mã khách hàngm không hợp lệ.";
                }

                dalKhachHang.updateKhachHang(kh);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
        public string DeleteKhachHang(string maKH)
        {
            try
            {
                if (string.IsNullOrEmpty(maKH))
                {
                    return "Mã khách hàng không hợp lệ.";
                }

                dalKhachHang.deleteKhachHang(maKH);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Xóa không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
        public List<string> GetAllMaKH()
        {
            return dalKhachHang.GetOnlyMaKH();
        }

    }
}
