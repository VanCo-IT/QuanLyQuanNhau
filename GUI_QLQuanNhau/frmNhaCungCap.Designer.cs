namespace GUI_QLQuanNhau
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            pnThongTin = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbMaCC = new ComboBox();
            cbTenNCC = new ComboBox();
            gbChucNang = new GroupBox();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            button1 = new Button();
            dgvNhaCungCap = new DataGridView();
            pnThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
            SuspendLayout();
            // 
            // pnThongTin
            // 
            pnThongTin.BackColor = Color.FromArgb(255, 192, 192);
            pnThongTin.Controls.Add(cbTenNCC);
            pnThongTin.Controls.Add(cbMaCC);
            pnThongTin.Controls.Add(label5);
            pnThongTin.Controls.Add(label4);
            pnThongTin.Controls.Add(label3);
            pnThongTin.Controls.Add(label2);
            pnThongTin.Controls.Add(txtDiaChi);
            pnThongTin.Controls.Add(txtEmail);
            pnThongTin.Controls.Add(txtSDT);
            pnThongTin.Controls.Add(label1);
            pnThongTin.Controls.Add(pictureBox1);
            pnThongTin.Dock = DockStyle.Top;
            pnThongTin.Location = new Point(0, 0);
            pnThongTin.Name = "pnThongTin";
            pnThongTin.Size = new Size(884, 63);
            pnThongTin.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(103, 12);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 1;
            label1.Text = "Mã cung cấp";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(425, 30);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(130, 23);
            txtSDT.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(580, 30);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(130, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(740, 34);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(130, 23);
            txtDiaChi.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(269, 8);
            label2.Name = "label2";
            label2.Size = new Size(116, 19);
            label2.TabIndex = 7;
            label2.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(425, 9);
            label3.Name = "label3";
            label3.Size = new Size(33, 19);
            label3.TabIndex = 8;
            label3.Text = "SĐT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(580, 12);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(740, 12);
            label5.Name = "label5";
            label5.Size = new Size(50, 19);
            label5.TabIndex = 9;
            label5.Text = "Địa chỉ";
            // 
            // cbMaCC
            // 
            cbMaCC.FormattingEnabled = true;
            cbMaCC.Location = new Point(107, 33);
            cbMaCC.Name = "cbMaCC";
            cbMaCC.Size = new Size(130, 23);
            cbMaCC.TabIndex = 10;
            // 
            // cbTenNCC
            // 
            cbTenNCC.FormattingEnabled = true;
            cbTenNCC.Location = new Point(269, 34);
            cbTenNCC.Name = "cbTenNCC";
            cbTenNCC.Size = new Size(130, 23);
            cbTenNCC.TabIndex = 11;
            // 
            // gbChucNang
            // 
            gbChucNang.BackColor = Color.FromArgb(255, 128, 0);
            gbChucNang.Controls.Add(button1);
            gbChucNang.Controls.Add(btnXoa);
            gbChucNang.Controls.Add(btnCapNhat);
            gbChucNang.Controls.Add(btnThem);
            gbChucNang.Dock = DockStyle.Right;
            gbChucNang.Location = new Point(684, 63);
            gbChucNang.Name = "gbChucNang";
            gbChucNang.Size = new Size(200, 498);
            gbChucNang.TabIndex = 1;
            gbChucNang.TabStop = false;
            gbChucNang.Text = "Chức năng";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.TopCenter;
            btnThem.Location = new Point(6, 98);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 67);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.BottomCenter;
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCapNhat.Image = (Image)resources.GetObject("btnCapNhat.Image");
            btnCapNhat.ImageAlign = ContentAlignment.TopCenter;
            btnCapNhat.Location = new Point(106, 104);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(78, 61);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.TextAlign = ContentAlignment.BottomCenter;
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.TopCenter;
            btnXoa.Location = new Point(14, 202);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 70);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.BottomCenter;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(114, 203);
            button1.Name = "button1";
            button1.Size = new Size(75, 69);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaCungCap.Dock = DockStyle.Fill;
            dgvNhaCungCap.Location = new Point(0, 63);
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.Size = new Size(684, 498);
            dgvNhaCungCap.TabIndex = 2;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(dgvNhaCungCap);
            Controls.Add(gbChucNang);
            Controls.Add(pnThongTin);
            Name = "frmNhaCungCap";
            Text = "Nhà cung cấp";
            pnThongTin.ResumeLayout(false);
            pnThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnThongTin;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtSDT;
        private Label label3;
        private Label label2;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private ComboBox cbTenNCC;
        private ComboBox cbMaCC;
        private Label label5;
        private Label label4;
        private GroupBox gbChucNang;
        private Button btnThem;
        private Button button1;
        private Button btnXoa;
        private Button btnCapNhat;
        private DataGridView dgvNhaCungCap;
    }
}