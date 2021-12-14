﻿
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
    public partial class UC_CaLamViec : UserControl
    {

       

        public UC_CaLamViec()
        {
            InitializeComponent();
            Hienthi();
            list = QuanLyNhanVien.Intance.getListNV1();
            cmbTennv.DataSource = list;
            cmbTennv.DisplayMember = "TenHienThi";
            cmbTennv.ValueMember = "TenHienThi";
            list1 = QuanLyCaLamViec.Intance.getListCalamviec();
            cmbCalamviec.DataSource = list1;
            cmbCalamviec.DisplayMember = "Ca";
            cmbCalamviec.ValueMember = "Ca";
            LamMoi();
        }

        List<CaLamViec> list1;
        List<NhanVien> list;

        private void LamMoi()
        {
            cmbTennv.SelectedIndex = -1;
            cmbCalamviec.SelectedIndex = -1;
        }
        private void Hienthi()
        {
            DataTable dt = QuanLyCaLamViec.Intance.getListNV();
            dgvThongTinCLV.DataSource = dt;
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void dgvThongTinCLV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            cmbCalamviec.Text = dgvThongTinCLV.Rows[indexx].Cells[2].Value.ToString();
            cmbTennv.Text = dgvThongTinCLV.Rows[indexx].Cells[1].Value.ToString();
            dpkNgayban.Value = Convert.ToDateTime(dgvThongTinCLV.Rows[indexx].Cells[3].Value.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (QuanLyCaLamViec.Intance.themCLV(maclv, manv, dpkNgayban.Value))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                Hienthi();
                LamMoi();
            }
        }
        string manv;
        string maclv;
      

        private void cmbTennv_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt = QuanLyCaLamViec.Intance.TimkiemMNV(cmbTennv.Text);
            if (dt.Rows.Count > 0)
            {
                manv = dt.Rows[0]["MaNV"].ToString();
            }
        }

        private void cmbCalamviec_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt1 = QuanLyCaLamViec.Intance.TimkiemMCLV(cmbCalamviec.Text);
            if (dt1.Rows.Count > 0)
            {
                maclv = dt1.Rows[0]["MaCLV"].ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable dt = QuanLyCaLamViec.Intance.TimkiemMaNgaylam(cmbTennv.Text, dpkNgayban.Value);

            if (dt.Rows.Count > 0)
            {
                string manv = dt.Rows[0]["MaNV"].ToString();
                DateTime nl = Convert.ToDateTime(dt.Rows[0]["NgayLam"].ToString());
                if (QuanLyCaLamViec.Intance.xoaCLV(manv, dpkNgayban.Value))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    Hienthi();
                    LamMoi();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (QuanLyCaLamViec.Intance.suaCLV(maclv, manv, dpkNgayban.Value))
            {
                MessageBox.Show("Sửa thành công");
                Hienthi();
                LamMoi();
            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            LamMoi();
        }
    }
}
