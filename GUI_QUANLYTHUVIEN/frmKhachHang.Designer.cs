namespace GUI_QUANLYTHUVIEN
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            groupBox2 = new GroupBox();
            txtSoDienThoai = new TextBox();
            txtcccd = new TextBox();
            dtpNgayTao = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            rbtDangHoatDong = new RadioButton();
            rbtTamNgung = new RadioButton();
            label2 = new Label();
            label8 = new Label();
            btnMoiTG = new Button();
            btnXoaTG = new Button();
            btnSuaTG = new Button();
            btnThemTG = new Button();
            txtMaTG = new TextBox();
            txtTenTG = new TextBox();
            txtEmail = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgvDanhSachTG = new DataGridView();
            txtTimKiemKH = new TextBox();
            btnTimKiemKH = new Guna.UI2.WinForms.Guna2ImageButton();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachTG).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = SystemColors.MenuHighlight;
            guna2HtmlLabel1.Location = new Point(134, 14);
            guna2HtmlLabel1.Margin = new Padding(2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(126, 32);
            guna2HtmlLabel1.TabIndex = 21;
            guna2HtmlLabel1.Text = "Khách Hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSoDienThoai);
            groupBox2.Controls.Add(txtcccd);
            groupBox2.Controls.Add(dtpNgayTao);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnMoiTG);
            groupBox2.Controls.Add(btnXoaTG);
            groupBox2.Controls.Add(btnSuaTG);
            groupBox2.Controls.Add(btnThemTG);
            groupBox2.Controls.Add(txtMaTG);
            groupBox2.Controls.Add(txtTenTG);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(15, 245);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(958, 133);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Khách Hàng";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(109, 85);
            txtSoDienThoai.Margin = new Padding(2);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(395, 23);
            txtSoDienThoai.TabIndex = 43;
            // 
            // txtcccd
            // 
            txtcccd.Location = new Point(600, 42);
            txtcccd.Margin = new Padding(2);
            txtcccd.Name = "txtcccd";
            txtcccd.Size = new Size(337, 23);
            txtcccd.TabIndex = 42;
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.CustomFormat = "dd/mm/yyyy";
            dtpNgayTao.Format = DateTimePickerFormat.Custom;
            dtpNgayTao.Location = new Point(600, 64);
            dtpNgayTao.Margin = new Padding(2);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(337, 23);
            dtpNgayTao.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(531, 64);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 40;
            label4.Text = "Ngày Tạo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(531, 44);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 39;
            label3.Text = "CCCD:";
            // 
            // panel2
            // 
            panel2.Controls.Add(rbtDangHoatDong);
            panel2.Controls.Add(rbtTamNgung);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(538, 11);
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 88);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 36;
            label8.Text = "SĐT:";
            // 
            // btnMoiTG
            // 
            btnMoiTG.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMoiTG.Location = new Point(858, 86);
            btnMoiTG.Margin = new Padding(2);
            btnMoiTG.Name = "btnMoiTG";
            btnMoiTG.Size = new Size(78, 27);
            btnMoiTG.TabIndex = 34;
            btnMoiTG.Text = "Mới";
            btnMoiTG.UseVisualStyleBackColor = true;
            btnMoiTG.Click += btnMoiTG_Click;
            // 
            // btnXoaTG
            // 
            btnXoaTG.BackColor = Color.Red;
            btnXoaTG.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaTG.ForeColor = SystemColors.ControlLightLight;
            btnXoaTG.Location = new Point(753, 86);
            btnXoaTG.Margin = new Padding(2);
            btnXoaTG.Name = "btnXoaTG";
            btnXoaTG.Size = new Size(78, 27);
            btnXoaTG.TabIndex = 33;
            btnXoaTG.Text = "Xóa";
            btnXoaTG.UseVisualStyleBackColor = false;
            btnXoaTG.Click += btnXoaTG_Click;
            // 
            // btnSuaTG
            // 
            btnSuaTG.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuaTG.Location = new Point(646, 88);
            btnSuaTG.Margin = new Padding(2);
            btnSuaTG.Name = "btnSuaTG";
            btnSuaTG.Size = new Size(78, 22);
            btnSuaTG.TabIndex = 32;
            btnSuaTG.Text = "Sửa";
            btnSuaTG.UseVisualStyleBackColor = true;
            btnSuaTG.Click += btnSuaTG_Click;
            // 
            // btnThemTG
            // 
            btnThemTG.BackColor = Color.Blue;
            btnThemTG.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemTG.ForeColor = SystemColors.ControlLightLight;
            btnThemTG.Location = new Point(533, 86);
            btnThemTG.Margin = new Padding(2);
            btnThemTG.Name = "btnThemTG";
            btnThemTG.Size = new Size(78, 27);
            btnThemTG.TabIndex = 31;
            btnThemTG.Text = "Thêm";
            btnThemTG.UseVisualStyleBackColor = false;
            btnThemTG.Click += btnThemTG_Click;
            // 
            // txtMaTG
            // 
            txtMaTG.Location = new Point(109, 18);
            txtMaTG.Margin = new Padding(2);
            txtMaTG.Name = "txtMaTG";
            txtMaTG.Size = new Size(395, 23);
            txtMaTG.TabIndex = 24;
            // 
            // txtTenTG
            // 
            txtTenTG.Location = new Point(109, 40);
            txtTenTG.Margin = new Padding(2);
            txtTenTG.Name = "txtTenTG";
            txtTenTG.Size = new Size(395, 23);
            txtTenTG.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(109, 62);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(395, 23);
            txtEmail.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 42);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 21;
            label7.Text = "Tên Khách Hàng";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 15;
            label1.Text = "Mã Khách Hàng:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachTG);
            groupBox1.Location = new Point(15, 45);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(958, 196);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Khách Hàng";
            // 
            // dgvDanhSachTG
            // 
            dgvDanhSachTG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachTG.Location = new Point(4, 15);
            dgvDanhSachTG.Margin = new Padding(2);
            dgvDanhSachTG.Name = "dgvDanhSachTG";
            dgvDanhSachTG.RowHeadersWidth = 62;
            dgvDanhSachTG.Size = new Size(950, 174);
            dgvDanhSachTG.TabIndex = 3;
            dgvDanhSachTG.CellDoubleClick += dgvDanhSachTG_CellDoubleClick;
            // 
            // txtTimKiemKH
            // 
            txtTimKiemKH.Location = new Point(375, 19);
            txtTimKiemKH.Margin = new Padding(2);
            txtTimKiemKH.Name = "txtTimKiemKH";
            txtTimKiemKH.Size = new Size(551, 23);
            txtTimKiemKH.TabIndex = 18;
            // 
            // btnTimKiemKH
            // 
            btnTimKiemKH.CheckedState.ImageSize = new Size(64, 64);
            btnTimKiemKH.HoverState.ImageSize = new Size(64, 64);
            btnTimKiemKH.Image = (Image)resources.GetObject("btnTimKiemKH.Image");
            btnTimKiemKH.ImageOffset = new Point(0, 0);
            btnTimKiemKH.ImageRotate = 0F;
            btnTimKiemKH.ImageSize = new Size(30, 30);
            btnTimKiemKH.Location = new Point(929, 13);
            btnTimKiemKH.Margin = new Padding(2);
            btnTimKiemKH.Name = "btnTimKiemKH";
            btnTimKiemKH.PressedState.ImageSize = new Size(64, 64);
            btnTimKiemKH.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnTimKiemKH.Size = new Size(44, 27);
            btnTimKiemKH.TabIndex = 17;
            btnTimKiemKH.Click += btnTimKiemKH_Click;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 422);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtTimKiemKH);
            Controls.Add(btnTimKiemKH);
            Margin = new Padding(2);
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            Load += frmKhachHang_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachTG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private GroupBox groupBox2;
        private TextBox txtcccd;
        private DateTimePicker dtpNgayTao;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private RadioButton rbtDangHoatDong;
        private RadioButton rbtTamNgung;
        private Label label2;
        private Label label8;
        private Button btnMoiTG;
        private Button btnXoaTG;
        private Button btnSuaTG;
        private Button btnThemTG;
        private TextBox txtMaTG;
        private TextBox txtTenTG;
        private TextBox txtEmail;
        private Label label7;
        private Label label6;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvDanhSachTG;
        private TextBox txtTimKiemKH;
        private Guna.UI2.WinForms.Guna2ImageButton btnTimKiemKH;
        private TextBox txtSoDienThoai;
    }
}