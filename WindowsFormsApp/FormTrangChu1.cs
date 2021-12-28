using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormTrangChu1 : Form
    {

        private string tk;
        private string tempTK;
        public FormTrangChu1(string tk)
        {
            InitializeComponent();
            timerTime.Start();
            this.tk = tk;
            tempTK = tk;
            TTnguoiban();
            UC_TrangChu _TrangChu = new UC_TrangChu(lblTenNV.Text);
            addUC(_TrangChu);
        }


        private void timerTime_Tick_1(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:MM:ss");
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void TTnguoiban()
        {
            string name = tempTK;
            string query = "select MaNV,TenHienThi from Nhanvien where TenDangNhap = '" + tk + "'";

           
                DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                lblMaNV.Text = dt.Rows[0]["MaNV"].ToString();
                lblTenNV.Text = dt.Rows[0]["TenHienThi"].ToString();
            }

            
        }


        private void Phanquyen(UserControl us1, UserControl us2, UserControl us3)
        {
            string Name = tempTK;
            string query = "select Quyen as [Quyen] from NhanVien where TenDangNhap = N'" + Name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                lblQuyen.Text = dt.Rows[0]["Quyen"].ToString();

                if (lblQuyen.Text == "Quản lý")
                {
                    addUC(us1);
                }
                else if (lblQuyen.Text == "Thủ kho")
                {
                    addUC(us2);

                }else if (lblQuyen.Text == "Bán hàng")
                {
                    addUC(us3);
                }
            }
        }


        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(uc);
            uc.BringToFront();
        }


        private void ButtonHide()
        {
            // 1. btnTrangChu
            // btnTrangChu.BackColor = new Color;
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 48, 135);
            btnTrangChu.BackColor = myRgbColor;

            // 2. btnKhachhang
            btnKhachHang.BackColor = myRgbColor;

            // 3. btnBanhang
            btnBanHang.BackColor = myRgbColor;

            // 4. btnNhanvien
            btnNhanVien.BackColor = myRgbColor;

            // 5. btnKhohang
            btnKhoHang.BackColor = myRgbColor;

            // 6. btnNhacungcap
            btnNhaCungCap.BackColor = myRgbColor;
          
            // 7. btnThongke
            btnThongKe.BackColor = myRgbColor;

        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 48, 135);
            UC_BanHang _BanHang = new UC_BanHang(lblMaNV.Text,lblTenNV.Text);
            Phanquyen(_BanHang, _HienThiQuyen, _BanHang);
            
            ButtonHide();
            btnBanHang.BackColor = Color.White;
        }


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();
        }

        private void lblTenNV_Click(object sender, EventArgs e)
        {
            //UC_ReportHangTon f = new UC_ReportHangTon();
            //addUC(f);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTrangChu_Click_1(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 48, 135);
            UC_TrangChu _TrangChu = new UC_TrangChu(lblTenNV.Text);
            addUC(_TrangChu);

            ButtonHide();
            btnTrangChu.BackColor = Color.White;
        }

        private void btnKhachHang_Click_1(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 48, 135);
            UC_KhachHang _KhachHang = new UC_KhachHang();
            Phanquyen(_KhachHang, _HienThiQuyen, _KhachHang);

            ButtonHide();
            btnKhachHang.BackColor = Color.White;
        }

        UC_HienThiQuyen _HienThiQuyen = new UC_HienThiQuyen();
        private void btnBanHang_Click_1(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 48, 135);
            UC_BanHang _BanHang = new UC_BanHang(lblMaNV.Text, lblTenNV.Text);
            Phanquyen(_BanHang, _HienThiQuyen, _BanHang);

            ButtonHide();
            btnBanHang.BackColor = Color.White;
        }

        private void btnNhanVien_Click_1(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 48, 135);
            UC_NhanVien _NhanVien = new UC_NhanVien();
            UC_HienThiQuyen _HienThiQuyen = new UC_HienThiQuyen();
            Phanquyen(_NhanVien, _HienThiQuyen, _HienThiQuyen);


            ButtonHide();
            btnNhanVien.BackColor = Color.White;
        }

        private void btnNhaCungCap_Click_1(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 48, 135);
            UC_NhaCungCap _NhaCungCap = new UC_NhaCungCap();
            Phanquyen(_NhaCungCap, _NhaCungCap, _HienThiQuyen);

            ButtonHide();
            btnNhaCungCap.BackColor = Color.White;
        }

        private void btnKhoHang_Click_1(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 48, 135);
            UC_KhoHang _KhoHang = new UC_KhoHang(lblMaNV.Text, lblTenNV.Text);
            Phanquyen(_KhoHang, _KhoHang, _HienThiQuyen);

            ButtonHide();
            btnKhoHang.BackColor = Color.White;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 48, 135);
            UC_ThongKe _ThongKe = new UC_ThongKe();
            Phanquyen(_ThongKe, _HienThiQuyen, _HienThiQuyen);
            ButtonHide();

            btnThongKe.BackColor = Color.White;
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}
