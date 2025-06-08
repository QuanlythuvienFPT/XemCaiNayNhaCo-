namespace GUI_QUANLYTHUVIEN
{
    partial class frmSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSach));
            txtTimKiem = new TextBox();
            dgvSach = new DataGridView();
            txtMaTheLoai = new TextBox();
            cbMaTacGia = new ComboBox();
            txtNhaXuatBan = new TextBox();
            dtpNgayTao = new DateTimePicker();
            label8 = new Label();
            cbTamNgung = new CheckBox();
            cbHoatDong = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            btnTimKiem = new Button();
            label3 = new Label();
            label1 = new Label();
            txtSoLuongTon = new TextBox();
            txtTieuDe = new TextBox();
            txtMaSach = new TextBox();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            lb = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(242, 17);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(204, 23);
            txtTimKiem.TabIndex = 21;
            // 
            // dgvSach
            // 
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(7, 44);
            dgvSach.Margin = new Padding(3, 2, 3, 2);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(493, 287);
            dgvSach.TabIndex = 0;
            dgvSach.CellDoubleClick += dgvSach_CellDoubleClick;
            // 
            // txtMaTheLoai
            // 
            txtMaTheLoai.Location = new Point(94, 111);
            txtMaTheLoai.Margin = new Padding(3, 2, 3, 2);
            txtMaTheLoai.Name = "txtMaTheLoai";
            txtMaTheLoai.Size = new Size(172, 23);
            txtMaTheLoai.TabIndex = 25;
            // 
            // cbMaTacGia
            // 
            cbMaTacGia.FormattingEnabled = true;
            cbMaTacGia.Location = new Point(94, 146);
            cbMaTacGia.Margin = new Padding(3, 2, 3, 2);
            cbMaTacGia.Name = "cbMaTacGia";
            cbMaTacGia.Size = new Size(172, 23);
            cbMaTacGia.TabIndex = 24;
            // 
            // txtNhaXuatBan
            // 
            txtNhaXuatBan.Location = new Point(94, 182);
            txtNhaXuatBan.Margin = new Padding(3, 2, 3, 2);
            txtNhaXuatBan.Name = "txtNhaXuatBan";
            txtNhaXuatBan.Size = new Size(172, 23);
            txtNhaXuatBan.TabIndex = 23;
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Location = new Point(94, 292);
            dtpNgayTao.Margin = new Padding(3, 2, 3, 2);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(172, 23);
            dtpNgayTao.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 291);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 19;
            label8.Text = "Ngày tạo";
            // 
            // cbTamNgung
            // 
            cbTamNgung.AutoSize = true;
            cbTamNgung.Location = new Point(182, 258);
            cbTamNgung.Margin = new Padding(3, 2, 3, 2);
            cbTamNgung.Name = "cbTamNgung";
            cbTamNgung.Size = new Size(89, 19);
            cbTamNgung.TabIndex = 18;
            cbTamNgung.Text = "Tạm ngưng";
            cbTamNgung.UseVisualStyleBackColor = true;
            // 
            // cbHoatDong
            // 
            cbHoatDong.AutoSize = true;
            cbHoatDong.Location = new Point(85, 258);
            cbHoatDong.Margin = new Padding(3, 2, 3, 2);
            cbHoatDong.Name = "cbHoatDong";
            cbHoatDong.Size = new Size(85, 19);
            cbHoatDong.TabIndex = 17;
            cbHoatDong.Text = "Hoạt động";
            cbHoatDong.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 259);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 16;
            label7.Text = "Trạng thái";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 221);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 15;
            label6.Text = "Số lượng tồn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 183);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 13;
            label5.Text = "NXB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 147);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 12;
            label4.Text = "Mã tác giả";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(dgvSach);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(305, 38);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(505, 345);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sách";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(450, 16);
            btnTimKiem.Margin = new Padding(3, 2, 3, 2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(48, 22);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 74);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 11;
            label3.Text = "Tiêu đề";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 9;
            label1.Text = "Mã sách";
            // 
            // txtSoLuongTon
            // 
            txtSoLuongTon.Location = new Point(94, 220);
            txtSoLuongTon.Margin = new Padding(3, 2, 3, 2);
            txtSoLuongTon.Name = "txtSoLuongTon";
            txtSoLuongTon.Size = new Size(172, 23);
            txtSoLuongTon.TabIndex = 7;
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(94, 73);
            txtTieuDe.Margin = new Padding(3, 2, 3, 2);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(172, 23);
            txtTieuDe.TabIndex = 6;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(94, 35);
            txtMaSach.Margin = new Padding(3, 2, 3, 2);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(172, 23);
            txtMaSach.TabIndex = 4;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(205, 328);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(77, 22);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(76, 328);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(54, 22);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(144, 328);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(54, 22);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(6, 328);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(54, 22);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtMaTheLoai);
            groupBox1.Controls.Add(cbMaTacGia);
            groupBox1.Controls.Add(txtNhaXuatBan);
            groupBox1.Controls.Add(dtpNgayTao);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cbTamNgung);
            groupBox1.Controls.Add(cbHoatDong);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSoLuongTon);
            groupBox1.Controls.Add(txtTieuDe);
            groupBox1.Controls.Add(txtMaSach);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(12, 29);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(287, 354);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 110);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 10;
            label2.Text = "Mã thể loại";
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb.ForeColor = Color.Crimson;
            lb.Location = new Point(334, -1);
            lb.Name = "lb";
            lb.Size = new Size(76, 37);
            lb.TabIndex = 4;
            lb.Text = "Sách";
            // 
            // frmSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 413);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lb);
            Name = "frmSach";
            Text = "frmSach";
            Load += frmSach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTimKiem;
        private DataGridView dgvSach;
        private TextBox txtMaTheLoai;
        private ComboBox cbMaTacGia;
        private TextBox txtNhaXuatBan;
        private DateTimePicker dtpNgayTao;
        private Label label8;
        private CheckBox cbTamNgung;
        private CheckBox cbHoatDong;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private Label label3;
        private Label label1;
        private TextBox txtSoLuongTon;
        private TextBox txtTieuDe;
        private TextBox txtMaSach;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox1;
        private Label label2;
        private Label lb;
    }
}