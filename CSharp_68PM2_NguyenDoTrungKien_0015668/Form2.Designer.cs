namespace CSharp_68PM2_NguyenDoTrungKien_0015668
{
    partial class Form2
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
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            cbLop = new ComboBox();
            label6 = new Label();
            cbGioiTinh = new ComboBox();
            label5 = new Label();
            dtpNgaySinh = new DateTimePicker();
            txtHoTen = new TextBox();
            label4 = new Label();
            txtMSV = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            label7 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvSinhVien = new DataGridView();
            colMaSV = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colLop = new DataGridViewTextBoxColumn();
            btnFirstPage = new Button();
            btnPreviousPage = new Button();
            btnLastPage = new Button();
            btnNextPage = new Button();
            lbPage = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 46);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(422, 0);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 2;
            button3.Text = "Đăng xuất";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(218, 0);
            button2.Name = "button2";
            button2.Size = new Size(198, 46);
            button2.TabIndex = 2;
            button2.Text = "Quản lý lớp học";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(212, 46);
            button1.TabIndex = 1;
            button1.Text = "Quản lý sinh viên";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbLop);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbGioiTinh);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMSV);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(28, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(576, 679);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // cbLop
            // 
            cbLop.FormattingEnabled = true;
            cbLop.Location = new Point(15, 605);
            cbLop.Name = "cbLop";
            cbLop.Size = new Size(529, 40);
            cbLop.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 555);
            label6.Name = "label6";
            label6.Size = new Size(58, 32);
            label6.TabIndex = 14;
            label6.Text = "Lớp:";
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.Location = new Point(15, 489);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(529, 40);
            cbGioiTinh.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 439);
            label5.Name = "label5";
            label5.Size = new Size(110, 32);
            label5.TabIndex = 12;
            label5.Text = "Giới tính:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(15, 352);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(529, 39);
            dtpNgaySinh.TabIndex = 11;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(15, 225);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(529, 39);
            txtHoTen.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 181);
            label4.Name = "label4";
            label4.Size = new Size(123, 32);
            label4.TabIndex = 9;
            label4.Text = "Họ và tên:";
            // 
            // txtMSV
            // 
            txtMSV.Location = new Point(15, 103);
            txtMSV.Name = "txtMSV";
            txtMSV.Size = new Size(529, 39);
            txtMSV.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 59);
            label1.Name = "label1";
            label1.Size = new Size(156, 32);
            label1.TabIndex = 3;
            label1.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 302);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 5;
            label2.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 485);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(28, 772);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(275, 81);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(28, 895);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(275, 81);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(324, 772);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(280, 81);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(324, 895);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(280, 81);
            btnLamMoi.TabIndex = 12;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(694, 74);
            label7.Name = "label7";
            label7.Size = new Size(113, 32);
            label7.TabIndex = 13;
            label7.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(694, 126);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(498, 39);
            txtTimKiem.TabIndex = 14;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1233, 126);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(274, 66);
            btnTimKiem.TabIndex = 15;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.BackgroundColor = SystemColors.ControlLightLight;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { colMaSV, colHoTen, colGioiTinh, colNgaySinh, colLop });
            dgvSinhVien.Location = new Point(694, 200);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersVisible = false;
            dgvSinhVien.RowHeadersWidth = 82;
            dgvSinhVien.Size = new Size(1116, 653);
            dgvSinhVien.TabIndex = 16;
            // 
            // colMaSV
            // 
            colMaSV.HeaderText = "Mã SV";
            colMaSV.MinimumWidth = 10;
            colMaSV.Name = "colMaSV";
            colMaSV.Width = 150;
            // 
            // colHoTen
            // 
            colHoTen.HeaderText = "Họ và Tên";
            colHoTen.MinimumWidth = 10;
            colHoTen.Name = "colHoTen";
            colHoTen.Width = 300;
            // 
            // colGioiTinh
            // 
            colGioiTinh.HeaderText = "Giới Tính";
            colGioiTinh.MinimumWidth = 10;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.Width = 150;
            // 
            // colNgaySinh
            // 
            colNgaySinh.HeaderText = "Ngày Sinh";
            colNgaySinh.MinimumWidth = 10;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.Width = 250;
            // 
            // colLop
            // 
            colLop.HeaderText = "Lớp";
            colLop.MinimumWidth = 10;
            colLop.Name = "colLop";
            colLop.Width = 150;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Location = new Point(766, 884);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(150, 103);
            btnFirstPage.TabIndex = 18;
            btnFirstPage.Text = "<<";
            btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(912, 884);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(150, 103);
            btnPreviousPage.TabIndex = 19;
            btnPreviousPage.Text = "<";
            btnPreviousPage.UseVisualStyleBackColor = true;
            // 
            // btnLastPage
            // 
            btnLastPage.Location = new Point(1526, 884);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(150, 103);
            btnLastPage.TabIndex = 21;
            btnLastPage.Text = ">>";
            btnLastPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(1380, 884);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(150, 103);
            btnNextPage.TabIndex = 20;
            btnNextPage.Text = ">";
            btnNextPage.UseVisualStyleBackColor = true;
            // 
            // lbPage
            // 
            lbPage.AutoSize = true;
            lbPage.Location = new Point(1104, 919);
            lbPage.Name = "lbPage";
            lbPage.Size = new Size(236, 32);
            lbPage.TabIndex = 22;
            lbPage.Text = "Trang 1/1 | 3 bản ghi";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1880, 1010);
            Controls.Add(lbPage);
            Controls.Add(btnLastPage);
            Controls.Add(btnNextPage);
            Controls.Add(btnPreviousPage);
            Controls.Add(btnFirstPage);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label7);
            Controls.Add(btnLamMoi);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button button3;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtHoTen;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtMSV;
        private DateTimePicker dtpNgaySinh;
        private Label label5;
        private ComboBox cbLop;
        private Label label6;
        private ComboBox cbGioiTinh;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLamMoi;
        private Label label7;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvSinhVien;
        private DataGridViewTextBoxColumn colMaSV;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colLop;
        private Button btnFirstPage;
        private Button btnPreviousPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Label lbPage;
    }
}