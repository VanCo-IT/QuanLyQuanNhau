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
            pnThietKe = new Panel();
            panel1 = new Panel();
            dgvStaff = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            SuspendLayout();
            // 
            // pnThietKe
            // 
            pnThietKe.BackColor = Color.FromArgb(128, 255, 255);
            pnThietKe.Dock = DockStyle.Top;
            pnThietKe.Location = new Point(0, 0);
            pnThietKe.Name = "pnThietKe";
            pnThietKe.Size = new Size(800, 100);
            pnThietKe.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(dgvStaff);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 350);
            panel1.TabIndex = 1;
            // 
            // dgvStaff
            // 
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Dock = DockStyle.Left;
            dgvStaff.Location = new Point(0, 0);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.Size = new Size(547, 350);
            dgvStaff.TabIndex = 0;
            // 
            // frmStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pnThietKe);
            Name = "frmStaff";
            Text = "frmStaff";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnThietKe;
        private Panel panel1;
        private DataGridView dgvStaff;
    }
}