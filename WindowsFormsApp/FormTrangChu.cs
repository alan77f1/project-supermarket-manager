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
      
        public FormTrangChu()
        {
            InitializeComponent();
            /*hiển thị trang chủ*/
            UC_TrangChu tc = new UC_TrangChu();
            themUC(tc);
            PhanQuyen();
            lbNguoiDung.Text = FormDangNhap.tenHienThi;

        }


        void PhanQuyen()
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
            panelDiChuyen.Top = control.Top;
            panelDiChuyen.Height = control.Height;
        }


        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbTime.Text = dt.ToString("HH:MM:ss");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void movesidePannel(Control btn)
        {
            panelDiChuyen.Top = btn.Top;
            panelDiChuyen.Height = btn.Height;
        }

        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        private void btnNhanVien_Click_1(object sender, EventArgs e)
        {
            movesidePannel(btnNhanVien);
            UC_NhanVien nv = new UC_NhanVien();
            addControlsToPanel(nv);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            movesidePannel(btnBanHang);
            UC_BanHang bh = new UC_BanHang();
            addControlsToPanel(bh);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            movesidePannel(btnKhachHang);
            UC_KhachHang khh = new UC_KhachHang();
            addControlsToPanel(khh);
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            movesidePannel(btnNCC);
            UC_NhaCungCap ncc = new UC_NhaCungCap();
            addControlsToPanel(ncc);
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            movesidePannel(btnKhoHang);
            UC_KhoHang kh = new UC_KhoHang();
            addControlsToPanel(kh);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            movesidePannel(btnTrangChu);
            UC_TrangChu tc = new UC_TrangChu();
            addControlsToPanel(tc);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            movesidePannel(btnThongKe);
            UC_ThongKe tk = new UC_ThongKe();
            addControlsToPanel(tk);


        }
    }
}
