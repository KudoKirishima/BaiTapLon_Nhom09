using System;
using System.Windows.Forms;

namespace BaiTapLon_Nhom9
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text == "Nguyễn Xuân Huy" && txtMatKhau.Text == "huydeptraivl")
            {
                frmQuanLy f = new frmQuanLy();
                f.Show();
               // this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu" , "Thông báo" , 
                    MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
    }
}
