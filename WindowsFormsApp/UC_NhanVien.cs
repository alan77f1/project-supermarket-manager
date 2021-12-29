using System;
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
using BUS;


namespace WindowsFormsApp
{
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
            // LoadData();
            cmbGioiTinh.Items.Add("----- Chọn giới tính -----");
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.Items.Add("Khác");
            cmbGioiTinh.SelectedIndex = 0;
            cmbChucVu.Items.Add("----- Chọn chức vụ ----");
            cmbChucVu.Items.Add("Bán hàng");
            cmbChucVu.Items.Add("Quản lý");
            cmbChucVu.Items.Add("Thủ kho");
            cmbChucVu.SelectedIndex = 0;
            HienThi();

        }

       


        private void txtSĐT_Enter(object sender, EventArgs e)
        {
            if (txtSĐT.Text == "Nhập số điện thoại")
            {
                txtSĐT.Text = "";
                txtSĐT.ForeColor = Color.Black;
            }
        }

        private void txtSĐT_Leave(object sender, EventArgs e)
        {
            if (txtSĐT.Text == "")
            {
                txtSĐT.Text = "Nhập số điện thoại";
                txtSĐT.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Nhập địa chỉ email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Nhập địa chỉ email";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtDiachi_Enter(object sender, EventArgs e)
        {
            if (txtDiachi.Text == "Nhập địa chỉ")
            {
                txtDiachi.Text = "";
                txtDiachi.ForeColor = Color.Black;
            }
        }

        private void txtDiachi_Leave(object sender, EventArgs e)
        {
            if (txtDiachi.Text == "")
            {
                txtDiachi.Text = "Nhập địa chỉ";
                txtDiachi.ForeColor = Color.Gray;
            }
        }

        private void txtTimkiem_Enter(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "Tìm kiếm theo mã, tên nhân viên")
            {
                txtTimkiem.Text = "";
                txtTimkiem.ForeColor = Color.Black;
            }
        }

        private void txtTimkiem_Leave(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                txtTimkiem.Text = "Tìm kiếm theo mã, tên nhân viên";
                txtTimkiem.ForeColor = Color.Gray;
            }
        }

        private void txtKH_Enter(object sender, EventArgs e)
        {
            if (txtKH.Text == "Nhập tên nv")
            {
                txtKH.Text = "";
                txtKH.ForeColor = Color.Black;
            }
        }

        private void txtKH_Leave(object sender, EventArgs e)
        {
            if (txtKH.Text == "")
            {
                txtKH.Text = "Nhập tên nv";
                txtKH.ForeColor = Color.Gray;
            }
        }

        private string Matudong()
        {
            string query = "select MaKH from KhachHang";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "KH001";
            }
            else
            {
                int k;
                ma = "KH";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 2));
                /*k = dt.Rows.Count;*/
                k++;
                if (k < 10)
                {
                    ma = ma + "0";
                }
                else if (k >= 10 && k < 100)
                {
                    ma = ma + "";
                }
                else if (k >= 100 && k < 1000)
                {
                    ma = ma + "";
                }
                ma = ma + k.ToString();

            }
            return ma;
        }

        private void HienThi()
        {   
            DataTable dt = NhanVienBUS.Intance.getListNV();
            dgvNV.DataSource = dt;
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            txtKH.Text = dgvNV.Rows[indexx].Cells[1].Value.ToString();
            txtMaNV.Text = dgvNV.Rows[indexx].Cells[0].Value.ToString();
            cmbGioiTinh.Text = dgvNV.Rows[indexx].Cells[2].Value.ToString();
            txtDiachi.Text = dgvNV.Rows[indexx].Cells[3].Value.ToString();
            txtSĐT.Text = dgvNV.Rows[indexx].Cells[4].Value.ToString();
            txtEmail.Text = dgvNV.Rows[indexx].Cells[6].Value.ToString();
            cmbChucVu.Text = dgvNV.Rows[indexx].Cells[5].Value.ToString();
            txtKH.ForeColor = Color.Black;
            txtDiachi.ForeColor = Color.Black;
            txtMaNV.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtSĐT.ForeColor = Color.Black;
            cmbGioiTinh.ForeColor = Color.Black;
            cmbChucVu.ForeColor = Color.Black;
        }


        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlNhanVien.Controls.Clear();
            pnlNhanVien.Controls.Add(uc);
            uc.BringToFront();
        }



        private void LamMoi()
        {
            txtDiachi.Text = "Nhập địa chỉ";
            txtDiachi.ForeColor = Color.Gray;
            txtKH.Text = "Nhập tên nv";
            txtKH.ForeColor = Color.Gray;
            txtSĐT.Text = "Nhập số điện thoại";
            txtSĐT.ForeColor = Color.Gray;
            txtEmail.Text = "Nhập địa chỉ email";
            txtEmail.ForeColor = Color.Gray;
            cmbGioiTinh.SelectedIndex = 0;
            cmbChucVu.SelectedIndex = 0;
            txtMaNV.Text = "Nhập địa chỉ";
            txtMaNV.ForeColor = Color.Gray;
        }


        private bool Check_data()
        {
            if (txtKH.Text == "Nhập tên nv")
            {
                MessageBox.Show("Bạn cần nhập tên nhân viên", "Thông báo");
                return false;
            }else if(txtMaNV.Text == "Nhập mã nhân viên")
            {
                MessageBox.Show("Bạn cần nhập mã nhân viên", "Thông báo");
                return false;
            }

            return true;
        }



        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                DataTable dt = NhanVienBUS.Intance.TimKiemNV(txtTimkiem.Text);
                dgvNV.DataSource = dt;
            }
            else
                HienThi();



            if (txtTimkiem.Text == "Tìm kiếm theo mã, tên nhân viên")
            {
                HienThi();
            }
        }

        private void dgvNV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            txtKH.Text = dgvNV.Rows[indexx].Cells[1].Value.ToString();
            txtMaNV.Text = dgvNV.Rows[indexx].Cells[0].Value.ToString();
            cmbGioiTinh.Text = dgvNV.Rows[indexx].Cells[2].Value.ToString();
            txtDiachi.Text = dgvNV.Rows[indexx].Cells[3].Value.ToString();
            txtSĐT.Text = dgvNV.Rows[indexx].Cells[4].Value.ToString();
            txtEmail.Text = dgvNV.Rows[indexx].Cells[6].Value.ToString();
            cmbChucVu.Text = dgvNV.Rows[indexx].Cells[5].Value.ToString();
            txtKH.ForeColor = Color.Black;
            txtDiachi.ForeColor = Color.Black;
            txtMaNV.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtSĐT.ForeColor = Color.Black;
            cmbGioiTinh.ForeColor = Color.Black;
            cmbChucVu.ForeColor = Color.Black;
        }


        

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (Check_data() == true)
            {
                if (MessageBox.Show("Cảnh báo bạn có chắc chắn muốn xóa nhân viên này", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "select MaNV as [MaNhanVien] from HoaDon where MaNV = '" + txtMaNV.Text + "'";
                    DataTable dt = DataProvider.Instance.ExecuteQuery(query);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Không thể xóa nhân viên này. Vì nhân viên đã tham gia vào cửa hàng", "Thông báo");
                        LamMoi();
                        //txtMaKH.Text = Matudong();
                    }
                    else


                      if (NhanVienBUS.Intance.xoaNV(txtMaNV.Text))
                    {

                        MessageBox.Show("Xóa nhân viên thành công", "Thông báo");
                        LamMoi();
                        HienThi();
                        //txtMaKH.Text = Matudong();
                    }
                }
                else
                    LamMoi();
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (Check_data() == true)
            {
                if (NhanVienBUS.Intance.suaNV(txtMaNV.Text, txtKH.Text, txtDiachi.Text, cmbGioiTinh.Text, txtSĐT.Text, cmbChucVu.Text))
                {
                    MessageBox.Show("Sửa nhân viên thành công", "Thông báo");
                    LamMoi();
                    HienThi();
                }
            }
        }
    }
}
