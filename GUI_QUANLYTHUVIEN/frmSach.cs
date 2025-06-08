using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_QuanLyThuVien;
using DAL_QUANLYTHUVIEN;
using DTO_QUANLYTHUVIEN;
using Microsoft.Data.SqlClient;

namespace GUI_QUANLYTHUVIEN
{
    public partial class frmSach : Form
    {
        private readonly BUSSach sachBUS = new BUSSach();
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
            ResetForm();
            LoadTacGia();
        }
        private void LoadTacGia()
        {
            try
            {
                string sql = "SELECT MaTacGia, TenTacGia FROM TACGIA";
                using (SqlDataReader reader = DBUtil.Query(sql, new List<object>()))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cbMaTacGia.DataSource = dt;
                    cbMaTacGia.DisplayMember = "TenTacGia";
                    cbMaTacGia.ValueMember = "MaTacGia";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải tác giả: " + ex.Message);
            }
        }
        private void LoadDanhSach()
        {
            dgvSach.DataSource = sachBUS.LayTatCaSach();
        }
        private void ResetForm()
        {
            txtMaSach.Clear();
            txtTieuDe.Clear();
            txtMaTheLoai.Clear();
            cbMaTacGia.SelectedIndex = -1;
            txtNhaXuatBan.Clear();
            txtSoLuongTon.Clear();
            cbHoatDong.Checked = false;
            cbTamNgung.Checked = false;
            dtpNgayTao.Value = DateTime.Now;

            txtMaSach.Enabled = true;
        }
        private Sach LayThongTinTuForm()
        {
            return new Sach
            {
                MaSach = txtMaSach.Text.Trim(),
                TieuDe = txtTieuDe.Text.Trim(),
                MaTheLoai = txtMaTheLoai.Text.Trim(),
                MaTacGia = cbMaTacGia.SelectedValue?.ToString() ?? "",
                NhaXuatBan = txtNhaXuatBan.Text.Trim(),
                SoLuongTon = int.TryParse(txtSoLuongTon.Text, out int soLuong) ? soLuong : 0,
                TrangThai = cbHoatDong.Checked ? true : cbTamNgung.Checked ? false : (bool?)null,
                NgayTao = dtpNgayTao.Value
            };
        }
        private void dgvSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtTieuDe.Text = row.Cells["TieuDe"].Value.ToString();
                txtMaTheLoai.Text = row.Cells["MaTheLoai"].Value.ToString();
                cbMaTacGia.SelectedValue = row.Cells["MaTacGia"].Value.ToString();
                txtNhaXuatBan.Text = row.Cells["NhaXuatBan"].Value.ToString();
                txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value?.ToString();
                bool? trangThai = row.Cells["TrangThai"].Value as bool?;
                cbHoatDong.Checked = trangThai == true;
                cbTamNgung.Checked = trangThai == false;
                if (DateTime.TryParse(row.Cells["NgayTao"].Value?.ToString(), out DateTime ngay))
                {
                    dtpNgayTao.Value = ngay;
                }

                txtMaSach.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Sach s = new Sach
            {
                MaSach = txtMaSach.Text,
                TieuDe = txtTieuDe.Text,
                MaTheLoai = txtMaTheLoai.Text.Trim(),
                MaTacGia = cbMaTacGia.SelectedValue?.ToString(),
                NhaXuatBan = txtNhaXuatBan.Text,
                SoLuongTon = int.TryParse(txtSoLuongTon.Text, out int sl) ? sl : 0,
                TrangThai = cbHoatDong.Checked, // true nếu check
                NgayTao = dtpNgayTao.Value
            };

            try
            {
                sachBUS.ThemSach(s); // Gọi BUS
                MessageBox.Show("Thêm sách thành công!");
                LoadDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var sach = LayThongTinTuForm();
                sachBUS.CapNhatSach(sach);
                LoadDanhSach();
                ResetForm();
                MessageBox.Show("Cập nhật sách thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSach = txtMaSach.Text.Trim();
                if (string.IsNullOrEmpty(maSach)) return;

                sachBUS.XoaSach(maSach);
                LoadDanhSach();
                ResetForm();
                MessageBox.Show("Xóa sách thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadDanhSach();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                dgvSach.DataSource = sachBUS.TimKiemSach(tuKhoa);
            }
            else
            {
                LoadDanhSach(); // Nếu rỗng thì hiển thị toàn bộ
            }
        }
    }
}
