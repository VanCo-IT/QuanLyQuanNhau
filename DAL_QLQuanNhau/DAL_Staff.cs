using DTO_QLQuanNhau;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLQuanNhau
{
    public class DAL_Staff
    {
        public Staff? getStaff(string email, string password)
        {
            const string sql = "SELECT * FROM NhanVien WHERE Email=@0 AND MatKhau=@1 LIMIT 1";
            var thamSo = new List<object> { email, password };

            using (var reader = DBUtil.Query(sql, thamSo))
            {
                if (reader.Read())
                {
                    return new Staff
                    {
                        MaNV = reader["MaNV"].ToString(),
                        TenNV = reader["TenNV"].ToString(),
                        TenDN = reader["TenDN"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        Email = reader["Email"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        VaiTro = Convert.ToBoolean(reader["VaiTro"]),
                        TrangThai = Convert.ToBoolean(reader["TrangThai"])
                    };
                }
            }

            return null;
        }

        public void ResetMatKhau(string mk, string email)
        {
            try
            {
                string sql = "UPDATE NhanVien SET MatKhau = @0 WHERE Email = @1";
                List<object> thamSo = new List<object>();
                thamSo.Add(mk);
                thamSo.Add(email);
                DBUtil.Update(sql, thamSo);

            }
            catch (Exception e)
            {
                throw;
            }
        }

        public List<Staff> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<Staff> list = new List<Staff>();
            try
            {
                SQLiteDataReader reader = DBUtil.Query(sql, args);

                while (reader.Read())
                {
                    Staff entity = new Staff();
                    entity.MaNV = reader["MaNV"].ToString();
                    entity.TenNV = reader["TenNV"].ToString();
                    entity.TenDN = reader["TenDN"].ToString();
                    entity.SDT = reader["SDT"].ToString();
                    entity.Email = reader["Email"].ToString();
                    entity.MatKhau = reader["MatKhau"].ToString();
                    entity.VaiTro = Convert.ToBoolean(reader["VaiTro"]);
                    entity.TrangThai = Convert.ToBoolean(reader["TrangThai"]);



                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<Staff> selectAll()
        {
            String sql = "SELECT * FROM NhanVien";
            return SelectBySql(sql, new List<object>());
        }


        public Staff selectById(string id)
        {
            String sql = "SELECT * FROM NhanVien WHERE MaNV=@0";
            List<object> thamSo = new List<object>();
            thamSo.Add(id);
            List<Staff> list = SelectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public void insertStaff(Staff staff)
        {
            try
            {
                string sql = @"INSERT INTO NhanVien (MaNV, TenNV,TenDN,SDT, Email, MatKhau, VaiTro, TrangThai) 
                   VALUES (@0, @1, @2, @3, @4, @5,@6,@7)";
                List<object> thamSo = new List<object>();
                thamSo.Add(staff.MaNV);
                thamSo.Add(staff.TenNV);
                thamSo.Add(staff.TenDN);
                thamSo.Add(staff.SDT);
                thamSo.Add(staff.Email);
                thamSo.Add(staff.MatKhau);
                thamSo.Add(staff.VaiTro);
                thamSo.Add(staff.TrangThai);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void updateStaff(Staff staff)
        {
            if (staff == null) throw new ArgumentNullException(nameof(staff));
            try
            {
                string sql = @"UPDATE NhanVien 
                       SET TenNV = @1, TenDN = @2, SDT = @3, Email = @4, MatKhau = @5, VaiTro = @6, TrangThai = @7
                       WHERE MaNV = @0";

                List<object> thamSo = new List<object>()
        {
            staff.MaNV,    // @0
            staff.TenNV,   // @1
            staff.TenDN,   // @2
            staff.SDT,     // @3
            staff.Email,   // @4
            staff.MatKhau, // @5
            staff.VaiTro,  // @6
            staff.TrangThai // @7
        };
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception ex)
            {
                // Optional: log error
                throw;
            }

        }

        public void deleteStaff(string maNV)
        {
            try
            {
                string sql = "DELETE FROM NhanVien WHERE MaNV = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maNV);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public bool checkEmailExists(string email)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE Email = @0";
            List<object> thamSo = new List<object>();
            thamSo.Add(email);
            object result = DBUtil.ScalarQuery(sql, thamSo);
            return Convert.ToInt32(result) > 0;
        }

        public string generateMaNhanVien()
        {
            string sql = "SELECT MAX(CAST(SUBSTR(MaNV, 3) AS INT)) FROM NhanVien";
            object result = DBUtil.ScalarQuery(sql, new List<object>());
            int max = result != DBNull.Value ? Convert.ToInt32(result) : 0;
            return $"NV{(max + 1).ToString("D3")}";
        }
    }
}
