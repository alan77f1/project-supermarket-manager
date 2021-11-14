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
    public partial class FormTrangChu : Form
    {
        //private string Taikhoan;

        int w;
        bool check;
        public FormTrangChu()   // string Taikhoandn
        {
            InitializeComponent();
            time.Start();
            panelLeft.Width = panelLeft.Width - 145;
            w = panelLeft.Width;
            check = false;
            UC_TrangChu tc = new UC_TrangChu();
            themUC(tc);
            phanQuyen();
            lbNguoiDung.Text = FormDangNhap.tenHienThi;
        }

        void phanQuyen()
        {
            if (FormDangNhap.quyen != "admin")
            {
                btnNCC.Enabled = false;
                btnKhoHang.Enabled = false;
                btnNhanVien.Enabled = false;
            }
        }

        private void themUC(Control uc)
        {
            uc.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(uc);
            uc.BringToFront();
        }

        private void diChuyenPanel(Control control)
        {
            panelDichuyen.Top = control.Top;
            panelDichuyen.Height = control.Height;
        }

        private void time_tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbTime.Text = dt.ToString("HH:MM:ss");
        }


        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            diChuyenPanel(btnKhachHang);
            UC_KhachHang kh = new UC_KhachHang();
            themUC(kh);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            diChuyenPanel(btnTrangChu);
            UC_TrangChu UC_TrangChu = new UC_TrangChu();
            themUC(UC_TrangChu);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap dn = new FormDangNhap();
            dn.Show();
            this.Hide();


        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            diChuyenPanel(btnThongKe);
            UC_ThongKe tk = new UC_ThongKe();
            themUC(tk);
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            diChuyenPanel(btnNhanVien);
            UC_NhanVien nv = new UC_NhanVien();
            themUC(nv);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            diChuyenPanel(btnBanHang);
            UC_BanHang bh = new UC_BanHang();
            themUC(bh);
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            diChuyenPanel(btnBanHang);
            UC_KhoHang kh = new UC_KhoHang();
            themUC(kh);
        }

        private void lbNguoiDung_Click(object sender, EventArgs e)
        {

        }
    }
}
