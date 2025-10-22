using BLL_QLQuanNhau;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTIL_QLQuanNhau;

namespace GUI_QLQuanNhau
{
    public partial class frmDoiMK : Form
    {
        BUS_Staff bUS_Staff = new BUS_Staff();
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void btnHienMKCu_Click(object sender, EventArgs e)
        {
            txtMatKhauCu.PasswordChar = (txtMatKhauCu.PasswordChar == '*') ? '\0' : '*';
        }

        private void btnHienMKMoi_Click(object sender, EventArgs e)
        {
            txtMatKhauMoi.PasswordChar = (txtMatKhauMoi.PasswordChar == '#') ? '\0' : '#';
        }

        private void btnHienXacNhanMK_Click(object sender, EventArgs e)
        {
            txtXacNhanMK.PasswordChar = (txtXacNhanMK.PasswordChar == '#') ? '\0' : '#';
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (!AuthUtil.user.MatKhau.Equals(txtMatKhauCu.Text))
            {
                MessageBox.Show(this, "Mật khẩu cũ chưa đúng!!!");
            }
            else
            {
                if (!txtMatKhauMoi.Text.Equals(txtXacNhanMK.Text))
                {
                    MessageBox.Show(this, "Xác nhận mật khẩu mới chưa trùng khớp!!!");
                }
                else
                {
                    AuthUtil.user.MatKhau = txtMatKhauMoi.Text;

                    if (bUS_Staff.ResetMatKhau(AuthUtil.user.Email, txtMatKhauMoi.Text))
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công!!!");
                    }
                    else MessageBox.Show("Đổi mật khẩu thất bại, vui lòng kiểm tra lại!!!");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
