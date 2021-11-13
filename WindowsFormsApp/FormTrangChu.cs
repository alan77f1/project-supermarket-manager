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


        public FormTrangChu()   // string Taikhoandn
        {
            InitializeComponent();
            timertTrangchu.Start();
            UC_Main uC_Main = new UC_Main();
            addUC(uC_Main);
            //this.Taikhoan = Taikhoandn;
            //lblTaikhoan.Text = "";
            //lblTaikhoan.Text = Taikhoan;
        }



        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlTrangchu.Controls.Clear();
            pnlTrangchu.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void DichuyenPanle(Control control)
        {
            panelDichuyen.Top = control.Top;
            panelDichuyen.Height = control.Height;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            DichuyenPanle(btnKhachHang);
            UC_Khachhang uC_Khachhang = new UC_Khachhang();
            addUC(uC_Khachhang);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            DichuyenPanle(btnDangnhap);
            UC_Main uC_Main = new UC_Main();
            addUC(uC_Main);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FormDangnhap formDangnhap = new FormDangnhap();
            formDangnhap.Show();
            this.Hide();


        }


        private void timer_Trangchu(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:MM:ss");
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            DichuyenPanle(btnThongke);
            UC_Thongke uC_Thongke = new UC_Thongke();
            addUC(uC_Thongke);
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            DichuyenPanle(btnNhanvien);
            UC_Quanlynhanvien uC_Quanlynhanvien = new UC_Quanlynhanvien();
            addUC(uC_Quanlynhanvien);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            DichuyenPanle(btnBanHang);
            UC_Banhang uC_Banhang = new UC_Banhang();
            addUC(uC_Banhang);
        }
    }
}
