using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace WindowsFormsApp
{
    public partial class UC_KhachHang : UserControl
    {
        public UC_KhachHang()
        {
            InitializeComponent();
            LoadListKH();
        }

        public void LoadListKH()
        {
            DataTable dt = KhachHangBUS.Intance.getListKH();
            dgvThongTinKhachHang.DataSource = dt;
            //loadBinding();
        }

        void loadBinding()
        {
            guna2TextBox1.DataBindings.Add(new Binding("Text", dgvThongTinKhachHang.DataSource, "MaKH", true, DataSourceUpdateMode.Never));
            txtTenKH.DataBindings.Add(new Binding("Text", dgvThongTinKhachHang.DataSource, "TenKH", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvThongTinKhachHang.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtEmail.DataBindings.Add(new Binding("Text", dgvThongTinKhachHang.DataSource, "Email", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvThongTinKhachHang.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
        }

        void ClearBinding()
        {
            guna2TextBox1.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
        }

        

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvThongTinKhachHang.DataSource = KhachHangBUS.Intance.TimKiemKH(txtTimKiem.Text);
            ClearBinding();
            loadBinding();
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            ClearBinding();
            LoadListKH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            check = !check;
            if (check == true)
            {
                guna2TextBox1.Text = "";
                txtTenKH.Text = "";
                txtSDT.Text = "";
                txtEmail.Text = "";
                txtDiaChi.Text = "";
                guna2TextBox1.Enabled = true;
                txtTenKH.Enabled = true;
                txtSDT.Enabled = true;
                txtEmail.Enabled = true;
                txtDiaChi.Enabled = true;
                dgvThongTinKhachHang.Enabled = false;
                btnThem.Text = "Xác nhận";
            }
            else
            {
                btnThem.Text = "Thêm Mới";
                guna2TextBox1.Enabled = false;
                txtTenKH.Enabled = false;
                txtSDT.Enabled = false;
                txtEmail.Enabled = false;
                txtDiaChi.Enabled = false;
                dgvThongTinKhachHang.Enabled = true;
                if (guna2TextBox1.Text == "")
                {
                    MessageBox.Show("Nhập thiếu thông tin! Vui lòng thử lại");
                }
                else
                {
                    if (KhachHangBUS.Intance.themKH(guna2TextBox1.Text, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text))
                    {
                        MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");
                        ClearBinding();
                        LoadListKH();
                    }
                    else MessageBox.Show("Thất bại!", "Thông báo");
                }
            }
        }

        public bool check = false;
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            check = !check;
            if (check == true)
            {
                txtTenKH.Enabled = true;
                txtSDT.Enabled = true;
                txtEmail.Enabled = true;
                txtDiaChi.Enabled = true;
                btnThem.Enabled = false;
            }
            else
            {
                guna2TextBox1.Enabled = false;
                txtTenKH.Enabled = false;
                txtSDT.Enabled = false;
                txtEmail.Enabled = false;
                txtDiaChi.Enabled = false;
                if (KhachHangBUS.Intance.suaKH(guna2TextBox1.Text, txtTenKH.Text, txtDiaChi.Text, Convert.ToInt32(txtSDT.Text), txtEmail.Text))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                    btnThem.Enabled = true;
                    ClearBinding();
                    LoadListKH();
                }
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (KhachHangBUS.Intance.xoaKH(guna2TextBox1.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo");
                ClearBinding();
                LoadListKH();
            }
        }
    }
}
