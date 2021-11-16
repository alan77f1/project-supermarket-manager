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
using WindowsFormsApp.DAO;

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
            if (chkHienThiMK.Checked == true)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
                txtMatKhau.PasswordChar = '*';
        }


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txtTenDangNhap.Text;
            string passWord = txtMatKhau.Text;
            if (Login(TenDangNhap, passWord))
            {
               /* tenNgDung = QuanLyNhanVien.Intance.getNVByID(TenDangNhap).TenNguoiDung;*/
                quyen = QuanLyNhanVien.Intance.getNVByID(TenDangNhap).Quyen;
                FormTrangChu f = new FormTrangChu();
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

        private void lblAmind_Click_1(object sender, EventArgs e)
        {
            /*string tenDangNhap = txtTenDangNhap.Text;
            string passWord = txtMatKhau.Text;
            if (Login(tenDangNhap, passWord))
            {
                tenNgDung = QuanLyNhanVien.Intance.getNVByID(tenDangNhap).TenHienThi;
                quyen = QuanLyNhanVien.Intance.getNVByID(tenDangNhap).Quyen;
                UC_TrangChu f = new UC_TrangChu();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }*/

            if (check_data() == true)
            {
                string tenDangNhap = txtTenDangNhap.Text;
                string passWord = txtMatKhau.Text;
                if (Login(tenDangNhap, passWord))
                {
                    tenHienThi = QuanLyNhanVien.Intance.getNVByID(tenDangNhap).TenHienThi;
                    quyen = QuanLyNhanVien.Intance.getNVByID(tenDangNhap).Quyen;
                    FormTrangChu f = new FormTrangChu();    
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                    lblCanhbao.Text = "Sai tài khoản hoặc mật khẩu. Lưu ý đăng nhập là nhà quản lý!";
                lblCanhbao.ForeColor = Color.Brown;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy FormDangKy = new FormDangKy();
            FormDangKy.Show();
            this.Hide();
        }

        private void lbQuenMK_Click(object sender, EventArgs e)
        {
            FormSDT FormSDT = new FormSDT();
            FormSDT.Show();
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
