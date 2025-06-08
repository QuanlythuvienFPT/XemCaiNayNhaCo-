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
    public partial class frmKhachHang : Form
    {
        private BusKhachHang busKH = new BusKhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhachHang();
        }
        private void LoadDanhSachKhachHang()
        {
            List<KhachHang> ds = busKH.GetAll();

            dgvDanhSachTG.DataSource = ds;

            dgvDanhSachTG.Columns["MaKhachHang"].HeaderText = "Mã KH";
            dgvDanhSachTG.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
            dgvDanhSachTG.Columns["Email"].HeaderText = "Email";
            dgvDanhSachTG.Columns["SoDienThoai"].HeaderText = "SĐT";
            dgvDanhSachTG.Columns["CCCD"].HeaderText = "CCCD";
            dgvDanhSachTG.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvDanhSachTG.Columns["NgayTao"].HeaderText = "Ngày tạo";
        }

        private void btnThemTG_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang kh = new KhachHang
                {
                    MaKhachHang = txtMaTG.Text.Trim(),
                    TenKhachHang = txtTenTG.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    SoDienThoai = txtSoDienThoai.Text.Trim(),
                    CCCD = txtcccd.Text.Trim(),
                    TrangThai = rbtDangHoatDong.Checked, // true nếu đang hoạt động, false nếu tạm ngưng
                    NgayTao = dtpNgayTao.Value
                };

                string result = busKH.AddKhachHang(kh);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachKhachHang();
                    btnMoiTG.PerformClick(); // reset form
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaTG_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng KhachHang với dữ liệu từ form
                KhachHang kh = new KhachHang
                {
                    MaKhachHang = txtMaTG.Text.Trim(),
                    TenKhachHang = txtTenTG.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    SoDienThoai = txtSoDienThoai.Text.Trim(),
                    CCCD = txtcccd.Text.Trim(),
                    TrangThai = rbtDangHoatDong.Checked,
                    NgayTao = dtpNgayTao.Value
                };

                // Gọi hàm update trong BUS
                string result = busKH.UpdateKhachHang(kh);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachKhachHang(); // load lại danh sách sau khi sửa
                    btnMoiTG.PerformClick(); // reset form
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaTG_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txtMaTG.Text.Trim();
                if (string.IsNullOrEmpty(maKH))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show($"Bạn có chắc muốn xóa khách hàng '{maKH}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    string result = busKH.DeleteKhachHang(maKH);
                    if (string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachKhachHang();  // Load lại danh sách
                        btnMoiTG.PerformClick();  // Reset form
                    }
                    else
                    {
                        MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMoiTG_Click(object sender, EventArgs e)
        {
            txtMaTG.Clear();
            txtTenTG.Clear();
            txtEmail.Clear();
            txtSoDienThoai.Clear();
            txtcccd.Clear();
            dtpNgayTao.Value = DateTime.Now;
            rbtDangHoatDong.Checked = true;
            rbtTamNgung.Checked = false;

            // Nếu có DataGridView hiển thị danh sách tác giả hoặc khách hàng, bạn có thể bỏ chọn hàng:
            dgvDanhSachTG.ClearSelection();
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimKiemKH.Text.Trim();
                BusKhachHang bus = new BusKhachHang();
                var list = bus.Search(keyword);

                dgvDanhSachTG.DataSource = list;

                // Nếu muốn custom lại tên cột hoặc ẩn cột không cần thiết thì làm tiếp ở đây
                dgvDanhSachTG.Columns["MaKhachHang"].HeaderText = "Mã KH";
                dgvDanhSachTG.Columns["TenKhachHang"].HeaderText = "Tên KH";
                dgvDanhSachTG.Columns["Email"].HeaderText = "Email";
                dgvDanhSachTG.Columns["SoDienThoai"].HeaderText = "SĐT";
                dgvDanhSachTG.Columns["CCCD"].HeaderText = "CCCD";
                dgvDanhSachTG.Columns["TrangThai"].HeaderText = "Trạng thái";
                dgvDanhSachTG.Columns["NgayTao"].HeaderText = "Ngày tạo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void dgvDanhSachTG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // tránh click vào header
            {
                DataGridViewRow row = dgvDanhSachTG.Rows[e.RowIndex];

                txtMaTG.Text = row.Cells["MaKhachHang"].Value?.ToString();
                txtTenTG.Text = row.Cells["TenKhachHang"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();  // Sửa ở đây
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
                txtcccd.Text = row.Cells["CCCD"].Value?.ToString();

                bool trangThai = false;
                if (bool.TryParse(row.Cells["TrangThai"].Value?.ToString(), out trangThai))
                {
                    rbtDangHoatDong.Checked = trangThai;
                    rbtTamNgung.Checked = !trangThai;
                }
                else
                {
                    rbtDangHoatDong.Checked = false;
                    rbtTamNgung.Checked = false;
                }

                DateTime ngayTao;
                if (DateTime.TryParse(row.Cells["NgayTao"].Value?.ToString(), out ngayTao))
                {
                    dtpNgayTao.Value = ngayTao;
                }
                else
                {
                    dtpNgayTao.Value = DateTime.Now;
                }
            }
        }
    }
}
