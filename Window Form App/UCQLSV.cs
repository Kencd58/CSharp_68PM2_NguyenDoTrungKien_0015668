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
        private void LoadData()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            List<sinh_vien> dssv = db.sinh_viens.ToList();
            dgvSinhVien.DataSource = dssv;
        }

       public UCQLSV()
        {
            InitializeComponent();
            dgvSinhVien.AutoGenerateColumns = false;

            colMaSV.DataPropertyName = "ma_sv";
            colHoTen.DataPropertyName = "ho_ten";
            colGioiTinh.DataPropertyName = "gioitinh";
            colNgaySinh.DataPropertyName = "ngay_sinh";
            //colLop.DataPropertyName = "ma_lop";
        }

        private void UCQLSV_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string HoVaTen = txtHoTen.Text;
            string MaSinhVien = txtMSV.Text;
            DateTime NgaySinh = dtpNgaySinh.Value;
            string GioiTinh = cbGioiTinh.Text;
            //string Lop = txt_lop.Text;

            sinh_vien sv = new sinh_vien();

            sv.ma_sv = MaSinhVien;
            sv.ho_ten = HoVaTen;
            sv.ngay_sinh = NgaySinh;
            sv.gioi_tinh = GioiTinh;
            //sv.ma_lop = Lop;

            DataClasses1DataContext db = new DataClasses1DataContext();

            db.sinh_viens.InsertOnSubmit(sv);
            db.SubmitChanges();

            MessageBox.Show("Thêm sinh viên thành công!");

            LoadData();
        }
    }
}
