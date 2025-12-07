using DAL_QLQuanNhau;
using DTO_QLQuanNhau;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_QLQuanNhau
{
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap dalNhaCungCap = new DAL_NhaCungCap();
        public List<NhaCungCap> GetNhaCungCapList() 
        {
            return dalNhaCungCap.selectAll();
        }
        public string InsertNhaCungCap(NhaCungCap ncc)
        {
            try
            {
                ncc.MaCungCap = dalNhaCungCap.generateMaCungCap();
                if (string.IsNullOrEmpty(ncc.MaCungCap))
                {
                    return "Mã cung cấp không hợp lệ";
                }
                dalNhaCungCap.insertNhaCungCap(ncc);
                return string.Empty;
            }
            catch( Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }
        public string UpdateNhaCiungCap(NhaCungCap ncc)
        {
            try
            {
                if (string.IsNullOrEmpty(ncc.MaCungCap))
                {
                    return "Mã cung cấp không hợp lệ";
                }
                dalNhaCungCap.updateNhaCungCap(ncc);
                return string.Empty;
            }
            catch(Exception ex)
            {
                return "Lỗi: "+ ex.Message;
            }
        }
        public string DeleteNhaCungCap(string maCungCap)
        {
            try
            {
                if (string.IsNullOrEmpty(maCungCap))
                {
                    return "Mã cung cấp không hợp lệ";
                }
                dalNhaCungCap.deleteNhaCungCap(maCungCap);
                return string.Empty;
            }
            catch(Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }
        public List<string> GetAllMaCungCap()
        {
            return dalNhaCungCap.GetOnlyMaCungCap();
        }
    }
}
