namespace GUI_QUANLYTHUVIEN
{
    partial class frmNhanVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            txtTimKiemNV = new TextBox();
            groupBox1 = new GroupBox();
            dgvDanhSachNV = new DataGridView();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            rbtDangHoatDong = new RadioButton();
            rbtTamNgung = new RadioButton();
            label2 = new Label();
            panel1 = new Panel();
            rbtQuanLy = new RadioButton();
            rbtNhanVien = new RadioButton();
            label3 = new Label();
            label8 = new Label();
            dtpNgayTao = new DateTimePicker();
            btnMoiNV = new Button();
            btnXoaNV = new Button();
            btnSuaNV = new Button();
            btnThemNV = new Button();
            txtSDT = new TextBox();
            txtMatKhau = new TextBox();
            txtMaNV = new TextBox();
            txtTen = new TextBox();
            txtEmail = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNV).BeginInit();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.ImageSize = new Size(30, 30);
            guna2ImageButton1.Location = new Point(837, 6);
            guna2ImageButton1.Margin = new Padding(2);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2ImageButton1.Size = new Size(44, 27);
            guna2ImageButton1.TabIndex = 0;
            guna2ImageButton1.Click += guna2ImageButton1_Click;
            // 
            // txtTimKiemNV
            // 
            txtTimKiemNV.Location = new Point(282, 6);
            txtTimKiemNV.Margin = new Padding(2);
            txtTimKiemNV.Name = "txtTimKiemNV";
            txtTimKiemNV.Size = new Size(551, 23);
            txtTimKiemNV.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachNV);
            groupBox1.Location = new Point(1, 33);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(958, 200);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Nhân Viên";
            // 
            // dgvDanhSachNV
            // 
            dgvDanhSachNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNV.Location = new Point(-12, 20);
            dgvDanhSachNV.Margin = new Padding(2);
            dgvDanhSachNV.Name = "dgvDanhSachNV";
            dgvDanhSachNV.RowHeadersWidth = 62;
            dgvDanhSachNV.Size = new Size(950, 176);
            dgvDanhSachNV.TabIndex = 3;
            dgvDanhSachNV.CellDoubleClick += dgvDanhSachNV_CellDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dtpNgayTao);
            groupBox2.Controls.Add(btnMoiNV);
            groupBox2.Controls.Add(btnXoaNV);
            groupBox2.Controls.Add(btnSuaNV);
            groupBox2.Controls.Add(btnThemNV);
            groupBox2.Controls.Add(txtSDT);
            groupBox2.Controls.Add(txtMatKhau);
            groupBox2.Controls.Add(txtMaNV);
            groupBox2.Controls.Add(txtTen);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(1, 237);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(958, 139);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Nhân Viên";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // panel2
            // 
            panel2.Controls.Add(rbtDangHoatDong);
            panel2.Controls.Add(rbtTamNgung);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(497, 70);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 27);
            panel2.TabIndex = 38;
            // 
            // rbtDangHoatDong
            // 
            rbtDangHoatDong.AutoSize = true;
            rbtDangHoatDong.Location = new Point(72, 5);
            rbtDangHoatDong.Margin = new Padding(2);
            rbtDangHoatDong.Name = "rbtDangHoatDong";
            rbtDangHoatDong.Size = new Size(114, 19);
            rbtDangHoatDong.TabIndex = 33;
            rbtDangHoatDong.TabStop = true;
            rbtDangHoatDong.Text = "Đang Hoạt Động";
            rbtDangHoatDong.UseVisualStyleBackColor = true;
            // 
            // rbtTamNgung
            // 
            rbtTamNgung.AutoSize = true;
            rbtTamNgung.Location = new Point(202, 5);
            rbtTamNgung.Margin = new Padding(2);
            rbtTamNgung.Name = "rbtTamNgung";
            rbtTamNgung.Size = new Size(88, 19);
            rbtTamNgung.TabIndex = 32;
            rbtTamNgung.TabStop = true;
            rbtTamNgung.Text = "Tạm Ngưng";
            rbtTamNgung.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 31;
            label2.Text = "Trạng Thái:";
            // 
            // panel1
            // 
            panel1.Controls.Add(rbtQuanLy);
            panel1.Controls.Add(rbtNhanVien);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(497, 42);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 24);
            panel1.TabIndex = 37;
            // 
            // rbtQuanLy
            // 
            rbtQuanLy.AutoSize = true;
            rbtQuanLy.Location = new Point(202, 4);
            rbtQuanLy.Margin = new Padding(2);
            rbtQuanLy.Name = "rbtQuanLy";
            rbtQuanLy.Size = new Size(68, 19);
            rbtQuanLy.TabIndex = 32;
            rbtQuanLy.TabStop = true;
            rbtQuanLy.Text = "Quản Lý";
            rbtQuanLy.UseVisualStyleBackColor = true;
            // 
            // rbtNhanVien
            // 
            rbtNhanVien.AutoSize = true;
            rbtNhanVien.Location = new Point(72, 4);
            rbtNhanVien.Margin = new Padding(2);
            rbtNhanVien.Name = "rbtNhanVien";
            rbtNhanVien.Size = new Size(80, 19);
            rbtNhanVien.TabIndex = 31;
            rbtNhanVien.TabStop = true;
            rbtNhanVien.Text = "Nhân Viên";
            rbtNhanVien.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 5);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 30;
            label3.Text = "Vai Trò:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 109);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 36;
            label8.Text = "Ngày Tạo:";
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Location = new Point(73, 107);
            dtpNgayTao.Margin = new Padding(2);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(409, 23);
            dtpNgayTao.TabIndex = 35;
            // 
            // btnMoiNV
            // 
            btnMoiNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMoiNV.Location = new Point(872, 100);
            btnMoiNV.Margin = new Padding(2);
            btnMoiNV.Name = "btnMoiNV";
            btnMoiNV.Size = new Size(78, 20);
            btnMoiNV.TabIndex = 34;
            btnMoiNV.Text = "Mới";
            btnMoiNV.UseVisualStyleBackColor = true;
            btnMoiNV.Click += btnMoiNV_Click;
            // 
            // btnXoaNV
            // 
            btnXoaNV.BackColor = Color.Red;
            btnXoaNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaNV.ForeColor = SystemColors.ControlLightLight;
            btnXoaNV.Location = new Point(757, 100);
            btnXoaNV.Margin = new Padding(2);
            btnXoaNV.Name = "btnXoaNV";
            btnXoaNV.Size = new Size(78, 20);
            btnXoaNV.TabIndex = 33;
            btnXoaNV.Text = "Xóa";
            btnXoaNV.UseVisualStyleBackColor = false;
            btnXoaNV.Click += btnXoaNV_Click;
            // 
            // btnSuaNV
            // 
            btnSuaNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuaNV.Location = new Point(624, 100);
            btnSuaNV.Margin = new Padding(2);
            btnSuaNV.Name = "btnSuaNV";
            btnSuaNV.Size = new Size(78, 20);
            btnSuaNV.TabIndex = 32;
            btnSuaNV.Text = "Sửa";
            btnSuaNV.UseVisualStyleBackColor = true;
            btnSuaNV.Click += btnSuaNV_Click;
            // 
            // btnThemNV
            // 
            btnThemNV.BackColor = Color.Blue;
            btnThemNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemNV.ForeColor = SystemColors.ControlLightLight;
            btnThemNV.Location = new Point(497, 100);
            btnThemNV.Margin = new Padding(2);
            btnThemNV.Name = "btnThemNV";
            btnThemNV.Size = new Size(78, 20);
            btnThemNV.TabIndex = 31;
            btnThemNV.Text = "Thêm";
            btnThemNV.UseVisualStyleBackColor = false;
            btnThemNV.Click += btnThemNV_Click;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(568, 18);
            txtSDT.Margin = new Padding(2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(383, 23);
            txtSDT.TabIndex = 26;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(73, 85);
            txtMatKhau.Margin = new Padding(2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(409, 23);
            txtMatKhau.TabIndex = 25;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(73, 18);
            txtMaNV.Margin = new Padding(2);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(409, 23);
            txtMaNV.TabIndex = 24;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(73, 40);
            txtTen.Margin = new Padding(2);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(409, 23);
            txtTen.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(73, 62);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(409, 23);
            txtEmail.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 42);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 21;
            label7.Text = "Tên:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 64);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 20;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 86);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 19;
            label5.Text = "Mật Khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(497, 20);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 18;
            label4.Text = "SĐT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 15;
            label1.Text = "Mã NV:";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = SystemColors.MenuHighlight;
            guna2HtmlLabel1.Location = new Point(159, 2);
            guna2HtmlLabel1.Margin = new Padding(2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(110, 32);
            guna2HtmlLabel1.TabIndex = 17;
            guna2HtmlLabel1.Text = "Nhân Viên";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(975, 378);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtTimKiemNV);
            Controls.Add(guna2ImageButton1);
            Margin = new Padding(2);
            Name = "frmNhanVien";
            Text = "Quản Lý Nhân Viên";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNV).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private TextBox txtTimKiemNV;
        private GroupBox groupBox1;
        private DataGridView dgvDanhSachNV;
        private GroupBox groupBox2;
        private TextBox txtSDT;
        private TextBox txtMatKhau;
        private TextBox txtMaNV;
        private TextBox txtTen;
        private TextBox txtEmail;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private Button btnMoiNV;
        private Button btnXoaNV;
        private Button btnSuaNV;
        private Button btnThemNV;
        private Label label8;
        private DateTimePicker dtpNgayTao;
        private Panel panel2;
        private Panel panel1;
        private RadioButton rbtQuanLy;
        private RadioButton rbtNhanVien;
        private Label label3;
        private RadioButton rbtDangHoatDong;
        private RadioButton rbtTamNgung;
        private Label label2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
