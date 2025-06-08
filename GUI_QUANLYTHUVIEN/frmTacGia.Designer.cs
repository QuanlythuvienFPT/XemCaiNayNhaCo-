namespace GUI_QUANLYTHUVIEN
{
    partial class frmTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTacGia));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            rbtDangHoatDong = new RadioButton();
            rbtTamNgung = new RadioButton();
            label2 = new Label();
            label8 = new Label();
            dtpNgayTaoTG = new DateTimePicker();
            btnMoiTG = new Button();
            btnXoaTG = new Button();
            btnSuaTG = new Button();
            btnThemTG = new Button();
            txtMaTG = new TextBox();
            txtTenTG = new TextBox();
            txtQuocTich = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgvDanhSachTG = new DataGridView();
            txtTimKiemTG = new TextBox();
            btnTimKiemTG = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachTG).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dtpNgayTaoTG);
            groupBox2.Controls.Add(btnMoiTG);
            groupBox2.Controls.Add(btnXoaTG);
            groupBox2.Controls.Add(btnSuaTG);
            groupBox2.Controls.Add(btnThemTG);
            groupBox2.Controls.Add(txtMaTG);
            groupBox2.Controls.Add(txtTenTG);
            groupBox2.Controls.Add(txtQuocTich);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(19, 393);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1369, 186);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Tác Giả";
            // 
            // panel2
            // 
            panel2.Controls.Add(rbtDangHoatDong);
            panel2.Controls.Add(rbtTamNgung);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(804, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 45);
            panel2.TabIndex = 38;
            // 
            // rbtDangHoatDong
            // 
            rbtDangHoatDong.AutoSize = true;
            rbtDangHoatDong.Location = new Point(103, 8);
            rbtDangHoatDong.Name = "rbtDangHoatDong";
            rbtDangHoatDong.Size = new Size(174, 29);
            rbtDangHoatDong.TabIndex = 33;
            rbtDangHoatDong.TabStop = true;
            rbtDangHoatDong.Text = "Đang Hoạt Động";
            rbtDangHoatDong.UseVisualStyleBackColor = true;
            // 
            // rbtTamNgung
            // 
            rbtTamNgung.AutoSize = true;
            rbtTamNgung.Location = new Point(288, 8);
            rbtTamNgung.Name = "rbtTamNgung";
            rbtTamNgung.Size = new Size(132, 29);
            rbtTamNgung.TabIndex = 32;
            rbtTamNgung.TabStop = true;
            rbtTamNgung.Text = "Tạm Ngưng";
            rbtTamNgung.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 8);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 31;
            label2.Text = "Trạng Thái:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 147);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 36;
            label8.Text = "Ngày Tạo:";
            // 
            // dtpNgayTaoTG
            // 
            dtpNgayTaoTG.Location = new Point(135, 142);
            dtpNgayTaoTG.Name = "dtpNgayTaoTG";
            dtpNgayTaoTG.Size = new Size(583, 31);
            dtpNgayTaoTG.TabIndex = 35;
            // 
            // btnMoiTG
            // 
            btnMoiTG.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMoiTG.Location = new Point(1246, 115);
            btnMoiTG.Name = "btnMoiTG";
            btnMoiTG.Size = new Size(112, 34);
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
            btnXoaTG.Location = new Point(1097, 115);
            btnXoaTG.Name = "btnXoaTG";
            btnXoaTG.Size = new Size(112, 34);
            btnXoaTG.TabIndex = 33;
            btnXoaTG.Text = "Xóa";
            btnXoaTG.UseVisualStyleBackColor = false;
            btnXoaTG.Click += btnXoaTG_Click;
            // 
            // btnSuaTG
            // 
            btnSuaTG.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuaTG.Location = new Point(945, 115);
            btnSuaTG.Name = "btnSuaTG";
            btnSuaTG.Size = new Size(112, 34);
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
            btnThemTG.Location = new Point(782, 115);
            btnThemTG.Name = "btnThemTG";
            btnThemTG.Size = new Size(112, 34);
            btnThemTG.TabIndex = 31;
            btnThemTG.Text = "Thêm";
            btnThemTG.UseVisualStyleBackColor = false;
            btnThemTG.Click += btnThemTG_Click;
            // 
            // txtMaTG
            // 
            txtMaTG.Location = new Point(135, 30);
            txtMaTG.Name = "txtMaTG";
            txtMaTG.Size = new Size(583, 31);
            txtMaTG.TabIndex = 24;
            // 
            // txtTenTG
            // 
            txtTenTG.Location = new Point(135, 67);
            txtTenTG.Name = "txtTenTG";
            txtTenTG.Size = new Size(583, 31);
            txtTenTG.TabIndex = 23;
            // 
            // txtQuocTich
            // 
            txtQuocTich.Location = new Point(135, 101);
            txtQuocTich.Name = "txtQuocTich";
            txtQuocTich.Size = new Size(583, 31);
            txtQuocTich.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 70);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 21;
            label7.Text = "Tên Tác Giả:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 107);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 20;
            label6.Text = "Quốc Tịch:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 33);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 15;
            label1.Text = "Mã Tác Giả:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachTG);
            groupBox1.Location = new Point(19, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1369, 327);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Tác Giả";
            // 
            // dgvDanhSachTG
            // 
            dgvDanhSachTG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachTG.Location = new Point(6, 25);
            dgvDanhSachTG.Name = "dgvDanhSachTG";
            dgvDanhSachTG.RowHeadersWidth = 62;
            dgvDanhSachTG.Size = new Size(1357, 290);
            dgvDanhSachTG.TabIndex = 3;
            dgvDanhSachTG.CellDoubleClick += dgvDanhSachTG_CellDoubleClick;
            // 
            // txtTimKiemTG
            // 
            txtTimKiemTG.Location = new Point(534, 16);
            txtTimKiemTG.Name = "txtTimKiemTG";
            txtTimKiemTG.Size = new Size(785, 31);
            txtTimKiemTG.TabIndex = 13;
            // 
            // btnTimKiemTG
            // 
            btnTimKiemTG.CheckedState.ImageSize = new Size(64, 64);
            btnTimKiemTG.HoverState.ImageSize = new Size(64, 64);
            btnTimKiemTG.Image = (Image)resources.GetObject("btnTimKiemTG.Image");
            btnTimKiemTG.ImageOffset = new Point(0, 0);
            btnTimKiemTG.ImageRotate = 0F;
            btnTimKiemTG.ImageSize = new Size(30, 30);
            btnTimKiemTG.Location = new Point(1325, 7);
            btnTimKiemTG.Name = "btnTimKiemTG";
            btnTimKiemTG.PressedState.ImageSize = new Size(64, 64);
            btnTimKiemTG.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnTimKiemTG.Size = new Size(63, 45);
            btnTimKiemTG.TabIndex = 12;
            btnTimKiemTG.Click += btnTimKiemTG_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = SystemColors.MenuHighlight;
            guna2HtmlLabel1.Location = new Point(189, 9);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(117, 47);
            guna2HtmlLabel1.TabIndex = 16;
            guna2HtmlLabel1.Text = "Tác Giả";
            // 
            // frmTacGia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1406, 582);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtTimKiemTG);
            Controls.Add(btnTimKiemTG);
            Name = "frmTacGia";
            Text = "frmTacGia";
            Load += frmTacGia_Load;
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

        private GroupBox groupBox2;
        private Panel panel2;
        private RadioButton rbtDangHoatDong;
        private RadioButton rbtTamNgung;
        private Label label2;
        private Label label8;
        private DateTimePicker dtpNgayTaoTG;
        private Button btnMoiTG;
        private Button btnXoaTG;
        private Button btnSuaTG;
        private Button btnThemTG;
        private TextBox txtMaTG;
        private TextBox txtTenTG;
        private TextBox txtQuocTich;
        private Label label7;
        private Label label6;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvDanhSachTG;
        private TextBox txtTimKiemTG;
        private Guna.UI2.WinForms.Guna2ImageButton btnTimKiemTG;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}