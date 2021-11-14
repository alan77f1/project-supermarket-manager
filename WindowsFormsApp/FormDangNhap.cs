using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        

        public static string tenHienThi, quyen;

        private bool check_data()
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                errtxtTaikhoan.SetError(txtTenDangNhap, " ");
                lblCanhbao.Text = "Vui lòng nhập tài khoản";
                lblCanhbao.ForeColor = Color.Brown;
                return false;
            }
            else
                errtxtTaikhoan.SetError(txtTenDangNhap, null);

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                errMatkhau.SetError(txtMatKhau, " ");
                lblCanhbao.Text = "";
                lblCanhbao.Text = "Vui lòng nhập mật khẩu";
                lblCanhbao.ForeColor = Color.Brown;
                return false;
            }
            else
                errtxtTaikhoan.SetError(txtMatKhau, null);

            return true;
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            lblCanhbao.Text = "";
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            lblCanhbao.Text = "";
        }

        private void chkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienthimatkhau.Checked == true)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
                txtMatKhau.PasswordChar = '*';
        }






        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string tenDangNhap = guna2TextBox1.Text;
            string passWord = guna2TextBox2.Text;
            if (Login(tenDangNhap, passWord))
            {
                tenNgDung = QuanLyNhanVien.Intance.getNVByID(tenDangNhap).TenNguoiDung;
                quyen = QuanLyNhanVien.Intance.getNVByID(tenDangNhap).Quyen;
                Main f = new Main();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        bool Login(string userName, string passWord)
        {
            return QuanLyNhanVien.Intance.Login(userName, passWord);
        }






















        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (check_data() == true)
            {
                SqlConnection con = chuoiketnoi.sqlConnection();
                con.Open();
                string tk = txtTenDangNhap.Text;
                string mk = txtMatKhau.Text;
                string query = "select tendangnhap,matkhau from Nhanvien where tendangnhap = '" + tk + "' and matkhau = '" + mk + "' and Macv = 'NV'";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read() == true)
                {
                    FormQuyenNhanvien formQuyenNhanvien = new FormQuyenNhanvien();
                    formQuyenNhanvien.Show();
                    this.Hide();
                }
                else
                    lblCanhbao.Text = "Sai tài khoản hoặc mật khẩu. Lưu ý đăng nhập là nhân viên!";
                lblCanhbao.ForeColor = Color.Brown;
                con.Close();
            }
        }

        /*private void lblAmind_Click(object sender, EventArgs e)
        {
            if (check_data() == true)
            {
                SqlConnection con = chuoiketnoi.sqlConnection();
                con.Open();
                string tk = txtTenDangNhap.Text;
                string mk = txtMatKhau.Text;
                string query = "select tendangnhap,matkhau from Nhanvien where tendangnhap = '" + tk + "' and matkhau = '" + mk + "' and Macv = 'QL'";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read() == true)
                {
                    FormTrangChu formTrangchu = new FormTrangChu(); // txt Taikhoan.text
                    formTrangchu.Show();
                    this.Hide();
                }
                else
                    lblCanhbao.Text = "Sai tài khoản hoặc mật khẩu. Lưu ý đăng nhập là nhà quản lý!";
                lblCanhbao.ForeColor = Color.Brown;
                con.Close();
            }
        }*/

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy FormDangKy = new FormDangKy();
            FormDangKy.Show();
            this.Hide();
        }

        private void lbQuenMK_Click(object sender, EventArgs e)
        {
            FormSoDienThoai formSodienthoai = new FormSoDienThoai();
            formSodienthoai.Show();
            this.Hide();
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
