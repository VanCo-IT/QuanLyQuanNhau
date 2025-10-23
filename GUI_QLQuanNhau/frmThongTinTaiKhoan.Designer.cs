namespace GUI_QLQuanNhau
{
    partial class frmThongTinTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinTaiKhoan));
            pnLichSuDangNhap = new Panel();
            dgvLichSuDangNhap = new DataGridView();
            label2 = new Label();
            pnThongTinTaiKhoan = new Panel();
            btnThoat = new Button();
            btnThayDoiThongTin = new Button();
            pnSoDienThoai = new Panel();
            txtSoDienThoai = new TextBox();
            label5 = new Label();
            pbAnhDienThoai = new PictureBox();
            pnThongTinMK = new Panel();
            txtMatKhau = new TextBox();
            label4 = new Label();
            pbAnhMK = new PictureBox();
            pnEmail = new Panel();
            txtEmail = new TextBox();
            label3 = new Label();
            pbAnhEmail = new PictureBox();
            pnAnhDaiDien = new Panel();
            pbAnhDangNhap = new PictureBox();
            btnThayAnh = new Button();
            label1 = new Label();
            pnLichSuDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSuDangNhap).BeginInit();
            pnThongTinTaiKhoan.SuspendLayout();
            pnSoDienThoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnhDienThoai).BeginInit();
            pnThongTinMK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnhMK).BeginInit();
            pnEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnhEmail).BeginInit();
            pnAnhDaiDien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnhDangNhap).BeginInit();
            SuspendLayout();
            // 
            // pnLichSuDangNhap
            // 
            pnLichSuDangNhap.BackColor = Color.FromArgb(128, 255, 128);
            pnLichSuDangNhap.Controls.Add(dgvLichSuDangNhap);
            pnLichSuDangNhap.Controls.Add(label2);
            pnLichSuDangNhap.Dock = DockStyle.Right;
            pnLichSuDangNhap.Location = new Point(196, 0);
            pnLichSuDangNhap.Name = "pnLichSuDangNhap";
            pnLichSuDangNhap.Size = new Size(688, 561);
            pnLichSuDangNhap.TabIndex = 0;
            // 
            // dgvLichSuDangNhap
            // 
            dgvLichSuDangNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSuDangNhap.Dock = DockStyle.Fill;
            dgvLichSuDangNhap.Location = new Point(0, 28);
            dgvLichSuDangNhap.Name = "dgvLichSuDangNhap";
            dgvLichSuDangNhap.Size = new Size(688, 533);
            dgvLichSuDangNhap.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Fuchsia;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(185, 28);
            label2.TabIndex = 2;
            label2.Text = "Lịch sử đăng nhập";
            // 
            // pnThongTinTaiKhoan
            // 
            pnThongTinTaiKhoan.BackColor = Color.FromArgb(128, 255, 255);
            pnThongTinTaiKhoan.Controls.Add(btnThoat);
            pnThongTinTaiKhoan.Controls.Add(btnThayDoiThongTin);
            pnThongTinTaiKhoan.Controls.Add(pnSoDienThoai);
            pnThongTinTaiKhoan.Controls.Add(pnThongTinMK);
            pnThongTinTaiKhoan.Controls.Add(pnEmail);
            pnThongTinTaiKhoan.Controls.Add(pnAnhDaiDien);
            pnThongTinTaiKhoan.Controls.Add(label1);
            pnThongTinTaiKhoan.Dock = DockStyle.Fill;
            pnThongTinTaiKhoan.Location = new Point(0, 0);
            pnThongTinTaiKhoan.Name = "pnThongTinTaiKhoan";
            pnThongTinTaiKhoan.Size = new Size(196, 561);
            pnThongTinTaiKhoan.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(33, 403);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(113, 50);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThayDoiThongTin
            // 
            btnThayDoiThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThayDoiThongTin.ForeColor = Color.Blue;
            btnThayDoiThongTin.Location = new Point(33, 305);
            btnThayDoiThongTin.Name = "btnThayDoiThongTin";
            btnThayDoiThongTin.Size = new Size(113, 56);
            btnThayDoiThongTin.TabIndex = 2;
            btnThayDoiThongTin.Text = "Thay đổi thông tin";
            btnThayDoiThongTin.UseVisualStyleBackColor = true;
            btnThayDoiThongTin.Click += btnThayDoiThongTin_Click;
            // 
            // pnSoDienThoai
            // 
            pnSoDienThoai.Controls.Add(txtSoDienThoai);
            pnSoDienThoai.Controls.Add(label5);
            pnSoDienThoai.Controls.Add(pbAnhDienThoai);
            pnSoDienThoai.Dock = DockStyle.Top;
            pnSoDienThoai.Location = new Point(0, 200);
            pnSoDienThoai.Name = "pnSoDienThoai";
            pnSoDienThoai.Size = new Size(196, 54);
            pnSoDienThoai.TabIndex = 4;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Dock = DockStyle.Bottom;
            txtSoDienThoai.Location = new Point(50, 31);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(146, 23);
            txtSoDienThoai.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(50, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 1;
            label5.Text = "Số điện thoại";
            // 
            // pbAnhDienThoai
            // 
            pbAnhDienThoai.Dock = DockStyle.Left;
            pbAnhDienThoai.Image = (Image)resources.GetObject("pbAnhDienThoai.Image");
            pbAnhDienThoai.Location = new Point(0, 0);
            pbAnhDienThoai.Name = "pbAnhDienThoai";
            pbAnhDienThoai.Size = new Size(50, 54);
            pbAnhDienThoai.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAnhDienThoai.TabIndex = 0;
            pbAnhDienThoai.TabStop = false;
            // 
            // pnThongTinMK
            // 
            pnThongTinMK.Controls.Add(txtMatKhau);
            pnThongTinMK.Controls.Add(label4);
            pnThongTinMK.Controls.Add(pbAnhMK);
            pnThongTinMK.Dock = DockStyle.Top;
            pnThongTinMK.Location = new Point(0, 146);
            pnThongTinMK.Name = "pnThongTinMK";
            pnThongTinMK.Size = new Size(196, 54);
            pnThongTinMK.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Dock = DockStyle.Bottom;
            txtMatKhau.Location = new Point(50, 31);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(146, 23);
            txtMatKhau.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(50, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 1;
            label4.Text = "Mật khẩu";
            // 
            // pbAnhMK
            // 
            pbAnhMK.Dock = DockStyle.Left;
            pbAnhMK.Image = (Image)resources.GetObject("pbAnhMK.Image");
            pbAnhMK.Location = new Point(0, 0);
            pbAnhMK.Name = "pbAnhMK";
            pbAnhMK.Size = new Size(50, 54);
            pbAnhMK.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAnhMK.TabIndex = 0;
            pbAnhMK.TabStop = false;
            // 
            // pnEmail
            // 
            pnEmail.Controls.Add(txtEmail);
            pnEmail.Controls.Add(label3);
            pnEmail.Controls.Add(pbAnhEmail);
            pnEmail.Dock = DockStyle.Top;
            pnEmail.Location = new Point(0, 92);
            pnEmail.Name = "pnEmail";
            pnEmail.Size = new Size(196, 54);
            pnEmail.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Bottom;
            txtEmail.Location = new Point(50, 31);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(146, 23);
            txtEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(50, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 1;
            label3.Text = "Email";
            // 
            // pbAnhEmail
            // 
            pbAnhEmail.Dock = DockStyle.Left;
            pbAnhEmail.Image = (Image)resources.GetObject("pbAnhEmail.Image");
            pbAnhEmail.Location = new Point(0, 0);
            pbAnhEmail.Name = "pbAnhEmail";
            pbAnhEmail.Size = new Size(50, 54);
            pbAnhEmail.SizeMode = PictureBoxSizeMode.CenterImage;
            pbAnhEmail.TabIndex = 0;
            pbAnhEmail.TabStop = false;
            // 
            // pnAnhDaiDien
            // 
            pnAnhDaiDien.Controls.Add(pbAnhDangNhap);
            pnAnhDaiDien.Controls.Add(btnThayAnh);
            pnAnhDaiDien.Dock = DockStyle.Top;
            pnAnhDaiDien.Location = new Point(0, 28);
            pnAnhDaiDien.Name = "pnAnhDaiDien";
            pnAnhDaiDien.Size = new Size(196, 64);
            pnAnhDaiDien.TabIndex = 1;
            // 
            // pbAnhDangNhap
            // 
            pbAnhDangNhap.Dock = DockStyle.Left;
            pbAnhDangNhap.Image = (Image)resources.GetObject("pbAnhDangNhap.Image");
            pbAnhDangNhap.Location = new Point(0, 0);
            pbAnhDangNhap.Name = "pbAnhDangNhap";
            pbAnhDangNhap.Size = new Size(105, 64);
            pbAnhDangNhap.SizeMode = PictureBoxSizeMode.Zoom;
            pbAnhDangNhap.TabIndex = 1;
            pbAnhDangNhap.TabStop = false;
            // 
            // btnThayAnh
            // 
            btnThayAnh.BackColor = Color.FromArgb(255, 192, 192);
            btnThayAnh.BackgroundImage = (Image)resources.GetObject("btnThayAnh.BackgroundImage");
            btnThayAnh.BackgroundImageLayout = ImageLayout.Zoom;
            btnThayAnh.Dock = DockStyle.Right;
            btnThayAnh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThayAnh.Location = new Point(102, 0);
            btnThayAnh.Name = "btnThayAnh";
            btnThayAnh.Size = new Size(94, 64);
            btnThayAnh.TabIndex = 0;
            btnThayAnh.Text = "Thay đổi ảnh";
            btnThayAnh.TextAlign = ContentAlignment.BottomCenter;
            btnThayAnh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThayAnh.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 28);
            label1.TabIndex = 0;
            label1.Text = "Thông tin tài khoản";
            // 
            // frmThongTinTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(884, 561);
            Controls.Add(pnThongTinTaiKhoan);
            Controls.Add(pnLichSuDangNhap);
            Name = "frmThongTinTaiKhoan";
            Load += frmThongTinTaiKhoan_Load;
            pnLichSuDangNhap.ResumeLayout(false);
            pnLichSuDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSuDangNhap).EndInit();
            pnThongTinTaiKhoan.ResumeLayout(false);
            pnThongTinTaiKhoan.PerformLayout();
            pnSoDienThoai.ResumeLayout(false);
            pnSoDienThoai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnhDienThoai).EndInit();
            pnThongTinMK.ResumeLayout(false);
            pnThongTinMK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnhMK).EndInit();
            pnEmail.ResumeLayout(false);
            pnEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnhEmail).EndInit();
            pnAnhDaiDien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAnhDangNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnLichSuDangNhap;
        private Panel pnThongTinTaiKhoan;
        private Label label1;
        private Panel pnAnhDaiDien;
        private Button btnThayAnh;
        private Panel pnEmail;
        private TextBox txtEmail;
        private Label label3;
        private PictureBox pbAnhEmail;
        private PictureBox pbAnhDangNhap;
        private Panel pnThongTinMK;
        private PictureBox pbAnhMK;
        private Label label4;
        private Panel pnSoDienThoai;
        private PictureBox pbAnhDienThoai;
        private TextBox txtMatKhau;
        private TextBox txtSoDienThoai;
        private Label label5;
        private Button btnThoat;
        private Button btnThayDoiThongTin;
        private DataGridView dgvLichSuDangNhap;
        private Label label2;
    }
}