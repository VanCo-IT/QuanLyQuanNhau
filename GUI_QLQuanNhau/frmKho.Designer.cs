namespace GUI_QLQuanNhau
{
    partial class frmKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKho));
            pnThongTin = new Panel();
            dateTimePicker1 = new DateTimePicker();
            cbSoLuong = new ComboBox();
            label3 = new Label();
            cbTenSanPham = new ComboBox();
            label4 = new Label();
            cbNguoiPhuTrach = new ComboBox();
            cbGiaNhap = new ComboBox();
            cbDonVi = new ComboBox();
            cbMaCungCap = new ComboBox();
            cbMaKho = new ComboBox();
            label9 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            gbChucNang = new GroupBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            dgvKho = new DataGridView();
            pnThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            SuspendLayout();
            // 
            // pnThongTin
            // 
            pnThongTin.BackColor = Color.FromArgb(255, 128, 128);
            pnThongTin.Controls.Add(dateTimePicker1);
            pnThongTin.Controls.Add(cbSoLuong);
            pnThongTin.Controls.Add(label3);
            pnThongTin.Controls.Add(cbTenSanPham);
            pnThongTin.Controls.Add(label4);
            pnThongTin.Controls.Add(cbNguoiPhuTrach);
            pnThongTin.Controls.Add(cbGiaNhap);
            pnThongTin.Controls.Add(cbDonVi);
            pnThongTin.Controls.Add(cbMaCungCap);
            pnThongTin.Controls.Add(cbMaKho);
            pnThongTin.Controls.Add(label9);
            pnThongTin.Controls.Add(textBox2);
            pnThongTin.Controls.Add(label8);
            pnThongTin.Controls.Add(label7);
            pnThongTin.Controls.Add(label6);
            pnThongTin.Controls.Add(label5);
            pnThongTin.Controls.Add(label2);
            pnThongTin.Controls.Add(label1);
            pnThongTin.Controls.Add(pictureBox1);
            pnThongTin.Dock = DockStyle.Top;
            pnThongTin.Location = new Point(0, 0);
            pnThongTin.Name = "pnThongTin";
            pnThongTin.Size = new Size(884, 127);
            pnThongTin.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(604, 89);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(206, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // cbSoLuong
            // 
            cbSoLuong.FormattingEnabled = true;
            cbSoLuong.Items.AddRange(new object[] { "1", "10", "100", "1 000", "10 000", "100 000", "1 000 000", "1 000 000 000" });
            cbSoLuong.Location = new Point(106, 89);
            cbSoLuong.Name = "cbSoLuong";
            cbSoLuong.Size = new Size(147, 23);
            cbSoLuong.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 71);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 5;
            label3.Text = "Số lượng";
            // 
            // cbTenSanPham
            // 
            cbTenSanPham.FormattingEnabled = true;
            cbTenSanPham.Items.AddRange(new object[] { "Bia", "Nước ngọt", "Cá", "Ốc", "Nước chấm", "Khác(Vui lòng ghi rõ)" });
            cbTenSanPham.Location = new Point(604, 27);
            cbTenSanPham.Name = "cbTenSanPham";
            cbTenSanPham.Size = new Size(147, 23);
            cbTenSanPham.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(604, 9);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 5;
            label4.Text = "Tên sản phẩm";
            // 
            // cbNguoiPhuTrach
            // 
            cbNguoiPhuTrach.FormattingEnabled = true;
            cbNguoiPhuTrach.Location = new Point(438, 27);
            cbNguoiPhuTrach.Name = "cbNguoiPhuTrach";
            cbNguoiPhuTrach.Size = new Size(147, 23);
            cbNguoiPhuTrach.TabIndex = 23;
            // 
            // cbGiaNhap
            // 
            cbGiaNhap.FormattingEnabled = true;
            cbGiaNhap.Items.AddRange(new object[] { "1 chục", "1 triệu", "1 tỷ" });
            cbGiaNhap.Location = new Point(442, 89);
            cbGiaNhap.Name = "cbGiaNhap";
            cbGiaNhap.Size = new Size(147, 23);
            cbGiaNhap.TabIndex = 22;
            // 
            // cbDonVi
            // 
            cbDonVi.FormattingEnabled = true;
            cbDonVi.Items.AddRange(new object[] { "Kg", "Con", "Lốc", "Thùng", "Chai", "Lít(L)" });
            cbDonVi.Location = new Point(272, 89);
            cbDonVi.Name = "cbDonVi";
            cbDonVi.Size = new Size(147, 23);
            cbDonVi.TabIndex = 21;
            // 
            // cbMaCungCap
            // 
            cbMaCungCap.FormattingEnabled = true;
            cbMaCungCap.Location = new Point(276, 27);
            cbMaCungCap.Name = "cbMaCungCap";
            cbMaCungCap.Size = new Size(147, 23);
            cbMaCungCap.TabIndex = 18;
            // 
            // cbMaKho
            // 
            cbMaKho.FormattingEnabled = true;
            cbMaKho.Location = new Point(106, 27);
            cbMaKho.Name = "cbMaKho";
            cbMaKho.Size = new Size(147, 23);
            cbMaKho.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(759, 9);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 16;
            label9.Text = "Mô tả";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(759, 27);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 49);
            textBox2.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(438, 9);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 13;
            label8.Text = "Người phụ trách";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(604, 71);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 11;
            label7.Text = "Thời gian nhâp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(442, 71);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 9;
            label6.Text = "Giá nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 71);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 7;
            label5.Text = "Đơn vị";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 9);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 3;
            label2.Text = "Mã cung cấp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã Kho";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // gbChucNang
            // 
            gbChucNang.BackColor = Color.FromArgb(255, 128, 0);
            gbChucNang.Controls.Add(btnLamMoi);
            gbChucNang.Controls.Add(btnXoa);
            gbChucNang.Controls.Add(btnCapNhat);
            gbChucNang.Controls.Add(btnThem);
            gbChucNang.Dock = DockStyle.Right;
            gbChucNang.Location = new Point(690, 127);
            gbChucNang.Name = "gbChucNang";
            gbChucNang.Size = new Size(194, 434);
            gbChucNang.TabIndex = 1;
            gbChucNang.TabStop = false;
            gbChucNang.Text = "Chức năng";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.Location = new Point(105, 242);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(83, 69);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.TextAlign = ContentAlignment.BottomCenter;
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.TopCenter;
            btnXoa.Location = new Point(6, 242);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(83, 69);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.BottomCenter;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCapNhat.Image = (Image)resources.GetObject("btnCapNhat.Image");
            btnCapNhat.ImageAlign = ContentAlignment.TopCenter;
            btnCapNhat.Location = new Point(105, 146);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(83, 69);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.TextAlign = ContentAlignment.BottomCenter;
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.TopCenter;
            btnThem.Location = new Point(6, 146);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(83, 69);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.BottomCenter;
            btnThem.UseVisualStyleBackColor = true;
            // 
            // dgvKho
            // 
            dgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKho.Dock = DockStyle.Fill;
            dgvKho.Location = new Point(0, 127);
            dgvKho.Name = "dgvKho";
            dgvKho.Size = new Size(690, 434);
            dgvKho.TabIndex = 2;
            // 
            // frmKho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(dgvKho);
            Controls.Add(gbChucNang);
            Controls.Add(pnThongTin);
            Name = "frmKho";
            Text = "frmKho";
            pnThongTin.ResumeLayout(false);
            pnThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnThongTin;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label9;
        private TextBox textBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox cbGiaNhap;
        private ComboBox cbDonVi;
        private ComboBox cbSoLuong;
        private ComboBox cbTenSanPham;
        private ComboBox cbMaCungCap;
        private ComboBox cbMaKho;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbNguoiPhuTrach;
        private GroupBox gbChucNang;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnThem;
        private DataGridView dgvKho;
    }
}