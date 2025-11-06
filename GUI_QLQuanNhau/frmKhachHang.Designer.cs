namespace GUI_QLQuanNhau
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            pnThongTinKhachHang = new Panel();
            cbMaKH = new ComboBox();
            cbLoaiKhachHang = new ComboBox();
            txtMoTa = new TextBox();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtTenKH = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pbKhachHang = new PictureBox();
            gbChucNang = new GroupBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            dgvKhachHang = new DataGridView();
            pnThongTinKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbKhachHang).BeginInit();
            gbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // pnThongTinKhachHang
            // 
            pnThongTinKhachHang.BackColor = Color.FromArgb(128, 255, 128);
            pnThongTinKhachHang.Controls.Add(cbMaKH);
            pnThongTinKhachHang.Controls.Add(cbLoaiKhachHang);
            pnThongTinKhachHang.Controls.Add(txtMoTa);
            pnThongTinKhachHang.Controls.Add(txtDiaChi);
            pnThongTinKhachHang.Controls.Add(txtEmail);
            pnThongTinKhachHang.Controls.Add(txtSDT);
            pnThongTinKhachHang.Controls.Add(txtTenKH);
            pnThongTinKhachHang.Controls.Add(label7);
            pnThongTinKhachHang.Controls.Add(label6);
            pnThongTinKhachHang.Controls.Add(label5);
            pnThongTinKhachHang.Controls.Add(label4);
            pnThongTinKhachHang.Controls.Add(label3);
            pnThongTinKhachHang.Controls.Add(label2);
            pnThongTinKhachHang.Controls.Add(label1);
            pnThongTinKhachHang.Controls.Add(pbKhachHang);
            pnThongTinKhachHang.Dock = DockStyle.Top;
            pnThongTinKhachHang.Location = new Point(0, 0);
            pnThongTinKhachHang.Name = "pnThongTinKhachHang";
            pnThongTinKhachHang.Size = new Size(884, 110);
            pnThongTinKhachHang.TabIndex = 0;
            // 
            // cbMaKH
            // 
            cbMaKH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaKH.FormattingEnabled = true;
            cbMaKH.Location = new Point(116, 29);
            cbMaKH.Name = "cbMaKH";
            cbMaKH.Size = new Size(133, 23);
            cbMaKH.TabIndex = 16;
            cbMaKH.SelectedIndexChanged += cbMaKH_SelectedIndexChanged;
            // 
            // cbLoaiKhachHang
            // 
            cbLoaiKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoaiKhachHang.FormattingEnabled = true;
            cbLoaiKhachHang.Items.AddRange(new object[] { "Khách lẻ", "Khách quen", "Khách tiềm năng", "Khách Vip", "Khách khó tính", "Sổ đen" });
            cbLoaiKhachHang.Location = new Point(279, 87);
            cbLoaiKhachHang.Name = "cbLoaiKhachHang";
            cbLoaiKhachHang.Size = new Size(130, 23);
            cbLoaiKhachHang.TabIndex = 15;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(448, 87);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(130, 23);
            txtMoTa.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(119, 84);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(130, 23);
            txtDiaChi.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(607, 27);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(130, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(448, 26);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(130, 23);
            txtSDT.TabIndex = 10;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(279, 26);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(130, 23);
            txtTenKH.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(448, 68);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 8;
            label7.Text = "Mô tả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(279, 66);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 7;
            label6.Text = "Loại khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 66);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 6;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(607, 6);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 6);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 4;
            label3.Text = "SDT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 3);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã khách hàng";
            // 
            // pbKhachHang
            // 
            pbKhachHang.Dock = DockStyle.Left;
            pbKhachHang.Image = (Image)resources.GetObject("pbKhachHang.Image");
            pbKhachHang.Location = new Point(0, 0);
            pbKhachHang.Name = "pbKhachHang";
            pbKhachHang.Size = new Size(100, 110);
            pbKhachHang.SizeMode = PictureBoxSizeMode.StretchImage;
            pbKhachHang.TabIndex = 0;
            pbKhachHang.TabStop = false;
            // 
            // gbChucNang
            // 
            gbChucNang.BackColor = Color.FromArgb(255, 192, 192);
            gbChucNang.Controls.Add(btnLamMoi);
            gbChucNang.Controls.Add(btnXoa);
            gbChucNang.Controls.Add(btnCapNhat);
            gbChucNang.Controls.Add(btnThem);
            gbChucNang.Dock = DockStyle.Right;
            gbChucNang.Location = new Point(684, 110);
            gbChucNang.Name = "gbChucNang";
            gbChucNang.Size = new Size(200, 451);
            gbChucNang.TabIndex = 1;
            gbChucNang.TabStop = false;
            gbChucNang.Text = "Chức năng";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackgroundImage = (Image)resources.GetObject("btnLamMoi.BackgroundImage");
            btnLamMoi.BackgroundImageLayout = ImageLayout.Stretch;
            btnLamMoi.ImageAlign = ContentAlignment.TopCenter;
            btnLamMoi.Location = new Point(113, 205);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 68);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.TextAlign = ContentAlignment.BottomCenter;
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.TopCenter;
            btnXoa.Location = new Point(12, 205);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(73, 68);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.BottomCenter;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Image = (Image)resources.GetObject("btnCapNhat.Image");
            btnCapNhat.ImageAlign = ContentAlignment.TopCenter;
            btnCapNhat.Location = new Point(108, 105);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 66);
            btnCapNhat.TabIndex = 4;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.TextAlign = ContentAlignment.BottomCenter;
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.TopCenter;
            btnThem.Location = new Point(6, 105);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(79, 66);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.BottomCenter;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(0, 110);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.Size = new Size(684, 451);
            dgvKhachHang.TabIndex = 2;
            dgvKhachHang.CellDoubleClick += dgvKhachHang_CellDoubleClick;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(dgvKhachHang);
            Controls.Add(gbChucNang);
            Controls.Add(pnThongTinKhachHang);
            Name = "frmKhachHang";
            Text = "Khách hàng";
            Load += frmKhachHang_Load;
            pnThongTinKhachHang.ResumeLayout(false);
            pnThongTinKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbKhachHang).EndInit();
            gbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnThongTinKhachHang;
        private Label label1;
        private PictureBox pbKhachHang;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtMoTa;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtTenKH;
        private GroupBox gbChucNang;
        private Button btnThem;
        private DataGridView dgvKhachHang;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnCapNhat;
        private ComboBox cbLoaiKhachHang;
        private ComboBox cbMaKH;
    }
}