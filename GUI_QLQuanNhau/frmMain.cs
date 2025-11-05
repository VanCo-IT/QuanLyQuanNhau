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
using UTIL_QLQuanNhau;

namespace GUI_QLQuanNhau
{
    public partial class frmMain : Form
    {
        private Staff currentStaff;
        public frmMain(Staff staff)
        {
            InitializeComponent();
            currentStaff = staff;
        }
        private Form currentFormChild;

        private void openChildForm(Form formChild)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            pnMain.Controls.Add(formChild);
            pnMain.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMK reset = new frmDoiMK();
            reset.ShowDialog();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongTinTaiKhoan(currentStaff));
        }

        private void đăngXuấtTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mnuKhachHang.Visible = false;
            //mnuGiaoDich.Visible = false;
            //mnuKhoanvay.Visible = false;
            //mnuNhanVien.Visible = false;
            //mnuTroGiup.Visible = false;
            // có chức năng gì thì cho nó false là xong
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất?", "Đăng xuất",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               );
            if (result == DialogResult.Yes)
            {
                this.Hide();
                AuthUtil.user = null;
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void thoátỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát khỏi chương trình", "Thoát",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmStaff());
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThanhToan());
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKhachHang());
        }
    }
}
