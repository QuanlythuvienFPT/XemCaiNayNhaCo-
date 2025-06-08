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
    public partial class frmPhiSach : Form
    {
        BusPhiSach busPhiSach = new BusPhiSach();
        public frmPhiSach()
        {
            InitializeComponent();
        }

        private void frmPhiSach_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxMaSach();
            ResetForm();
        }
        private void LoadData()
        {
            dgvPhiSach.DataSource = busPhiSach.GetAll();
        }
        private void LoadComboBoxMaSach()
        {
            cbMaSach.Items.Clear();
            // TODO: nên lấy dữ liệu MaSach thật từ DB (từ DAL/BUS bảng Sách)
            cbMaSach.Items.AddRange(new string[] { "S001", "S002", "S003", "S004", "S005" });
        }
        private void ResetForm()
        {
            txtMaPhiSach.Clear();
            cbMaSach.SelectedIndex = -1;
            txtPhiMuon.Clear();
            txtPhiPhat.Clear();
            ckDaThanhToan.Checked = false;
            ckChuaThanhToan.Checked = false;
            dtpNgayTao.Value = DateTime.Now;
            txtTimKiem.Clear();
        }
        private bool GetTrangThai()
        {
            if (ckDaThanhToan.Checked) return true;
            if (ckChuaThanhToan.Checked) return false;
            return false; // mặc định false nếu không chọn
        }

        private void dgvPhiSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPhiSach.Rows[e.RowIndex];

                txtMaPhiSach.Text = row.Cells["MaPhiSach"].Value?.ToString() ?? "";
                cbMaSach.Text = row.Cells["MaSach"].Value?.ToString() ?? "";
                txtPhiMuon.Text = row.Cells["PhiMuon"].Value?.ToString() ?? "0";
                txtPhiPhat.Text = row.Cells["PhiPhat"].Value?.ToString() ?? "";

                if (DateTime.TryParse(row.Cells["NgayTao"].Value?.ToString(), out DateTime ngayTao))
                {
                    dtpNgayTao.Value = ngayTao;
                }
                else
                {
                    dtpNgayTao.Value = DateTime.Now;
                }

                if (bool.TryParse(row.Cells["TrangThai"].Value?.ToString(), out bool trangThai))
                {
                    ckDaThanhToan.Checked = trangThai;
                    ckChuaThanhToan.Checked = !trangThai;
                }
                else
                {
                    ckDaThanhToan.Checked = false;
                    ckChuaThanhToan.Checked = false;
                }
            }
        }
        private void ckDaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDaThanhToan.Checked) ckChuaThanhToan.Checked = false;
        }
        private void ckChuaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            if (ckChuaThanhToan.Checked) ckDaThanhToan.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra phí mượn hợp lệ
            if (!decimal.TryParse(txtPhiMuon.Text, out decimal phiMuon))
            {
                MessageBox.Show("Phí mượn không hợp lệ!");
                return;
            }

            // Kiểm tra phí phạt nếu có
            decimal? phiPhat = null;
            if (!string.IsNullOrWhiteSpace(txtPhiPhat.Text))
            {
                if (decimal.TryParse(txtPhiPhat.Text, out decimal tempPhiPhat))
                    phiPhat = tempPhiPhat;
                else
                {
                    MessageBox.Show("Phí phạt không hợp lệ!");
                    return;
                }
            }

            // Tạo đối tượng PhiSach
            var ps = new PhiSach
            {
                MaPhiSach = txtMaPhiSach.Text.Trim(),
                MaSach = cbMaSach.Text.Trim(),
                PhiMuon = phiMuon,
                PhiPhat = phiPhat,
                TrangThai = GetTrangThai(),
                NgayTao = dtpNgayTao.Value
            };

            // Gọi phương thức Add và nhận kết quả trả về dạng string
            string result = busPhiSach.Add(ps);

            // Kiểm tra kết quả trả về
            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Lỗi: " + result);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPhiMuon.Text, out decimal phiMuon))
            {
                MessageBox.Show("Phí mượn không hợp lệ!");
                return;
            }

            decimal? phiPhat = null;
            if (!string.IsNullOrWhiteSpace(txtPhiPhat.Text))
            {
                if (decimal.TryParse(txtPhiPhat.Text, out decimal tempPhiPhat))
                    phiPhat = tempPhiPhat;
                else
                {
                    MessageBox.Show("Phí phạt không hợp lệ!");
                    return;
                }
            }

            var ps = new PhiSach
            {
                MaPhiSach = txtMaPhiSach.Text.Trim(),
                MaSach = cbMaSach.Text.Trim(),
                PhiMuon = phiMuon,
                PhiPhat = phiPhat,
                TrangThai = GetTrangThai(),
                NgayTao = dtpNgayTao.Value
            };

            string result = busPhiSach.Update(ps);
            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại! Lỗi: " + result);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaPhiSach.Text.Trim();

            string result = busPhiSach.Delete(ma);
            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Xóa thành công!");
                LoadData();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Xóa thất bại! Lỗi: " + result);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadData(); // Tải lại toàn bộ dữ liệu sau khi làm mới form
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            var list = busPhiSach.Search(keyword);
            dgvPhiSach.DataSource = list;
        }
    }
}
