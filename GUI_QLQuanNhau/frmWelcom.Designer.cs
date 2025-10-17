namespace GUI_QLQuanNhau
{
    partial class frmWelcom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcom));
            progressBar = new ProgressBar();
            pnWelcom = new Panel();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Bottom;
            progressBar.Location = new Point(0, 538);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(884, 23);
            progressBar.TabIndex = 0;
            // 
            // pnWelcom
            // 
            pnWelcom.BackgroundImage = (Image)resources.GetObject("pnWelcom.BackgroundImage");
            pnWelcom.BackgroundImageLayout = ImageLayout.Stretch;
            pnWelcom.Dock = DockStyle.Fill;
            pnWelcom.Location = new Point(0, 0);
            pnWelcom.Name = "pnWelcom";
            pnWelcom.Size = new Size(884, 538);
            pnWelcom.TabIndex = 1;
            // 
            // frmWelcom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(pnWelcom);
            Controls.Add(progressBar);
            Name = "frmWelcom";
            Text = "Form1sddd";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar;
        private Panel pnWelcom;
    }
}
