﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class UC_ReportHangTon : UserControl
    {

        
        public UC_ReportHangTon()
        {
            InitializeComponent();
            Load();
            
            
        }

        private void Load()
        {
            Chuoiketnoi chuoiketnoi = new Chuoiketnoi();

            SqlConnection con = chuoiketnoi.sqlConnection();
            con.Open();
            string query = "select * from MatHang";
            string query1 = "select MatHang.MaMH,TenMH,TenDVT,GiaBan,MatHang.SoLuong, sum(ChitietPN.Soluong) as [SLNhap], (sum(ChitietPN.Soluong) - MatHang.SoLuong) as [SLBan] from MatHang inner join ChiTietPN on MatHang.MaMH = ChiTietPN.MaMH inner join DonViTinh on MatHang.MaDVT = DonViTinh.MaDVT group by MatHang.MaMH,MatHang.SoLuong,MatHang.TenMH,TenDVT,MatHang.GiaBan";
            SqlDataAdapter dta = new SqlDataAdapter(query1, con);
            DataSet1 dataSet1 = new DataSet1();
            dta.Fill(dataSet1, "DataTable3");
            ReportDataSource dataSource = new ReportDataSource("DataSet1", dataSet1.Tables[2]);
            con.Close();
           
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.SetDisplayMode(DisplayMode.Normal);
        }



        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            UC_ThongKeHangHoa f = new UC_ThongKeHangHoa();
            addUC(f);
        }
    }
}
