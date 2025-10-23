using DAL_QLQuanNhau;
using DTO_QLQuanNhau;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_QLQuanNhau
{
    public class BUS_Staff
    {
        DAL_Staff dalStaff = new DAL_Staff();

        public Staff DangNhap(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            return dalStaff.getStaff(username, password);
        }

        public bool ResetMatKhau(string email, string mk)
        {
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mk))
                {
                    return false;
                }
                dalStaff.ResetMatKhau(mk, email);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Staff> GetStaffList()
        {
            return dalStaff.selectAll();
        }
        public Staff GetStaffByID(string id)
        {
            return dalStaff.selectById(id);
        }


        public string InsertStaff(Staff staff)
        {
            try
            {
                staff.MaNV = dalStaff.generateMaNhanVien();
                if (string.IsNullOrEmpty(staff.MaNV))
                {
                    return "Mã nhân viên không hợp lệ.";
                }
                if (dalStaff.checkEmailExists(staff.Email))
                {
                    return "Email đã tồn tại.";
                }
                dalStaff.insertStaff(staff);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Thêm mới không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdateStaff(Staff staff)
        {
            try
            {
                if (string.IsNullOrEmpty(staff.MaNV))
                {
                    return "Mã nhân viên không hợp lệ.";
                }

                dalStaff.updateStaff(staff);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteStaff(string maNV)
        {
            try
            {
                if (string.IsNullOrEmpty(maNV))
                {
                    return "Mã nhân viên không hợp lệ.";
                }

                dalStaff.deleteStaff(maNV);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Xóa không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
        public bool KiemTraEmailTonTai(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return dalStaff.checkEmailExists(email);
        }
    }
}
