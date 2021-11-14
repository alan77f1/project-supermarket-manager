using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class UC_KhoHang : UserControl
    {
        public UC_KhoHang()
        {
            InitializeComponent();
        }



        private void btnThemMatHangMoi_Click(object sender, EventArgs e)
        {
            FormThemSanPham tmsp = new FormThemSanPham();
            tmsp.ShowDialog();
        }

        private void btnThemDVT_Click(object sender, EventArgs e)
        {
            FormDonViTinh tdvt = new FormDonViTinh();
            tdvt.ShowDialog();
        }

       
    }
}
