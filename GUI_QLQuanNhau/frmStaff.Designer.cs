namespace GUI_QLQuanNhau
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            pnThietKe = new Panel();
            pnTrangThai = new Panel();
            rbHoatDong = new RadioButton();
            rbTamNgung = new RadioButton();
            label8 = new Label();
            rbQuanLy = new RadioButton();
            rbNhanVien = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            txtMatKhau = new TextBox();
            txtEmail = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtTenNV = new TextBox();
            txtSoDienThoai = new TextBox();
            txtMaNV = new TextBox();
            label1 = new Label();
            txtTenDN = new TextBox();
            label3 = new Label();
            pbStaff = new PictureBox();
            panel1 = new Panel();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            dgvStaff = new DataGridView();
            pnThietKe.SuspendLayout();
            pnTrangThai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbStaff).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            SuspendLayout();
            // 
            // pnThietKe
            // 
            pnThietKe.BackColor = Color.FromArgb(255, 192, 192);
            pnThietKe.Controls.Add(pnTrangThai);
            pnThietKe.Controls.Add(rbQuanLy);
            pnThietKe.Controls.Add(rbNhanVien);
            pnThietKe.Controls.Add(label7);
            pnThietKe.Controls.Add(label6);
            pnThietKe.Controls.Add(txtMatKhau);
            pnThietKe.Controls.Add(txtEmail);
            pnThietKe.Controls.Add(label5);
            pnThietKe.Controls.Add(label2);
            pnThietKe.Controls.Add(label4);
            pnThietKe.Controls.Add(txtTenNV);
            pnThietKe.Controls.Add(txtSoDienThoai);
            pnThietKe.Controls.Add(txtMaNV);
            pnThietKe.Controls.Add(label1);
            pnThietKe.Controls.Add(txtTenDN);
            pnThietKe.Controls.Add(label3);
            pnThietKe.Controls.Add(pbStaff);
            pnThietKe.Dock = DockStyle.Top;
            pnThietKe.Location = new Point(0, 0);
            pnThietKe.Name = "pnThietKe";
            pnThietKe.Size = new Size(800, 83);
            pnThietKe.TabIndex = 0;
            // 
            // pnTrangThai
            // 
            pnTrangThai.Controls.Add(rbHoatDong);
            pnTrangThai.Controls.Add(rbTamNgung);
            pnTrangThai.Controls.Add(label8);
            pnTrangThai.Dock = DockStyle.Right;
            pnTrangThai.Location = new Point(666, 0);
            pnTrangThai.Name = "pnTrangThai";
            pnTrangThai.Size = new Size(134, 83);
            pnTrangThai.TabIndex = 14;
            // 
            // rbHoatDong
            // 
            rbHoatDong.AutoSize = true;
            rbHoatDong.Dock = DockStyle.Bottom;
            rbHoatDong.Location = new Point(0, 45);
            rbHoatDong.Name = "rbHoatDong";
            rbHoatDong.Size = new Size(134, 19);
            rbHoatDong.TabIndex = 3;
            rbHoatDong.TabStop = true;
            rbHoatDong.Text = "Hoạt động";
            rbHoatDong.UseVisualStyleBackColor = true;
            // 
            // rbTamNgung
            // 
            rbTamNgung.AutoSize = true;
            rbTamNgung.Dock = DockStyle.Bottom;
            rbTamNgung.Location = new Point(0, 64);
            rbTamNgung.Name = "rbTamNgung";
            rbTamNgung.Size = new Size(134, 19);
            rbTamNgung.TabIndex = 2;
            rbTamNgung.TabStop = true;
            rbTamNgung.Text = "Tạm ngưng";
            rbTamNgung.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 0;
            label8.Text = "Trạng thái";
            // 
            // rbQuanLy
            // 
            rbQuanLy.AutoSize = true;
            rbQuanLy.Location = new Point(544, 57);
            rbQuanLy.Name = "rbQuanLy";
            rbQuanLy.Size = new Size(66, 19);
            rbQuanLy.TabIndex = 13;
            rbQuanLy.TabStop = true;
            rbQuanLy.Text = "Quản lý";
            rbQuanLy.UseVisualStyleBackColor = true;
            // 
            // rbNhanVien
            // 
            rbNhanVien.AutoSize = true;
            rbNhanVien.Location = new Point(544, 32);
            rbNhanVien.Name = "rbNhanVien";
            rbNhanVien.Size = new Size(79, 19);
            rbNhanVien.TabIndex = 12;
            rbNhanVien.TabStop = true;
            rbNhanVien.Text = "Nhân viên";
            rbNhanVien.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(544, 0);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 2;
            label7.Text = "Vai trò";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(389, 42);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(389, 57);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(111, 23);
            txtMatKhau.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(389, 15);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(111, 23);
            txtEmail.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(389, 0);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 2;
            label5.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 45);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 7;
            label2.Text = "Tên nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 42);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 7;
            label4.Text = "Số điện thoại";
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(97, 60);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(117, 23);
            txtTenNV.TabIndex = 6;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(246, 57);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(115, 23);
            txtSoDienThoai.TabIndex = 6;
            // 
            // txtMaNV
            // 
            txtMaNV.BackColor = Color.Silver;
            txtMaNV.Location = new Point(97, 15);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(117, 23);
            txtMaNV.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 4;
            label1.Text = "Mã nhân viên";
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(246, 15);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(115, 23);
            txtTenDN.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, -3);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 4;
            label3.Text = "Tên đăng nhập";
            // 
            // pbStaff
            // 
            pbStaff.Dock = DockStyle.Left;
            pbStaff.Image = (Image)resources.GetObject("pbStaff.Image");
            pbStaff.Location = new Point(0, 0);
            pbStaff.Name = "pbStaff";
            pbStaff.Size = new Size(91, 83);
            pbStaff.SizeMode = PictureBoxSizeMode.Zoom;
            pbStaff.TabIndex = 0;
            pbStaff.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnCapNhat);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(dgvStaff);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 367);
            panel1.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.BackgroundImage = (Image)resources.GetObject("btnXoa.BackgroundImage");
            btnXoa.BackgroundImageLayout = ImageLayout.Center;
            btnXoa.ImageAlign = ContentAlignment.TopCenter;
            btnXoa.Location = new Point(653, 191);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 57);
            btnXoa.TabIndex = 4;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackgroundImage = (Image)resources.GetObject("btnLamMoi.BackgroundImage");
            btnLamMoi.BackgroundImageLayout = ImageLayout.Stretch;
            btnLamMoi.Location = new Point(729, 184);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(68, 64);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextAlign = ContentAlignment.BottomCenter;
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackgroundImage = (Image)resources.GetObject("btnCapNhat.BackgroundImage");
            btnCapNhat.BackgroundImageLayout = ImageLayout.Center;
            btnCapNhat.ImageAlign = ContentAlignment.TopCenter;
            btnCapNhat.Location = new Point(729, 91);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(68, 72);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.TextAlign = ContentAlignment.BottomCenter;
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.BackgroundImage = (Image)resources.GetObject("btnThem.BackgroundImage");
            btnThem.BackgroundImageLayout = ImageLayout.Center;
            btnThem.ImageAlign = ContentAlignment.TopCenter;
            btnThem.Location = new Point(653, 91);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(73, 72);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.BottomCenter;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvStaff
            // 
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Dock = DockStyle.Left;
            dgvStaff.Location = new Point(0, 0);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.Size = new Size(638, 367);
            dgvStaff.TabIndex = 0;
            dgvStaff.CellDoubleClick += dgvStaff_CellDoubleClick;
            // 
            // frmStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pnThietKe);
            Name = "frmStaff";
            Text = "Nhân viên";
            Load += frmStaff_Load;
            pnThietKe.ResumeLayout(false);
            pnThietKe.PerformLayout();
            pnTrangThai.ResumeLayout(false);
            pnTrangThai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbStaff).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnThietKe;
        private Panel panel1;
        private DataGridView dgvStaff;
        private PictureBox pbStaff;
        private Label label2;
        private Label label4;
        private TextBox txtTenNV;
        private TextBox txtSoDienThoai;
        private TextBox txtMaNV;
        private Label label1;
        private TextBox txtTenDN;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtMatKhau;
        private TextBox txtEmail;
        private RadioButton rbQuanLy;
        private RadioButton rbNhanVien;
        private Label label7;
        private Panel pnTrangThai;
        private RadioButton rbHoatDong;
        private RadioButton rbTamNgung;
        private Label label8;
        private Button btnThem;
        private Button btnLamMoi;
        private Button btnCapNhat;
        private Button btnXoa;
    }
}