namespace GUI_QLQuanNhau
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thoátỨngDụngToolStripMenuItem = new ToolStripMenuItem();
            pnMain = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(192, 255, 255);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem, đăngXuấtTàiKhoảnToolStripMenuItem, thoátỨngDụngToolStripMenuItem });
            hệThốngToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            hệThốngToolStripMenuItem.Image = (Image)resources.GetObject("hệThốngToolStripMenuItem.Image");
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(102, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 128);
            đổiMậtKhẩuToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            đổiMậtKhẩuToolStripMenuItem.Image = (Image)resources.GetObject("đổiMậtKhẩuToolStripMenuItem.Image");
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(211, 24);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 128);
            thôngTinTàiKhoảnToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            thôngTinTàiKhoảnToolStripMenuItem.Image = (Image)resources.GetObject("thôngTinTàiKhoảnToolStripMenuItem.Image");
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(211, 24);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // đăngXuấtTàiKhoảnToolStripMenuItem
            // 
            đăngXuấtTàiKhoảnToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 128);
            đăngXuấtTàiKhoảnToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            đăngXuấtTàiKhoảnToolStripMenuItem.Image = (Image)resources.GetObject("đăngXuấtTàiKhoảnToolStripMenuItem.Image");
            đăngXuấtTàiKhoảnToolStripMenuItem.Name = "đăngXuấtTàiKhoảnToolStripMenuItem";
            đăngXuấtTàiKhoảnToolStripMenuItem.Size = new Size(211, 24);
            đăngXuấtTàiKhoảnToolStripMenuItem.Text = "Đăng xuất tài khoản";
            // 
            // thoátỨngDụngToolStripMenuItem
            // 
            thoátỨngDụngToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 128);
            thoátỨngDụngToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            thoátỨngDụngToolStripMenuItem.Image = (Image)resources.GetObject("thoátỨngDụngToolStripMenuItem.Image");
            thoátỨngDụngToolStripMenuItem.Name = "thoátỨngDụngToolStripMenuItem";
            thoátỨngDụngToolStripMenuItem.Size = new Size(211, 24);
            thoátỨngDụngToolStripMenuItem.Text = "Thoát ứng dụng";
            // 
            // pnMain
            // 
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 28);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(900, 600);
            pnMain.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 628);
            Controls.Add(pnMain);
            Controls.Add(menuStrip1);
            Name = "frmMain";
            Text = "Trang chủ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thoátỨngDụngToolStripMenuItem;
        private Panel pnMain;
    }
}