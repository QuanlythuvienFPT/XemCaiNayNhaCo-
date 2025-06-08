using BLL_QUANLYTHUVIEN;
using DAL_QUANLYTHUVIEN;
using DTO_QUANLYTHUVIEN;

namespace GUI_QUANLYTHUVIEN
{
    public partial class frmNhanVien : Form
    {
        public BusNhanVien busNhanVien = new BusNhanVien();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
            btnSuaNV.Enabled = false;
        }

        private void LoadDanhSachNhanVien()
        {
            dgvDanhSachNV.DataSource = busNhanVien.GetNhanVienList();
            dgvDanhSachNV.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvDanhSachNV.Columns["Ten"].HeaderText = "Họ Tên";
            dgvDanhSachNV.Columns["Email"].HeaderText = "Email";
            dgvDanhSachNV.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            dgvDanhSachNV.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dgvDanhSachNV.Columns["VaiTro"].Visible = false;
            dgvDanhSachNV.Columns["TrangThai"].Visible = false;
            dgvDanhSachNV.Columns["NgayTao"].HeaderText = "Ngày Tạo";

            dgvDanhSachNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvDanhSachNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachNV.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtTen.Text = row.Cells["Ten"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                rbtNhanVien.Checked = !(bool)row.Cells["VaiTro"].Value;
                rbtDangHoatDong.Checked = (bool)row.Cells["TrangThai"].Value;

                btnSuaNV.Enabled = true;
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string Ten = txtTen.Text;
            string email = txtEmail.Text;
            string matKhau = txtMatKhau.Text;
            string soDienThoai = txtSDT.Text;

            bool vaiTro = rbtNhanVien.Checked ? false : true;
            bool trangThai = rbtDangHoatDong.Checked ? true : false;

            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(Ten) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(soDienThoai))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }

            NhanVien nv = new NhanVien
            {
                MaNhanVien = maNV,
                Ten = Ten,
                Email = email,
                MatKhau = matKhau,
                SoDienThoai = soDienThoai,
                VaiTro = vaiTro,
                TrangThai = trangThai,
                NgayTao = dtpNgayTao.Value
            };

            string result = busNhanVien.AddNhanVien(nv);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Thêm nhân viên thành công.");
                ClearForm();
                LoadDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string Ten = txtTen.Text;
            string email = txtEmail.Text;
            string matKhau = txtMatKhau.Text;
            string sdt = txtSDT.Text;
            bool vaiTro = rbtNhanVien.Checked ? false : true;
            bool trangThai = rbtDangHoatDong.Checked ? true : false;

            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(Ten) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }

            DateTime ngayTao = dtpNgayTao.Value;
            if (ngayTao.Year < 1753)
            {
                ngayTao = DateTime.Now;
            }

            NhanVien nv = new NhanVien
            {
                MaNhanVien = maNV,
                Ten = Ten,
                Email = email,
                MatKhau = matKhau,
                SoDienThoai = sdt,
                VaiTro = vaiTro,
                TrangThai = trangThai,
                NgayTao = ngayTao
            };

            string result = busNhanVien.UpdateNhanVien(nv);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật nhân viên thành công.");
                ClearForm();
                LoadDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;

            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string deleteResult = busNhanVien.DeleteNhanVien(maNV);

                if (string.IsNullOrEmpty(deleteResult))
                {
                    MessageBox.Show("Xóa nhân viên thành công.");
                    ClearForm();
                    LoadDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show(deleteResult);
                }
            }
        }

        private void btnMoiNV_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachNhanVien();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiemNV.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadDanhSachNhanVien();
                return;
            }

            var ketQua = busNhanVien.SearchNhanVien(keyword);

            dgvDanhSachNV.DataSource = null;
            dgvDanhSachNV.DataSource = ketQua;

            dgvDanhSachNV.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvDanhSachNV.Columns["Ten"].HeaderText = "Họ Tên";
            dgvDanhSachNV.Columns["Email"].HeaderText = "Email";
            dgvDanhSachNV.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            dgvDanhSachNV.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dgvDanhSachNV.Columns["VaiTro"].Visible = false;
            dgvDanhSachNV.Columns["TrangThai"].Visible = false;
            dgvDanhSachNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearForm()
        {
            btnThemNV.Enabled = true;
            btnSuaNV.Enabled = false;
            btnXoaNV.Enabled = true;
            txtMaNV.Clear();
            txtTen.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtSDT.Clear();
            dtpNgayTao.Value = DateTime.Now;
            rbtNhanVien.Checked = true;
            rbtDangHoatDong.Checked = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
