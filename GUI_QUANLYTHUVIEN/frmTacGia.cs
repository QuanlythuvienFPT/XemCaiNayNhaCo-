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
using DAL_QUANLYTHUVIEN;
using DTO_QUANLYTHUVIEN;

namespace GUI_QUANLYTHUVIEN
{
    public partial class frmTacGia : Form
    {
        private BusTacGia busTacGia = new BusTacGia();

        public bool? TrangThai { get; private set; }

        public frmTacGia()
        {
            InitializeComponent();
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            LoadDanhSachTacGia();
            btnSuaTG.Enabled = false;
        }
        private void LoadDanhSachTacGia()
        {
            dgvDanhSachTG.DataSource = busTacGia.GetAllTacGia();
            dgvDanhSachTG.Columns["MaTacGia"].HeaderText = "Mã Tác Giả";
            dgvDanhSachTG.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
            dgvDanhSachTG.Columns["QuocTich"].HeaderText = "Quốc Tịch";
            dgvDanhSachTG.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvDanhSachTG.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            dgvDanhSachTG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvDanhSachTG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachTG.Rows[e.RowIndex];
                txtMaTG.Text = row.Cells["MaTacGia"].Value.ToString();
                txtTenTG.Text = row.Cells["TenTacGia"].Value.ToString();
                txtQuocTich.Text = row.Cells["QuocTich"].Value?.ToString();

                bool? trangThai = row.Cells["TrangThai"].Value != DBNull.Value ? (bool?)Convert.ToBoolean(row.Cells["TrangThai"].Value) : null;
                if (trangThai.HasValue)
                {
                    rbtDangHoatDong.Checked = trangThai.Value;
                    rbtTamNgung.Checked = !trangThai.Value;
                }
                else
                {
                    rbtDangHoatDong.Checked = false;
                    rbtTamNgung.Checked = false;
                }

                dtpNgayTaoTG.Value = Convert.ToDateTime(row.Cells["NgayTao"].Value);

                btnSuaTG.Enabled = true;
                btnThemTG.Enabled = false;
            }
        }

        private void btnThemTG_Click(object sender, EventArgs e)
        {
            string maTG = txtMaTG.Text.Trim();
            string tenTG = txtTenTG.Text.Trim();

            if (string.IsNullOrEmpty(maTG) || string.IsNullOrEmpty(tenTG))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            TacGia tg = new TacGia
            {
                MaTacGia = maTG,
                TenTacGia = tenTG,
                QuocTich = txtQuocTich.Text.Trim(),
                TrangThai = rbtDangHoatDong.Checked ? true : (rbtTamNgung.Checked ? false : (bool?)null),
                NgayTao = dtpNgayTaoTG.Value
            };

            string result = busTacGia.AddTacGia(tg);
            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Thêm tác giả thành công.");
                ClearForm();
                LoadDanhSachTacGia();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnSuaTG_Click(object sender, EventArgs e)
        {
            string maTG = txtMaTG.Text.Trim();
            string tenTG = txtTenTG.Text.Trim();

            if (string.IsNullOrEmpty(maTG) || string.IsNullOrEmpty(tenTG))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            TacGia tg = new TacGia
            {
                MaTacGia = maTG,
                TenTacGia = tenTG,
                QuocTich = txtQuocTich.Text.Trim(),
                TrangThai = rbtDangHoatDong.Checked ? true : (rbtTamNgung.Checked ? false : (bool?)null),
                NgayTao = dtpNgayTaoTG.Value
            };

            string result = busTacGia.UpdateTacGia(tg);
            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật tác giả thành công.");
                ClearForm();
                LoadDanhSachTacGia();
            }
            else
            {
                MessageBox.Show(result);
            }
        }
        private void ClearForm()
        {
            txtMaTG.Clear();
            txtTenTG.Clear();
            txtQuocTich.Clear();
            TrangThai = rbtDangHoatDong.Checked ? true : (rbtTamNgung.Checked ? false : (bool?)null);
            dtpNgayTaoTG.Value = DateTime.Now;
            txtTimKiemTG.Clear();
            btnThemTG.Enabled = true;
            btnSuaTG.Enabled = false;
            rbtDangHoatDong.Checked = false;
            rbtTamNgung.Checked = false;
        }

        private void btnTimKiemTG_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTG.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadDanhSachTacGia();
                return;
            }

            var result = busTacGia.SearchTacGia(keyword);

            dgvDanhSachTG.DataSource = null;
            dgvDanhSachTG.DataSource = result;
            dgvDanhSachTG.Columns["MaTacGia"].HeaderText = "Mã Tác Giả";
            dgvDanhSachTG.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
            dgvDanhSachTG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnMoiTG_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachTacGia();
        }

        private void btnXoaTG_Click(object sender, EventArgs e)
        {
            string maTG = txtMaTG.Text.Trim();

            if (string.IsNullOrEmpty(maTG))
            {
                MessageBox.Show("Vui lòng chọn tác giả để xóa.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string result = busTacGia.DeleteTacGia(maTG);
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Xóa tác giả thành công.");
                    ClearForm();
                    LoadDanhSachTacGia();
                }
                else
                {
                    MessageBox.Show($"Xóa thất bại: {result}");
                }
            }
        }
    }
}
