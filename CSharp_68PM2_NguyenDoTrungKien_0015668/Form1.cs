namespace CSharp_68PM2_NguyenDoTrungKien_0015668
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = "0015668@st.huce.edu.vn";
            string mssv = "0015668";
            string tenDN= txtEmail.Text.Trim();
            string mk = txtPassword.Text.Trim();
            if (tenDN == email && mk == mssv)
            {
                MessageBox.Show("đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("đăng nhập thất bại");
            }

        }
    }
}
