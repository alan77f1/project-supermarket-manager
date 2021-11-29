﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using WindowsFormsApp.Controller;


namespace WindowsFormsApp
{
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
            LoadData();
        }


        void loadBinding()
        {
            txtMaNV.DataBindings.Add(new Binding("Text", dgvThongTinNhanVien.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            txtHoTen.DataBindings.Add(new Binding("Text", dgvThongTinNhanVien.DataSource, "TenHienThi", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvThongTinNhanVien.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvThongTinNhanVien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            cmbChucVu.DataBindings.Add(new Binding("Text", dgvThongTinNhanVien.DataSource, "Quyen", true, DataSourceUpdateMode.Never));
        }
     
        void LoadData()
        {
            ClearBinding();
            dgvThongTinNhanVien.DataSource = QuanLyNhanVien.Intance.getListNV();
            loadBinding();
        }

        bool KiemTraNhap()
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống", "Thông báo");
                txtMaNV.Focus();
                return false;
            }
            else if (txtSDT.Text == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống", "Thông báo");
                txtSDT.Focus();
                return false;
            }
            else if (txtHoTen.Text == "")
            {
                MessageBox.Show("Tên người dùng không được bỏ trống", "Thông báo");
                txtHoTen.Focus();
                return false;
            }
            return true;
        }

        void ClearBinding()
        {
            txtMaNV.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            cmbChucVu.DataBindings.Clear();
        }

        public void lamMoi()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }
        public bool check = true;


        private void guna2dgvThongTinNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThongTinNhanVien.SelectedCells.Count > 0)
            {
                cmbChucVu.SelectedItem = dgvThongTinNhanVien.SelectedCells[3].Value;
                ClearBinding();
                loadBinding();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvThongTinNhanVien.DataSource = QuanLyNhanVien.Intance.TimKiemNV(txtTimKiem.Text);
        }


        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            check = !check;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtSDT.Text = "";
            txtHoTen.Text = "";
        }
       
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvThongTinNhanVien.SelectedCells.Count > 0)
            {
                if (QuanLyNhanVien.Intance.suaNV(txtMaNV.Text, txtHoTen.Text, txtDiaChi.Text, txtSDT.Text))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                    LoadData();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (QuanLyNhanVien.Intance.xoaNV(txtMaNV.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo");
                ClearBinding();
                LoadData();
            }
        }
    }
}
