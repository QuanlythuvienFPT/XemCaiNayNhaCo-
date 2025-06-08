using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QUANLYTHUVIEN
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
            // Cấu hình progress bar
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;

            // Đóng form sau 3 giây
            Task.Delay(3000).ContinueWith(t =>
            {
                if (!this.IsDisposed)
                {
                    this.Invoke(new Action(() => this.Close()));
                }
            });
        }
    }
}
