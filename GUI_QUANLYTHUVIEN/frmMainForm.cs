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
    public partial class frmMainForm : Form
    {
        private Form activeForm = null;
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTacGia());
        }

        private void thểLoạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTheLoaiSach());
        }

        private void trạngTháiThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTrangThaiThanhToan());
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKhachHang());
        }

        private void mượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmmuontrasach());
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSach());
        }

        private void phíSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhiSach());
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form hiện tại (ví dụ frmKhachHang)

            frmLogin loginForm = new frmLogin();

            // Hiển thị form login dưới dạng modal (chờ login form đóng mới về lại form ẩn)
            loginForm.ShowDialog();

            // Sau khi form login đóng, nếu muốn, ta hiện lại form hiện tại hoặc thoát app
            this.Show();
        }
    }
}
