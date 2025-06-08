using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_QUANLYTHUVIEN;
using DTO_QUANLYTHUVIEN;

namespace GUI_QUANLYTHUVIEN
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(this, "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BusNhanVien bus = new BusNhanVien();
            NhanVien nhanVien = bus.DangNhap(username, password);

            if (nhanVien == null)
            {
                MessageBox.Show(this, "Tài khoản hoặc mật khẩu không đúng.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nhanVien.TrangThai == false)
            {
                MessageBox.Show(this, "Tài khoản đang bị khóa.", "Truy cập bị từ chối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(this, "Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                using (frmMainForm mainForm = new frmMainForm())
                {
                    mainForm.ShowDialog();
                }
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn thoát không?",
                    "Xác nhận thoát",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void TglHienMatKhau_CheckedChanged_1(object sender, EventArgs e)
        {
            if (TglHienMatKhau.Checked)
                txtMatKhau.PasswordChar = '\0'; // Hiện mật khẩu
            else
                txtMatKhau.PasswordChar = '*'; // Ẩn mật khẩu
        }
    }
}
