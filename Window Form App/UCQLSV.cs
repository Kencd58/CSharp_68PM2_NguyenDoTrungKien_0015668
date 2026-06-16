using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Form_App
{

    public partial class UCQLSV : Form

    {
        string maLopDangLoc = "";
        int currentPage = 1;
        int pageSize = 5;
        int totalPage = 1;
        private void LoadData()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var query = db.sinh_viens.AsQueryable();

            if (maLopDangLoc != "")
            {
                query = query.Where(sv => sv.ma_lop == maLopDangLoc);
            }

            int totalRecord = query.Count();

            totalPage = (int)Math.Ceiling((double)totalRecord / pageSize);

            if (totalPage == 0)
            {
                totalPage = 1;
            }

            if (currentPage > totalPage)
            {
                currentPage = totalPage;
            }

            if (currentPage < 1)
            {
                currentPage = 1;
            }

            List<sinh_vien> dssv = query
                .OrderBy(sv => sv.ma_sv)
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            dgvSinhVien.DataSource = dssv;

            if (maLopDangLoc != "")
            {
                lbPage.Text = "Lớp " + maLopDangLoc + " | Trang " + currentPage + "/" + totalPage + " | " + totalRecord + " bản ghi";
            }
            else
            {
                lbPage.Text = "Trang " + currentPage + "/" + totalPage + " | " + totalRecord + " bản ghi";
            }
        }
        private void LoadLop()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            List<lop_hoc> dsLop = db.lop_hocs.ToList();

            cbLop.DataSource = dsLop;
            cbLop.DisplayMember = "ten_lop";
            cbLop.ValueMember = "ma_lop";
        }
        private void UCQLSV_Load(object sender, EventArgs e)
        {
            LoadLop();
            LoadData();

        }

        public UCQLSV()
        {
            InitializeComponent();
            dgvSinhVien.AutoGenerateColumns = false;

            colMaSV.DataPropertyName = "ma_sv";
            colHoTen.DataPropertyName = "ho_ten";
            colGioiTinh.DataPropertyName = "gioi_tinh";
            colNgaySinh.DataPropertyName = "ngay_sinh";
            colLop.DataPropertyName = "ma_lop";
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.SelectedIndex = 0;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;

            this.Load += UCQLSV_Load;

            btnFirstPage.Click += btnFirstPage_Click;
            btnPreviousPage.Click += btnPreviousPage_Click;
            btnNextPage.Click += btnNextPage_Click;
            btnLastPage.Click += btnLastPage_Click;



            button2.Click += button2_Click; 
        }
        public UCQLSV(string maLop) : this()
        {
            maLopDangLoc = maLop;
            currentPage = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCQLLH formLop = new UCQLLH();
            formLop.Show();

            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string HoVaTen = txtHoTen.Text;
            string MaSinhVien = txtMSV.Text;
            DateTime NgaySinh = dtpNgaySinh.Value;
            string GioiTinh = cbGioiTinh.Text;
            string Lop = cbLop.SelectedValue.ToString();

            sinh_vien sv = new sinh_vien();

            sv.ma_sv = MaSinhVien;
            sv.ho_ten = HoVaTen;
            sv.ngay_sinh = NgaySinh;
            sv.gioi_tinh = GioiTinh;
            sv.ma_lop = Lop;

            DataClasses1DataContext db = new DataClasses1DataContext();

            db.sinh_viens.InsertOnSubmit(sv);
            db.SubmitChanges();

            MessageBox.Show("Thêm sinh viên thành công!");

            LoadData();
        }
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

            txtMSV.Text = row.Cells["colMaSV"].Value?.ToString();
            txtHoTen.Text = row.Cells["colHoTen"].Value?.ToString();
            cbGioiTinh.Text = row.Cells["colGioiTinh"].Value?.ToString();
            cbLop.SelectedValue = row.Cells["colLop"].Value?.ToString();

            if (row.Cells["colNgaySinh"].Value != null)
            {
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["colNgaySinh"].Value);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaSinhVien = txtMSV.Text;
            DataClasses1DataContext db = new DataClasses1DataContext();
            sinh_vien sv = db.sinh_viens.FirstOrDefault(s => s.ma_sv == MaSinhVien);
            if (sv != null)
            {
                sv.ho_ten = txtHoTen.Text;
                sv.gioi_tinh = cbGioiTinh.Text;
                sv.ngay_sinh = dtpNgaySinh.Value;
                sv.ma_lop = cbLop.SelectedValue.ToString();
                db.SubmitChanges();
                MessageBox.Show("Cập nhật sinh viên thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên với mã đã nhập.");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaSinhVien = txtMSV.Text;
            DataClasses1DataContext db = new DataClasses1DataContext();
            sinh_vien sv = db.sinh_viens.FirstOrDefault(s => s.ma_sv == MaSinhVien);
            if (sv != null)
            {
                db.sinh_viens.DeleteOnSubmit(sv);
                db.SubmitChanges();
                MessageBox.Show("Xóa sinh viên thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên với mã đã nhập.");
            }
        }
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData();
        }
        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData();
            }
        }
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPage)
            {
                currentPage++;
                LoadData();
            }
        }
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            currentPage = totalPage;
            LoadData();
        }
    }
}