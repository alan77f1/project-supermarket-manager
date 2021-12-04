using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Controller;
using WindowsFormsApp.Models;

namespace WindowsFormsApp
{
    public partial class UC_DoiMatKhau : UserControl
    {
        private string sdt;
        public UC_DoiMatKhau(string sdt)
        {
            InitializeComponent();
            this.sdt = sdt;
            txtSđtnv.Text = sdt;
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.ShowDialog();
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtmatkhaumoi.Text == txtxacnhan.Text)
            {
                if (QuanLyNhanVien.Intance.capnhatmk(txtmatkhaumoi.Text, txtSđtnv.Text))
                {
                    lblCanhbao.Text = "Đổi mật khẩu thành công";
                    lblCanhbao.ForeColor = Color.Brown;
                }
                else
                    lblCanhbao.Text = "Đổi mật khẩu thất bại";
                lblCanhbao.ForeColor = Color.Brown;
            }else
                lblCanhbao.Text = "Mật khẩu xác nhận ko đúng";
                lblCanhbao.ForeColor = Color.Brown;
        }

        private void txtxacnhan_TextChanged(object sender, EventArgs e)
        {
            lblCanhbao.Text = "";
        }

        
    }
}


/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Models;

namespace WindowsFormsApp
{
    public partial class UC_DoiMatKhau : UserControl
    {
        private string xn;
        public UC_DoiMatKhau(string thaydoi)
        {
            InitializeComponent();
            this.xn = thaydoi;
            txtSđtnv.Text = xn;
        }
        BLL bll = new BLL();
        private void UC_Dangkymk_moi_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtmatkhaumoi.Text != txtxacnhan.Text)
            {
                lblCanhbao.Text = "";
                lblCanhbao.Text = "Mật khẩu kiểm tra không khớp - Vui lòng thử lại";
                lblCanhbao.ForeColor = Color.Brown;
            }
            else
            {
                if (check_data() == true)
                {
                    NhanVien nv = new NhanVien();
                    nv.MatKhau = txtxacnhan.Text;
                    nv.SDT = txtSđtnv.Text;
                    string query = "update NhanVien set Matkhau = @Matkhau where Sdt = @Sdt";


                    if (bll.Caplai_mk(nv, query) == true)
                    {
                        lblCanhbao.Text = "Đổi mật khẩu thành công";
                        lblCanhbao.ForeColor = Color.Brown;
                    }
                    else
                        lblCanhbao.Text = "Đổi mật khẩu không thành công";
                    lblCanhbao.ForeColor = Color.Brown;
                }

            }
        }

        private void txtmatkhaumoi_TextChanged(object sender, EventArgs e)
        {
            lblCanhbao.Text = "";

        }

        private void txtxacnhan_TextChanged(object sender, EventArgs e)
        {
            lblCanhbao.Text = "";
        }


        private bool check_data()
        {
            if (string.IsNullOrEmpty(txtmatkhaumoi.Text))
            {
                errorProvider1.SetError(txtmatkhaumoi, " ");
                lblCanhbao.Text = "Vui lòng nhập mật khẩu mới";
                lblCanhbao.ForeColor = Color.Brown;
                return false;
            }
            else
                errorProvider1.SetError(txtmatkhaumoi, null);


            if (string.IsNullOrEmpty(txtxacnhan.Text))
            {
                errorProvider2.SetError(txtmatkhaumoi, " ");
                lblCanhbao.Text = "Vui lòng xác nhận mật khẩu";
                lblCanhbao.ForeColor = Color.Brown;
                return false;
            }
            else
                errorProvider2.SetError(txtxacnhan, null);
            return true;
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangnhap = new FormDangNhap();
            formDangnhap.Show();
            this.Hide();
        }




    }
}
*/