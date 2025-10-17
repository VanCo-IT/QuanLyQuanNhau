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
            label3 = new Label();
            pbLogo = new PictureBox();
            pictureBox3 = new PictureBox();
            pbEmail = new PictureBox();
            txtMatKhau = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
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
            pictureBox1.Size = new Size(617, 561);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnLogin
            // 
            pnLogin.BackColor = Color.Cyan;
            pnLogin.Controls.Add(label3);
            pnLogin.Controls.Add(pbLogo);
            pnLogin.Controls.Add(pictureBox3);
            pnLogin.Controls.Add(pbEmail);
            pnLogin.Controls.Add(txtMatKhau);
            pnLogin.Controls.Add(txtEmail);
            pnLogin.Controls.Add(label2);
            pnLogin.Controls.Add(label1);
            pnLogin.Dock = DockStyle.Fill;
            pnLogin.Location = new Point(617, 0);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(267, 561);
            pnLogin.TabIndex = 1;
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
            txtMatKhau.Size = new Size(178, 25);
            txtMatKhau.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(14, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 25);
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
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(pnLogin);
            Controls.Add(pictureBox1);
            Name = "frmLogin";
            Text = "frmLogin";
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
    }
}