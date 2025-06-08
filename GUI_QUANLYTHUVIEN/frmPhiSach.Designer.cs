namespace GUI_QUANLYTHUVIEN
{
    partial class frmPhiSach
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
            btnTimKiem = new Button();
            dgvPhiSach = new DataGridView();
            groupBox2 = new GroupBox();
            txtTimKiem = new TextBox();
            dtpNgayTao = new DateTimePicker();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            ckChuaThanhToan = new CheckBox();
            ckDaThanhToan = new CheckBox();
            txtPhiMuon = new TextBox();
            txtPhiPhat = new TextBox();
            cbMaSach = new ComboBox();
            txtMaPhiSach = new TextBox();
            MaPhiSach = new Label();
            label6 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            lb = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPhiSach).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(463, 16);
            btnTimKiem.Margin = new Padding(3, 2, 3, 2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(71, 22);
            btnTimKiem.TabIndex = 15;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvPhiSach
            // 
            dgvPhiSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhiSach.Location = new Point(6, 45);
            dgvPhiSach.Margin = new Padding(3, 2, 3, 2);
            dgvPhiSach.Name = "dgvPhiSach";
            dgvPhiSach.RowHeadersWidth = 51;
            dgvPhiSach.Size = new Size(528, 310);
            dgvPhiSach.TabIndex = 0;
            dgvPhiSach.CellDoubleClick += dgvPhiSach_CellDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(dgvPhiSach);
            groupBox2.Location = new Point(288, 70);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(539, 369);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phí sách";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(262, 18);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(196, 23);
            txtTimKiem.TabIndex = 14;
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Location = new Point(101, 220);
            dtpNgayTao.Margin = new Padding(3, 2, 3, 2);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(167, 23);
            dtpNgayTao.TabIndex = 20;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(170, 302);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(82, 26);
            btnLamMoi.TabIndex = 19;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(170, 255);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 26);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(30, 302);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 26);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(30, 255);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 26);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // ckChuaThanhToan
            // 
            ckChuaThanhToan.AutoSize = true;
            ckChuaThanhToan.Location = new Point(189, 184);
            ckChuaThanhToan.Margin = new Padding(3, 2, 3, 2);
            ckChuaThanhToan.Name = "ckChuaThanhToan";
            ckChuaThanhToan.Size = new Size(71, 19);
            ckChuaThanhToan.TabIndex = 15;
            ckChuaThanhToan.Text = "Chưa TT";
            ckChuaThanhToan.UseVisualStyleBackColor = true;
            ckChuaThanhToan.Click += ckChuaThanhToan_CheckedChanged;
            // 
            // ckDaThanhToan
            // 
            ckDaThanhToan.AutoSize = true;
            ckDaThanhToan.Location = new Point(101, 184);
            ckDaThanhToan.Margin = new Padding(3, 2, 3, 2);
            ckDaThanhToan.Name = "ckDaThanhToan";
            ckDaThanhToan.Size = new Size(58, 19);
            ckDaThanhToan.TabIndex = 14;
            ckDaThanhToan.Text = "Đã TT";
            ckDaThanhToan.UseVisualStyleBackColor = true;
            ckDaThanhToan.Click += ckDaThanhToan_CheckedChanged;
            // 
            // txtPhiMuon
            // 
            txtPhiMuon.Location = new Point(101, 108);
            txtPhiMuon.Margin = new Padding(3, 2, 3, 2);
            txtPhiMuon.Name = "txtPhiMuon";
            txtPhiMuon.Size = new Size(167, 23);
            txtPhiMuon.TabIndex = 11;
            // 
            // txtPhiPhat
            // 
            txtPhiPhat.Location = new Point(101, 147);
            txtPhiPhat.Margin = new Padding(3, 2, 3, 2);
            txtPhiPhat.Name = "txtPhiPhat";
            txtPhiPhat.Size = new Size(167, 23);
            txtPhiPhat.TabIndex = 10;
            // 
            // cbMaSach
            // 
            cbMaSach.FormattingEnabled = true;
            cbMaSach.Location = new Point(101, 71);
            cbMaSach.Margin = new Padding(3, 2, 3, 2);
            cbMaSach.Name = "cbMaSach";
            cbMaSach.Size = new Size(167, 23);
            cbMaSach.TabIndex = 9;
            // 
            // txtMaPhiSach
            // 
            txtMaPhiSach.Location = new Point(101, 31);
            txtMaPhiSach.Margin = new Padding(3, 2, 3, 2);
            txtMaPhiSach.Name = "txtMaPhiSach";
            txtMaPhiSach.Size = new Size(167, 23);
            txtMaPhiSach.TabIndex = 8;
            // 
            // MaPhiSach
            // 
            MaPhiSach.AutoSize = true;
            MaPhiSach.Location = new Point(5, 32);
            MaPhiSach.Name = "MaPhiSach";
            MaPhiSach.Size = new Size(71, 15);
            MaPhiSach.TabIndex = 2;
            MaPhiSach.Text = "Mã phí sách";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 223);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 7;
            label6.Text = "Ngày tạo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 70);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Mã sách";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 184);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 6;
            label5.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 107);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "Phí mượn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 146);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 5;
            label4.Text = "Phí phạt";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgayTao);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(ckChuaThanhToan);
            groupBox1.Controls.Add(ckDaThanhToan);
            groupBox1.Controls.Add(txtPhiMuon);
            groupBox1.Controls.Add(txtPhiPhat);
            groupBox1.Controls.Add(cbMaSach);
            groupBox1.Controls.Add(txtMaPhiSach);
            groupBox1.Controls.Add(MaPhiSach);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(3, 68);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(283, 357);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phí sách";
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb.ForeColor = Color.Crimson;
            lb.Location = new Point(328, 9);
            lb.Name = "lb";
            lb.Size = new Size(121, 37);
            lb.TabIndex = 10;
            lb.Text = "Phí sách";
            // 
            // frmPhiSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lb);
            Name = "frmPhiSach";
            Text = "frmPhiSach";
            Load += frmPhiSach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhiSach).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTimKiem;
        private DataGridView dgvPhiSach;
        private GroupBox groupBox2;
        private TextBox txtTimKiem;
        private DateTimePicker dtpNgayTao;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private CheckBox ckChuaThanhToan;
        private CheckBox ckDaThanhToan;
        private TextBox txtPhiMuon;
        private TextBox txtPhiPhat;
        private ComboBox cbMaSach;
        private TextBox txtMaPhiSach;
        private Label MaPhiSach;
        private Label label6;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Label lb;
    }
}