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

namespace WindowsFormsApp
{
    public partial class FormThongTinNhanVien : Form
    {
        private string Tentk;
        public FormThongTinNhanVien(string Tentk)
        {
            InitializeComponent();
            this.Tentk = Tentk;
            lblTentk.Text = Tentk;
            TTNhanvien();
        }


        private void TTNhanvien()
        {
            string name = lblTentk.Text;
            string query = "select MaNV,TenHienThi,GioiTinh,DiaChi,SDT,Quyen from Nhanvien  where TenDangNhap = '" + name + "'";
            if (!string.IsNullOrEmpty(lblTentk.Text))
            {
                DataTable dt = DataProvider.Instance.ExecuteQuery(query);
                lblMa.Text = dt.Rows[0]["MaNV"].ToString();
                lblTen.Text = dt.Rows[0]["TenHienThi"].ToString();
                lblChucvu.Text = dt.Rows[0]["GioiTinh"].ToString();
                lblDiachi.Text = dt.Rows[0]["DiaChi"].ToString();
                lblSdt.Text = dt.Rows[0]["SDT"].ToString();
                lblquyen.Text = dt.Rows[0]["Quyen"].ToString();

            }
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            FormDoiMatKhauMoi f = new FormDoiMatKhauMoi(lblTentk.Text);
            f.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lblTentk_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void lblquyen_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
