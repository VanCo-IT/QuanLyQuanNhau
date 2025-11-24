using DTO_QLQuanNhau;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DAL_QLQuanNhau
{
    public class DAL_NhaCungCap
    {
        public List<NhaCungCap> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<NhaCungCap> list = new List<NhaCungCap>();
            try
            {
                //SQLiteDataReader reader = DBUtil.Query(sql, args);
                using (SQLiteDataReader reader = DBUtil.Query(sql, args))
                {
                    while (reader.Read())
                    {
                        NhaCungCap entity = new NhaCungCap();
                        entity.MaCungCap = reader["MaCungCap"].ToString();
                        entity.TenNCC = reader["TenNCC"].ToString();
                        entity.SDT = reader["SDT"].ToString();
                        entity.Email = reader["Email"].ToString();
                        entity.DiaChi = reader["DiaChi"].ToString();
                        list.Add(entity);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        public List<NhaCungCap> selectAll()
        {
            string sql = "SELECT * " + "FROM NhaCungCap";
            return SelectBySql(sql, new List<object>());
        }
        public NhaCungCap selectById(string id)
        {
            String sql = "SELECT * FROM NhaCungCap WHERE MaCungCap=@0";
            List<object> thamSo = new List<object>();
            thamSo.Add(id);
            List<NhaCungCap> list = SelectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }
        public void insertNhaCungCap(NhaCungCap ncc)
        {
            try
            {
                string sql = @"INSERT INTO NhaCungCap (MaCungCap, TenNCC,SDT,Email,DiaChi) 
                   VALUES (@0, @1, @2, @3, @4)";
                List<object> thamSo = new List<object>();
                thamSo.Add(ncc.MaCungCap);
                thamSo.Add(ncc.TenNCC);
                thamSo.Add(ncc.SDT);
                thamSo.Add(ncc.Email);
                thamSo.Add(ncc.DiaChi);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }
        public void updateNhaCungCap(NhaCungCap ncc)
        {
            try
            {
                string sql = @"UPDATE NhaCungCap 
                   SET TenNCC = @1, SDT = @2, Email = @3, DiaChi = @4
                   WHERE MaCungCap = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(ncc.MaCungCap);
                thamSo.Add(ncc.TenNCC);
                thamSo.Add(ncc.SDT);
                thamSo.Add(ncc.Email);
                thamSo.Add(ncc.DiaChi);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }
        public void deleteNhaCungCap(string maCC)
        {
            try
            {
                string sql = "DELETE FROM NhaCungCap WHERE MaCungCap = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maCC);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }
        public string generateMaCungCap()
        {
            string prefix = "MCC";
            string sql = "SELECT MAX(MCC) FROM NhaCungCap";
            List<object> thamSo = new List<object>();
            object result = DBUtil.ScalarQuery(sql, thamSo);
            if (result != null && result.ToString().StartsWith(prefix))
            {
                string maxCode = result.ToString().Substring(2);
                int newNumber = int.Parse(maxCode) + 1;
                return $"{prefix}{newNumber:D3}";
            }

            return $"{prefix}001";
        }
        public List<string> GetOnlyMaCungCap()
        {
            List<string> danhSachMaCungCap = new List<string>();
            string sql = "SELECT MaCungCap FROM NhaCungCap";
            SQLiteDataReader reader = DBUtil.Query(sql, new List<object>());

            while (reader.Read())
            {
                string maCungCap = reader["MaCungCap"].ToString();
                danhSachMaCungCap.Add(maCungCap);
            }

            return danhSachMaCungCap;
        }
    }
}
