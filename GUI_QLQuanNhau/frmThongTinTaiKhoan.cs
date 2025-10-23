using BLL_QLQuanNhau;
using DTO_QLQuanNhau;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLQuanNhau
{
    public partial class frmThongTinTaiKhoan : Form
    {
        private Staff currentStaff;
        BUS_Staff bUS_Staff = new BUS_Staff();
        private bool isEditing = false;

        public frmThongTinTaiKhoan(Staff staff)
        {
            InitializeComponent();
            currentStaff = staff;
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadStaffInfo();
            SetReadOnly(true);
        }
        private void LoadStaffInfo()
        {
            Staff info = bUS_Staff.GetStaffByID(currentStaff.MaNV);
            if (info == null)
            {
                MessageBox.Show("Không tìm thấy dữ liệu nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtEmail.Text = info.Email;
            txtMatKhau.Text = info.MatKhau;
            txtSoDienThoai.Text = info.SDT;
        }
        private void SetReadOnly(bool isReadOnly)
        {
            txtEmail.ReadOnly = isReadOnly;
            txtMatKhau.ReadOnly = isReadOnly;
            txtSoDienThoai.ReadOnly = isReadOnly;

            // Nếu bạn có avatar, disable upload khi isReadOnly == true
            btnThayAnh.Enabled = !isReadOnly;
        }
        private void btnThayDoiThongTin_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                // Bật chế độ chỉnh sửa
                SetReadOnly(false);
                btnThayDoiThongTin.Text = "Cập nhật thông tin";
                isEditing = true;
            }
            else
            {
                // Lưu thay đổi
                currentStaff.Email = txtEmail.Text.Trim();
                currentStaff.MatKhau = txtMatKhau.Text.Trim();
                currentStaff.SDT = txtSoDienThoai.Text.Trim();

                string result = bUS_Staff.UpdateStaff(currentStaff);
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetReadOnly(true);
                    btnThayDoiThongTin.Text = "Thay đổi thông tin";
                    isEditing = false;
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát khỏi chương trình", "Thoát",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question
                           );
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
