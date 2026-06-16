using System;
using System.Linq;
using System.Windows.Forms;

namespace Window_Form_App
{
    public partial class FrmDSSVTheoLop : Form
    {
        private string maLop;

        public FrmDSSVTheoLop(string maLop)
        {
            InitializeComponent();
             
            this.maLop = maLop;

            this.Load += FrmDSSVTheoLop_Load;
            btnDong.Click += btnDong_Click;
        }

        private void FrmDSSVTheoLop_Load(object sender, EventArgs e)
        {
            LoadSinhVienTheoLop();
        }

        private void LoadSinhVienTheoLop()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var lop = db.lop_hocs.FirstOrDefault(l => l.ma_lop == maLop);

            if (lop != null)
            {
                lblTieuDe.Text = "Danh sách sinh viên lớp: " + lop.ten_lop;
            }
            else
            {
                lblTieuDe.Text = "Danh sách sinh viên lớp: " + maLop;
            }

            var dsSinhVien = db.sinh_viens
                .Where(sv => sv.ma_lop == maLop)
                .Select(sv => new
                {
                    MaSinhVien = sv.ma_sv,
                    HoTen = sv.ho_ten,
                    NgaySinh = sv.ngay_sinh,
                    GioiTinh = sv.gioi_tinh,
                    MaLop = sv.ma_lop
                })
                .ToList();

            dgvSinhVien.DataSource = dsSinhVien;

            dgvSinhVien.AutoGenerateColumns = true;

            if (dgvSinhVien.Columns["MaSinhVien"] != null)
                dgvSinhVien.Columns["MaSinhVien"].HeaderText = "Mã sinh viên";

            if (dgvSinhVien.Columns["HoTen"] != null)
                dgvSinhVien.Columns["HoTen"].HeaderText = "Họ tên";

            if (dgvSinhVien.Columns["NgaySinh"] != null)
                dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";

            if (dgvSinhVien.Columns["GioiTinh"] != null)
                dgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới tính";

            if (dgvSinhVien.Columns["MaLop"] != null)
                dgvSinhVien.Columns["MaLop"].HeaderText = "Mã lớp";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}