namespace GUI_QLQuanNhau
{
    partial class frmThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToan));
            pnifnormation = new Panel();
            dateTimePicker1 = new DateTimePicker();
            pnTrangThai = new Panel();
            rbDaHuy = new RadioButton();
            label7 = new Label();
            rbDaThanhToan = new RadioButton();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            cbHinhThuc = new ComboBox();
            label4 = new Label();
            txtSoTien = new TextBox();
            label3 = new Label();
            cbMaKH = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            gbChucNang = new GroupBox();
            btnXuatHoaDon = new Button();
            btnLamMoi = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            dgvThanhToan = new DataGridView();
            cbMaThanhToan = new ComboBox();
            pnifnormation.SuspendLayout();
            pnTrangThai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThanhToan).BeginInit();
            SuspendLayout();
            // 
            // pnifnormation
            // 
            pnifnormation.BackColor = Color.FromArgb(255, 224, 192);
            pnifnormation.Controls.Add(cbMaThanhToan);
            pnifnormation.Controls.Add(dateTimePicker1);
            pnifnormation.Controls.Add(pnTrangThai);
            pnifnormation.Controls.Add(label6);
            pnifnormation.Controls.Add(textBox1);
            pnifnormation.Controls.Add(label5);
            pnifnormation.Controls.Add(cbHinhThuc);
            pnifnormation.Controls.Add(label4);
            pnifnormation.Controls.Add(txtSoTien);
            pnifnormation.Controls.Add(label3);
            pnifnormation.Controls.Add(cbMaKH);
            pnifnormation.Controls.Add(label2);
            pnifnormation.Controls.Add(label1);
            pnifnormation.Controls.Add(pictureBox1);
            pnifnormation.Dock = DockStyle.Top;
            pnifnormation.Location = new Point(0, 0);
            pnifnormation.Name = "pnifnormation";
            pnifnormation.Size = new Size(884, 112);
            pnifnormation.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(419, 29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // pnTrangThai
            // 
            pnTrangThai.BackColor = Color.FromArgb(255, 255, 128);
            pnTrangThai.Controls.Add(rbDaHuy);
            pnTrangThai.Controls.Add(label7);
            pnTrangThai.Controls.Add(rbDaThanhToan);
            pnTrangThai.Dock = DockStyle.Right;
            pnTrangThai.Location = new Point(713, 0);
            pnTrangThai.Name = "pnTrangThai";
            pnTrangThai.Size = new Size(171, 112);
            pnTrangThai.TabIndex = 12;
            // 
            // rbDaHuy
            // 
            rbDaHuy.AutoSize = true;
            rbDaHuy.Location = new Point(102, 36);
            rbDaHuy.Name = "rbDaHuy";
            rbDaHuy.Size = new Size(62, 19);
            rbDaHuy.TabIndex = 1;
            rbDaHuy.TabStop = true;
            rbDaHuy.Text = "Đã hủy";
            rbDaHuy.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 11);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 11;
            label7.Text = "Trạng thái";
            // 
            // rbDaThanhToan
            // 
            rbDaThanhToan.AutoSize = true;
            rbDaThanhToan.Location = new Point(76, 11);
            rbDaThanhToan.Name = "rbDaThanhToan";
            rbDaThanhToan.Size = new Size(100, 19);
            rbDaThanhToan.TabIndex = 0;
            rbDaThanhToan.TabStop = true;
            rbDaThanhToan.Text = "Đã thanh toán";
            rbDaThanhToan.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(419, 11);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 9;
            label6.Text = "Ngày giao dịch";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(419, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(419, 62);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 1;
            label5.Text = "Mô tả";
            // 
            // cbHinhThuc
            // 
            cbHinhThuc.FormattingEnabled = true;
            cbHinhThuc.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "Quẹt thẻ(máy pos)" });
            cbHinhThuc.Location = new Point(243, 79);
            cbHinhThuc.Name = "cbHinhThuc";
            cbHinhThuc.Size = new Size(135, 23);
            cbHinhThuc.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(244, 62);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Hình thức";
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(94, 75);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(135, 23);
            txtSoTien.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 62);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "Số tiền";
            // 
            // cbMaKH
            // 
            cbMaKH.FormattingEnabled = true;
            cbMaKH.Location = new Point(244, 29);
            cbMaKH.Name = "cbMaKH";
            cbMaKH.Size = new Size(135, 23);
            cbMaKH.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 12);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 14);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã thanh toán";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // gbChucNang
            // 
            gbChucNang.BackColor = Color.FromArgb(192, 255, 255);
            gbChucNang.Controls.Add(btnXuatHoaDon);
            gbChucNang.Controls.Add(btnLamMoi);
            gbChucNang.Controls.Add(btnCapNhat);
            gbChucNang.Controls.Add(btnThem);
            gbChucNang.Dock = DockStyle.Right;
            gbChucNang.Location = new Point(666, 112);
            gbChucNang.Name = "gbChucNang";
            gbChucNang.Size = new Size(218, 449);
            gbChucNang.TabIndex = 1;
            gbChucNang.TabStop = false;
            gbChucNang.Text = "Chức năng";
            // 
            // btnXuatHoaDon
            // 
            btnXuatHoaDon.Image = (Image)resources.GetObject("btnXuatHoaDon.Image");
            btnXuatHoaDon.Location = new Point(128, 195);
            btnXuatHoaDon.Name = "btnXuatHoaDon";
            btnXuatHoaDon.Size = new Size(83, 83);
            btnXuatHoaDon.TabIndex = 3;
            btnXuatHoaDon.Text = "Hóa đơn";
            btnXuatHoaDon.TextAlign = ContentAlignment.BottomCenter;
            btnXuatHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.ImageAlign = ContentAlignment.TopCenter;
            btnLamMoi.Location = new Point(17, 195);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(90, 83);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextAlign = ContentAlignment.BottomCenter;
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Image = (Image)resources.GetObject("btnCapNhat.Image");
            btnCapNhat.ImageAlign = ContentAlignment.TopCenter;
            btnCapNhat.Location = new Point(123, 92);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(90, 66);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.TextAlign = ContentAlignment.BottomCenter;
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.TopCenter;
            btnThem.Location = new Point(6, 92);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 66);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.BottomCenter;
            btnThem.UseVisualStyleBackColor = true;
            // 
            // dgvThanhToan
            // 
            dgvThanhToan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThanhToan.Dock = DockStyle.Fill;
            dgvThanhToan.Location = new Point(0, 112);
            dgvThanhToan.Name = "dgvThanhToan";
            dgvThanhToan.Size = new Size(666, 449);
            dgvThanhToan.TabIndex = 2;
            // 
            // cbMaThanhToan
            // 
            cbMaThanhToan.FormattingEnabled = true;
            cbMaThanhToan.Location = new Point(94, 29);
            cbMaThanhToan.Name = "cbMaThanhToan";
            cbMaThanhToan.Size = new Size(135, 23);
            cbMaThanhToan.TabIndex = 14;
            // 
            // frmThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(dgvThanhToan);
            Controls.Add(gbChucNang);
            Controls.Add(pnifnormation);
            Name = "frmThanhToan";
            Text = "Thanh toán hóa đơn";
            pnifnormation.ResumeLayout(false);
            pnifnormation.PerformLayout();
            pnTrangThai.ResumeLayout(false);
            pnTrangThai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThanhToan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnifnormation;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtMaThanhToan;
        private ComboBox cbMaKH;
        private Label label2;
        private ComboBox cbHinhThuc;
        private Label label4;
        private TextBox txtSoTien;
        private Label label3;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private Panel pnTrangThai;
        private RadioButton rbDaHuy;
        private Label label7;
        private RadioButton rbDaThanhToan;
        private DateTimePicker dateTimePicker1;
        private GroupBox gbChucNang;
        private Button btnThem;
        private DataGridView dgvThanhToan;
        private Button btnXuatHoaDon;
        private Button btnLamMoi;
        private Button btnCapNhat;
        private ComboBox cbMaThanhToan;
    }
}