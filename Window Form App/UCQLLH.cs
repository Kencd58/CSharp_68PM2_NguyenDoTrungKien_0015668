using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Window_Form_App
{
    public partial class UCQLLH : Form
    {

        public UCQLLH()
        {
            InitializeComponent();

            this.Load += UCQLLH_Load;

            add_btn.Click += add_btn_Click;
            sua_btn.Click += sua_btn_Click;
            delete_btn.Click += delete_btn_Click;
            refresh_btn.Click += refresh_btn_Click;
            dataGridView2.CellClick += dataGridView2_CellClick;
            btn_dssv.Click += btn_dssv_Click;
        }
         
        private void UCQLLH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            dataGridView2.DataSource = db.lop_hocs
                .Select(l => new
                {
                    l.ma_lop,
                    l.ten_lop,
                    l.ghi_chu
                })
                .ToList();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string MaLop = txt_lop.Text.Trim();
            string TenLop = txt_tenLop.Text.Trim();

            if (MaLop == "" || TenLop == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã lớp và tên lớp!");
                return;
            }

            DataClasses1DataContext db = new DataClasses1DataContext();

            lop_hoc lopTonTai = db.lop_hocs.FirstOrDefault(l => l.ma_lop == MaLop);

            if (lopTonTai != null)
            {
                MessageBox.Show("Mã lớp đã tồn tại!");
                return;
            }

            lop_hoc lop = new lop_hoc();
            lop.ma_lop = MaLop;
            lop.ten_lop = TenLop;
            lop.ghi_chu = "";

            db.lop_hocs.InsertOnSubmit(lop);
            db.SubmitChanges();

            MessageBox.Show("Thêm lớp học thành công!");

            LoadData();
            LamMoi();
        }
         
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

            txt_lop.Text = row.Cells["ma_lop"].Value?.ToString();
            txt_tenLop.Text = row.Cells["ten_lop"].Value?.ToString();

            txt_lop.Enabled = false;
        }

        private void sua_btn_Click(object sender, EventArgs e)
        {
            string MaLop = txt_lop.Text.Trim();
            string TenLop = txt_tenLop.Text.Trim();

            if (MaLop == "")
            {
                MessageBox.Show("Vui lòng chọn lớp cần sửa!");
                return;
            }

            DataClasses1DataContext db = new DataClasses1DataContext();

            lop_hoc lop = db.lop_hocs.FirstOrDefault(l => l.ma_lop == MaLop);

            if (lop != null)
            {
                lop.ten_lop = TenLop;

                db.SubmitChanges();

                MessageBox.Show("Cập nhật lớp học thành công!");

                LoadData();
                LamMoi();
            }
            else
            {
                MessageBox.Show("Không tìm thấy lớp học.");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string MaLop = txt_lop.Text.Trim();

            if (MaLop == "")
            {
                MessageBox.Show("Vui lòng chọn lớp cần xoá!");
                return;
            }

            DataClasses1DataContext db = new DataClasses1DataContext();

            bool coSinhVien = db.sinh_viens.Any(sv => sv.ma_lop == MaLop);

            if (coSinhVien)
            {
                MessageBox.Show("Không thể xoá lớp này vì vẫn còn sinh viên thuộc lớp.");
                return;
            }

            lop_hoc lop = db.lop_hocs.FirstOrDefault(l => l.ma_lop == MaLop);

            if (lop != null)
            {
                db.lop_hocs.DeleteOnSubmit(lop);
                db.SubmitChanges();

                MessageBox.Show("Xoá lớp học thành công!");

                LoadData();
                LamMoi();
            }
            else
            {
                MessageBox.Show("Không tìm thấy lớp học.");
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadData();
        }

        private void LamMoi()
        {
            txt_lop.Clear();
            txt_tenLop.Clear();

            txt_lop.Enabled = true;
            txt_lop.Focus();
        }
        private void btn_dssv_Click(object sender, EventArgs e)
        {
            string maLop = txt_lop.Text.Trim();

            if (maLop == "")
             
                MessageBox.Show("Vui lòng chọn lớp trước!");
                return;
            }

            FrmDSSVTheoLop formDSSV = new FrmDSSVTheoLop(maLop);
            formDSSV.ShowDialog();
        }
    }

}