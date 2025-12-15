namespace GUI_QLQuanNhau
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            pnLogin = new Panel();
            btnThoat = new Button();
            btnDangNhap = new Button();
            cbQuenMK = new CheckBox();
            cbHienMK = new CheckBox();
            label3 = new Label();
            pbLogo = new PictureBox();
            pictureBox3 = new PictureBox();
            pbEmail = new PictureBox();
            txtMatKhau = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(612, 561);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnLogin
            // 
            pnLogin.BackColor = Color.Cyan;
            pnLogin.Controls.Add(label4);
            pnLogin.Controls.Add(btnThoat);
            pnLogin.Controls.Add(btnDangNhap);
            pnLogin.Controls.Add(cbQuenMK);
            pnLogin.Controls.Add(cbHienMK);
            pnLogin.Controls.Add(label3);
            pnLogin.Controls.Add(pbLogo);
            pnLogin.Controls.Add(pictureBox3);
            pnLogin.Controls.Add(pbEmail);
            pnLogin.Controls.Add(txtMatKhau);
            pnLogin.Controls.Add(txtEmail);
            pnLogin.Controls.Add(label2);
            pnLogin.Controls.Add(label1);
            pnLogin.Dock = DockStyle.Fill;
            pnLogin.Location = new Point(612, 0);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(272, 561);
            pnLogin.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 128, 0);
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.Location = new Point(154, 400);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(78, 59);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(255, 128, 0);
            btnDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangNhap.Location = new Point(22, 400);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(84, 59);
            btnDangNhap.TabIndex = 10;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // cbQuenMK
            // 
            cbQuenMK.AutoSize = true;
            cbQuenMK.Font = new Font("Segoe UI", 10F);
            cbQuenMK.Location = new Point(145, 320);
            cbQuenMK.Name = "cbQuenMK";
            cbQuenMK.Size = new Size(87, 23);
            cbQuenMK.TabIndex = 9;
            cbQuenMK.Text = "Quên MK";
            cbQuenMK.UseVisualStyleBackColor = true;
            // 
            // cbHienMK
            // 
            cbHienMK.AutoSize = true;
            cbHienMK.Font = new Font("Segoe UI", 10F);
            cbHienMK.Location = new Point(15, 320);
            cbHienMK.Name = "cbHienMK";
            cbHienMK.Size = new Size(81, 23);
            cbHienMK.TabIndex = 8;
            cbHienMK.Text = "Hiện MK";
            cbHienMK.UseVisualStyleBackColor = true;
            cbHienMK.CheckedChanged += cbHienMK_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 128, 0);
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(15, 18);
            label3.Name = "label3";
            label3.Size = new Size(126, 19);
            label3.TabIndex = 7;
            label3.Text = "Quán nhậu Văn Có";
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(164, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 50);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 6;
            pbLogo.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 239);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pbEmail
            // 
            pbEmail.Image = (Image)resources.GetObject("pbEmail.Image");
            pbEmail.Location = new Point(19, 134);
            pbEmail.Name = "pbEmail";
            pbEmail.Size = new Size(52, 39);
            pbEmail.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEmail.TabIndex = 4;
            pbEmail.TabStop = false;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 10F);
            txtMatKhau.Location = new Point(14, 272);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(250, 25);
            txtMatKhau.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(14, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 25);
            txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(77, 250);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(77, 154);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 61);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 12;
            label4.Text = "SDT: 0344951699";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(pnLogin);
            Controls.Add(pictureBox1);
            Name = "frmLogin";
            Text = "frmLogin";
            FormClosing += frmLogin_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnLogin.ResumeLayout(false);
            pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel pnLogin;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pbEmail;
        private TextBox txtMatKhau;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private PictureBox pbLogo;
        private CheckBox cbHienMK;
        private Button btnDangNhap;
        private CheckBox cbQuenMK;
        private Button btnThoat;
        private Label label4;
    }
}