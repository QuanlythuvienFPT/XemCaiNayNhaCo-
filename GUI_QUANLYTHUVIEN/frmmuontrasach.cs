using System;
using System.Windows.Forms;
using BLL_QUANLYTHUVIEN;
using DTO_QUANLYTHUVIEN;

namespace GUI_QUANLYTHUVIEN
{
    public partial class frmmuontrasach : Form
    {
        BUSmuontrasach bus = new BUSmuontrasach();

        public frmmuontrasach()
        {
            InitializeComponent();
            LoadData();
            LoadTrangThai();
            LoadMaMuonTraMoi();

            // Đăng ký sự kiện CellClick thay cho CellDoubleClick
            dgvMuonTraSach.CellClick += dgvMuonTraSach_CellClick;

            // Cho phép nhập mã mới lúc mới load form
            txtMaMuonTra.ReadOnly = false;
            //dgvMuonTraSach.CellDoubleClick += dgvMuonTraSach_CellDoubleClick;

        }

        private void LoadData()
        {
            dgvMuonTraSach.DataSource = bus.GetAll();
        }

        private void LoadTrangThai()
        {
            var trangThaiList = new[]
            {
                new { Ma = "TT001", Ten = "Chưa trả" },
                new { Ma = "TT002", Ten = "Đã trả" },
                new { Ma = "TT003", Ten = "Quá hạn" },
                new { Ma = "TT004", Ten = "Đang mượn" }
            };

            cboMaTrangThai.DisplayMember = "Ten";
            cboMaTrangThai.ValueMember = "Ma";
            cboMaTrangThai.DataSource = trangThaiList;
            cboMaTrangThai.SelectedIndex = -1;
        }

        // Hàm tạo mã mượn trả mới
        private void LoadMaMuonTraMoi()
        {
            txtMaMuonTra.Text = bus.TaoMaMuonTraMoi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var muon = new MuonTraSach
            {
                MaMuonTra = txtMaMuonTra.Text.Trim(),
                MaKhachHang = cboMaKhachHang.Text,
                MaNhanVien = cboMaNhanVien.Text,
                NgayMuon = DateOnly.FromDateTime(dtpNgayMuon.Value),
                NgayTra = DateOnly.FromDateTime(dtpNgayTra.Value),
                MaTrangThai = cboMaTrangThai.SelectedValue?.ToString() ?? "",
                NgayTao = dtpNgayTao.Value
            };

            string result = bus.Add(muon);
            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
                LoadMaMuonTraMoi(); // Tạo mã mới sau khi thêm thành công
                txtMaMuonTra.ReadOnly = false; // Cho phép nhập mã mới
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var muon = new MuonTraSach
            {
                MaMuonTra = txtMaMuonTra.Text.Trim(),
                MaKhachHang = cboMaKhachHang.Text,
                MaNhanVien = cboMaNhanVien.Text,
                NgayMuon = DateOnly.FromDateTime(dtpNgayMuon.Value),
                NgayTra = DateOnly.FromDateTime(dtpNgayTra.Value),
                MaTrangThai = cboMaTrangThai.SelectedValue?.ToString() ?? "",
                NgayTao = dtpNgayTao.Value
            };

            string result = bus.Update(muon);
            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaMuonTra.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui lòng chọn mã cần xóa.");
                return;
            }

            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                string result = bus.Delete(ma);
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    LoadMaMuonTraMoi(); // Tạo mã mới sau khi xóa
                    txtMaMuonTra.ReadOnly = false; // Cho phép nhập mã mới
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dgvMuonTraSach.DataSource = bus.Search(keyword);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadMaMuonTraMoi();
            txtMaMuonTra.ReadOnly = false; // Cho phép nhập mã mới khi làm mới

            cboMaKhachHang.SelectedIndex = -1;
            cboMaNhanVien.SelectedIndex = -1;
            cboMaTrangThai.SelectedIndex = -1;
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
            dtpNgayTao.Value = DateTime.Now;
            txtTimKiem.Clear();

            LoadData();
        }

        private void dgvMuonTraSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMuonTraSach.Rows[e.RowIndex];
                txtMaMuonTra.Text = row.Cells["MaMuonTra"].Value?.ToString() ?? "";
                cboMaKhachHang.Text = row.Cells["MaKhachHang"].Value?.ToString() ?? "";
                cboMaNhanVien.Text = row.Cells["MaNhanVien"].Value?.ToString() ?? "";

                var ngayMuonObj = row.Cells["NgayMuon"].Value;
                if (ngayMuonObj is DateOnly ngayMuonDateOnly)
                    dtpNgayMuon.Value = ngayMuonDateOnly.ToDateTime(TimeOnly.MinValue);
                else if (ngayMuonObj != null)
                    dtpNgayMuon.Value = Convert.ToDateTime(ngayMuonObj);

                var ngayTraObj = row.Cells["NgayTra"].Value;
                if (ngayTraObj is DateOnly ngayTraDateOnly)
                    dtpNgayTra.Value = ngayTraDateOnly.ToDateTime(TimeOnly.MinValue);
                else if (ngayTraObj != null)
                    dtpNgayTra.Value = Convert.ToDateTime(ngayTraObj);

                var maTrangThai = row.Cells["MaTrangThai"].Value?.ToString() ?? "";
                cboMaTrangThai.SelectedValue = maTrangThai;

                var ngayTaoObj = row.Cells["NgayTao"].Value;
                if (ngayTaoObj is DateTime ngayTaoDateTime)
                    dtpNgayTao.Value = ngayTaoDateTime;
                else if (ngayTaoObj != null)
                    dtpNgayTao.Value = Convert.ToDateTime(ngayTaoObj);

                // Khi chọn dòng dữ liệu, khóa không cho sửa mã mượn trả
                txtMaMuonTra.ReadOnly = true;
            }
        }

        private void dgvMuonTraSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string ma = dgvMuonTraSach.Rows[e.RowIndex].Cells["MaMuonTra"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(ma))
                {
                    // ✅ Truyền mã mượn trả vào constructor
                    frmChiTietMuonTraSach frmChiTiet = new frmChiTietMuonTraSach(ma);
                    frmChiTiet.ShowDialog();
                }
            }
        }
    }
}
