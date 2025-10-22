using DTO_QLQuanNhau;

namespace UTIL_QLQuanNhau
{
    public class AuthUtil
    {
        public static Staff user = null;
        public static bool IsLogin()
        {
            if (user == null)
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(user.MaNV))
            {
                return false;
            }
            return true;
        }
    }
}
