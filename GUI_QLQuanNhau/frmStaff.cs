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
    public partial class frmStaff : Form
    {
        private BUS_Staff bUSStaff = new BUS_Staff();
        public frmStaff()
        {
            InitializeComponent();
        }
        private void frmStaff_Load(object sender, EventArgs e)
        {
            CleanForm();
            LoadStaff();
        }
        private void LoadStaff()
        {
            BUS_Staff bUSStaff = new BUS_Staff();
            dgvStaff.DataSource = null;
            dgvStaff.DataSource = bUSStaff.GetStaffList();
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//hiện tất cả dữ liệu lên dgv mà ko mất(nhưng nhỏ)

        }
        private void CleanForm()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtTenDN.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            rbNhanVien.Checked = false;
            rbQuanLy.Checked = false;
            rbHoatDong.Checked = false;
            rbTamNgung.Checked = false;
        }

        private void dgvStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvStaff.Rows[e.RowIndex];
            // Đổ dữ liệu vào các ô nhập liệu trên form
            txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
            txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
            txtTenDN.Text = row.Cells["TenDN"].Value.ToString();
            txtSoDienThoai.Text = row.Cells["SDT"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();


            bool vaiTro = Convert.ToBoolean(row.Cells["VaiTro"].Value);
            if (vaiTro == false)
            {
                rbNhanVien.Checked = true;
            }
            else
            {
                rbQuanLy.Checked = true;
            }

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangThai == false)
            {
                rbTamNgung.Checked = true;
            }
            else
            {
                rbHoatDong.Checked = true;
                //}

                //// Bật nút "Sửa"
                //btnThemNV.Enabled = false;
                //btnCapNhatNV.Enabled = true;
                //btnXoaNV.Enabled = true;
                //// Tắt chỉnh sửa mã nhân viên
                //txtMaNV.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            string tenDangNhap = txtTenDN.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            bool vaiTro;

            if (rbNhanVien.Checked)
            {
                vaiTro = true;
            }
            else
            {
                vaiTro = false;
            }
            bool trangThai;

            if (rbHoatDong.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }
            Staff nv = new Staff
            {
                MaNV = maNV,
                TenNV = tenNV,
                Email = email,
                MatKhau = matKhau,
                SDT = sdt,
                TenDN = tenDangNhap,
                VaiTro = vaiTro,
                TrangThai = trangThai
            };
            BUS_Staff bUS_Staff = new BUS_Staff();
            string result = bUS_Staff.InsertStaff(nv);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Thêm nhân viên thành công");
                CleanForm();
                LoadStaff();
            }
            else
            {
                MessageBox.Show(result);
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            string tenDangNhap = txtTenDN.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            bool vaiTro;

            if (rbQuanLy.Checked)
            {
                vaiTro = true;
            }
            else
            {
                vaiTro = false;
            }
            bool trangThai;

            if (rbHoatDong.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }
            Staff nv = new Staff
            {
                MaNV = maNV,
                TenNV = tenNV,
                Email = email,
                MatKhau = matKhau,
                TenDN = tenDangNhap,
                SDT = sdt,
                VaiTro = vaiTro,
                TrangThai = trangThai
            };
            BUS_Staff bUS_Staff = new BUS_Staff();
            string result = bUS_Staff.UpdateStaff(nv);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                CleanForm();
                LoadStaff();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            if (string.IsNullOrEmpty(maNV))
            {
                if (dgvStaff.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvStaff.SelectedRows[0];
                    maNV = selectedRow.Cells["MaNhanVien"].Value.ToString();
                    tenNV = selectedRow.Cells["HoTen"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên {maNV} - {tenNV}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUS_Staff bUS_Staff = new BUS_Staff();
                string kq = bUS_Staff.DeleteStaff(maNV);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin nhân viên {maNV} - {tenNV} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanForm();
                    LoadStaff();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            CleanForm();
            LoadStaff();
        }
    }
}
