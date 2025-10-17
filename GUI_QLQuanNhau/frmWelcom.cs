namespace GUI_QLQuanNhau
{
    public partial class frmWelcom : Form
    {
        public frmWelcom()
        {
            InitializeComponent();
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;
            Task.Delay(3000).ContinueWith(t =>
            {
                if (this.IsHandleCreated && !this.IsDisposed)
                {
                    this.Invoke(new Action(() =>
                    {
                        frmLogin login = new frmLogin();
                        login.Show();
                        this.Hide();
                    }));
                }
            });
        }
    }
}
