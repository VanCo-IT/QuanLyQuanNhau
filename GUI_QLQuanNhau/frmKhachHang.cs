using BLL_QLQuanNhau;
using DTO_QLQuanNhau;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GUI_QLQuanNhau
{
    public partial class frmKhachHang : Form
    {
        private BUS_KhachHang busKhachHang = new BUS_KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachKhachHang();
            LoadMaKhachHangVaoComboBox();
        }
        private void ClearForm()
        {
            cbMaKH.SelectedIndex = -1;
            txtTenKH.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            cbLoaiKhachHang.SelectedIndex = -1;
            txtMoTa.Clear();
        }
        private void LoadDanhSachKhachHang()
        {
            try
            {
                BUS_KhachHang busKhachHang = new BUS_KhachHang();
                List<KhachHang> dsKhachHang = busKhachHang.GetKhachHangList();
                dgvKhachHang.DataSource = busKhachHang.GetKhachHangList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiễn thị danh sách khách hàng: " + ex);
            }
        }
        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code khi ấn vào cbMaKH sẽ hiện thông tin để sửa 

            // Kiểm tra nếu có chọn giá trị nào
            if (cbMaKH.SelectedIndex == -1)
            {
                ClearForm();
                return;
            }

            // Lấy mã khách hàng được chọn
            string selectedMaKH = cbMaKH.SelectedValue.ToString();

            // Tìm đối tượng KhachHang tương ứng trong danh sách
            BUS_KhachHang bus = new BUS_KhachHang();
            List<KhachHang> dsKhachHang = bus.GetKhachHangList();

            KhachHang kh = dsKhachHang.FirstOrDefault(x => x.MaKH == selectedMaKH);

            if (kh != null)
            {
                // Hiển thị thông tin khách hàng lên form
                txtTenKH.Text = kh.TenKH;
                txtSDT.Text = kh.SDT;
                txtEmail.Text = kh.Email;
                txtDiaChi.Text = kh.DiaChi;
                cbLoaiKhachHang.Text = kh.LoaiKH;
                txtMoTa.Text = kh.MoTa;
            }
            else
            {
                ClearForm();
            }
        }
        private void LoadMaKhachHangVaoComboBox()
        {
            try
            {
                BUS_KhachHang busKhachHang = new BUS_KhachHang();
                List<string> danhSachMaKH = busKhachHang.GetAllMaKH();

                cbMaKH.DataSource = danhSachMaKH;
                cbMaKH.DropDownStyle = ComboBoxStyle.DropDownList; // Không cho nhập tay
                cbMaKH.SelectedIndex = -1; // Không chọn sẵn
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải mã khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
            cbMaKH.Text = row.Cells["MaKH"].Value?.ToString();
            txtTenKH.Text = row.Cells["TenKH"].Value?.ToString();
            txtSDT.Text = row.Cells["SDT"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
            cbLoaiKhachHang.Text = row.Cells["LoaiKH"].Value?.ToString();
            //cbLoaiKhachHang.Text = row.Cells["LoaiKH"].Value?.ToString();
            txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();
            dgvKhachHang.AutoSize = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKH = cbMaKH.Text.Trim();
            string tenKH = txtTenKH.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string loaiKH = cbLoaiKhachHang.Text.Trim();
            string moTa = txtMoTa.Text.Trim();

            if (string.IsNullOrEmpty(loaiKH) || string.IsNullOrEmpty(moTa))
            {
                MessageBox.Show("Vui lòng phân loại khách hàng hoặc mô tả.");
                return;
            }
            KhachHang kh = new KhachHang
            {
                MaKH = maKH,
                TenKH = tenKH,
                Email = email,
                SDT = sdt,
                DiaChi = diaChi,
                LoaiKH = loaiKH,
                MoTa = moTa
            };
            BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
            string result = bUS_KhachHang.InsertKhachHang(kh);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Thêm khách hàng thành công");
                ClearForm();
                LoadDanhSachKhachHang();
            }
            else
            {
                MessageBox.Show(result);
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maKH = cbMaKH.Text.Trim();
            string tenKH = txtTenKH.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string loaiKH = cbLoaiKhachHang.Text.Trim();
            string moTa = txtMoTa.Text.Trim();

            KhachHang kh = new KhachHang
            {
                MaKH = maKH,
                TenKH = tenKH,
                Email = email,
                SDT = sdt,
                DiaChi = diaChi,
                LoaiKH = loaiKH,
                MoTa = moTa
            };
            BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
            string result = bUS_KhachHang.UpdateKhachHang(kh);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật khách hàng thành công");
                ClearForm();
                LoadDanhSachKhachHang();
            }
            else
            {
                MessageBox.Show(result);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = cbMaKH.Text.Trim();
            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show(
                    "Vui lòng chọn mã khách hàng để xóa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
);

                return;
            }
            BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
            string result = bUS_KhachHang.DeleteKhachHang(maKH);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Xóa khách hàng thành công");
                ClearForm();
                LoadDanhSachKhachHang();
            }
            else
            {
                MessageBox.Show(result);
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachKhachHang();
        }
    }
}
