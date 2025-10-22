namespace GUI_QLQuanNhau
{
    partial class frmDoiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMK));
            label1 = new Label();
            txtMatKhauCu = new TextBox();
            label2 = new Label();
            txtMatKhauMoi = new TextBox();
            label3 = new Label();
            txtXacNhanMK = new TextBox();
            btnDoiMK = new Button();
            btnThoat = new Button();
            btnHienMKCu = new Button();
            btnHienMKMoi = new Button();
            btnHienXacNhanMK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 19);
            label1.TabIndex = 2;
            label1.Text = "Nhập mật khẩu cũ";
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new Point(0, 19);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.PasswordChar = '*';
            txtMatKhauCu.Size = new Size(234, 23);
            txtMatKhauCu.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 42);
            label2.Name = "label2";
            label2.Size = new Size(131, 19);
            label2.TabIndex = 4;
            label2.Text = "Nhập mật khẩu mới";
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(0, 61);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '#';
            txtMatKhauMoi.Size = new Size(234, 23);
            txtMatKhauMoi.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 84);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 6;
            label3.Text = "Xác nhận mật khẩu";
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(0, 99);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '#';
            txtXacNhanMK.Size = new Size(234, 23);
            txtXacNhanMK.TabIndex = 7;
            // 
            // btnDoiMK
            // 
            btnDoiMK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDoiMK.BackColor = Color.FromArgb(255, 128, 0);
            btnDoiMK.Location = new Point(-1, 162);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(87, 46);
            btnDoiMK.TabIndex = 8;
            btnDoiMK.Text = "Đổi mật khẩu";
            btnDoiMK.UseVisualStyleBackColor = false;
            btnDoiMK.Click += btnDoiMK_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThoat.BackColor = Color.FromArgb(255, 128, 0);
            btnThoat.Location = new Point(147, 162);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 46);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHienMKCu
            // 
            btnHienMKCu.BackgroundImage = (Image)resources.GetObject("btnHienMKCu.BackgroundImage");
            btnHienMKCu.BackgroundImageLayout = ImageLayout.Zoom;
            btnHienMKCu.Location = new Point(240, 19);
            btnHienMKCu.Name = "btnHienMKCu";
            btnHienMKCu.Size = new Size(54, 23);
            btnHienMKCu.TabIndex = 10;
            btnHienMKCu.UseVisualStyleBackColor = true;
            btnHienMKCu.Click += btnHienMKCu_Click;
            // 
            // btnHienMKMoi
            // 
            btnHienMKMoi.BackgroundImage = (Image)resources.GetObject("btnHienMKMoi.BackgroundImage");
            btnHienMKMoi.BackgroundImageLayout = ImageLayout.Zoom;
            btnHienMKMoi.Location = new Point(240, 60);
            btnHienMKMoi.Name = "btnHienMKMoi";
            btnHienMKMoi.Size = new Size(54, 23);
            btnHienMKMoi.TabIndex = 11;
            btnHienMKMoi.UseVisualStyleBackColor = true;
            btnHienMKMoi.Click += btnHienMKMoi_Click;
            // 
            // btnHienXacNhanMK
            // 
            btnHienXacNhanMK.BackgroundImage = (Image)resources.GetObject("btnHienXacNhanMK.BackgroundImage");
            btnHienXacNhanMK.BackgroundImageLayout = ImageLayout.Zoom;
            btnHienXacNhanMK.Location = new Point(240, 99);
            btnHienXacNhanMK.Name = "btnHienXacNhanMK";
            btnHienXacNhanMK.Size = new Size(54, 23);
            btnHienXacNhanMK.TabIndex = 12;
            btnHienXacNhanMK.UseVisualStyleBackColor = true;
            btnHienXacNhanMK.Click += btnHienXacNhanMK_Click;
            // 
            // frmDoiMK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(306, 211);
            Controls.Add(btnHienXacNhanMK);
            Controls.Add(btnHienMKMoi);
            Controls.Add(btnHienMKCu);
            Controls.Add(btnThoat);
            Controls.Add(btnDoiMK);
            Controls.Add(txtXacNhanMK);
            Controls.Add(label3);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(label2);
            Controls.Add(txtMatKhauCu);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            Name = "frmDoiMK";
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtMatKhauCu;
        private Label label2;
        private TextBox txtMatKhauMoi;
        private Label label3;
        private TextBox txtXacNhanMK;
        private Button btnDoiMK;
        private Button btnThoat;
        private Button btnHienMKCu;
        private Button btnHienMKMoi;
        private Button btnHienXacNhanMK;
    }
}