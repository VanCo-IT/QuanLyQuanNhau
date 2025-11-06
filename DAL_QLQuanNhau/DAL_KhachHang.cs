using DTO_QLQuanNhau;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace DAL_QLQuanNhau
{
    public class DAL_KhachHang
    {
        public List<KhachHang> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<KhachHang> list = new List<KhachHang>();
            try
            {
                SQLiteDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    KhachHang entity = new KhachHang();
                    entity.MaKH = reader["MaKH"].ToString();
                    entity.TenKH = reader["TenKH"].ToString();
                    entity.SDT = reader["SDT"].ToString();
                    entity.Email = reader["Email"].ToString();
                    entity.DiaChi = reader["DiaChi"].ToString();
                    entity.LoaiKH = reader["LoaiKH"].ToString();
                    entity.MoTa = reader["MoTa"].ToString();
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<KhachHang> selectAll()
        {
            string sql = "SELECT KhachHang.MaKH, TenKH, SDT, Email, DiaChi, LoaiKH,MoTa " +
             "FROM KhachHang ";

            return SelectBySql(sql, new List<object>());
        }
        public KhachHang selectById(string id)
        {
            String sql = "SELECT * FROM KhachHang WHERE MaKH=@0";
            List<object> thamSo = new List<object>();
            thamSo.Add(id);
            List<KhachHang> list = SelectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }
        public void insertKhachHang(KhachHang kh)
        {
            try
            {
                string sql = @"INSERT INTO KhachHang (MaKH, TenKH,SDT,Email,DiaChi,LoaiKH,MoTa) 
                   VALUES (@0, @1, @2, @3, @4, @5,@6)";
                List<object> thamSo = new List<object>();
                thamSo.Add(kh.MaKH);
                thamSo.Add(kh.TenKH);
                thamSo.Add(kh.SDT);
                thamSo.Add(kh.Email);
                thamSo.Add(kh.DiaChi);
                thamSo.Add(kh.LoaiKH);
                thamSo.Add(kh.MoTa);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }
        public void updateKhachHang(KhachHang kh)
        {
            try
            {
                string sql = @"UPDATE KhachHang 
                   SET TenKH = @1, SDT = @2, Email = @3, DiaChi = @4,LoaiKH =@5,MoTa = @6
                   WHERE MaKH = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(kh.MaKH);
                thamSo.Add(kh.TenKH);
                thamSo.Add(kh.SDT);
                thamSo.Add(kh.Email);
                thamSo.Add(kh.DiaChi);
                thamSo.Add(kh.LoaiKH);
                thamSo.Add(kh.MoTa);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }
        public void deleteKhachHang(string maKH)
        {
            try
            {
                string sql = "DELETE FROM KhachHang WHERE MaKH = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maKH);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }
        public string generateMaKhachHang()
        {
            string prefix = "KH";
            string sql = "SELECT MAX(MaKH) FROM KhachHang";
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
        public List<string> GetOnlyMaKH()
        {
            List<string> danhSachMaKH = new List<string>();
            string sql = "SELECT MaKH FROM KhachHang";
            SQLiteDataReader reader = DBUtil.Query(sql, new List<object>());

            while (reader.Read())
            {
                string maKH = reader["MaKH"].ToString();
                danhSachMaKH.Add(maKH);
            }

            return danhSachMaKH;
        }
    }
}
