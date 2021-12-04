using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Models;
using WindowsFormsApp.Controller;
using System.Data;

namespace WindowsFormsApp.Views
{
    public class MatHangBUS
    {
        private static MatHangBUS instance;

        public MatHangBUS()
        {
        }

        public static MatHangBUS Intance
        {
            get { if (instance == null) instance = new MatHangBUS(); return instance; }
            set => instance = value;
        }

        public bool temHH(MatHang data, string imgLocation)
        {
            return MatHangDAO.Intance.temHH(data, imgLocation);
        }

        public void capNhatHinh(string imgLocation, string maHang)
        {
            MatHangDAO.Intance.capNhatHinh(imgLocation, maHang);
        }

        public byte[] getAnhByID(string ID)
        {
            return MatHangDAO.Intance.getAnhByID(ID);
        }

        public List<MatHang> getListSanPham()
        {
            return MatHangDAO.Intance.getListSanPham();
        }

        public MatHang getSP(string maSP)
        {
            return MatHangDAO.Intance.getSP(maSP);
        }

        public bool suaHH(string MaHang, string TenHH, int SoLuong, int GiaBan)
        {
            return MatHangDAO.Intance.suaHH(MaHang, TenHH, SoLuong, GiaBan);
        }

        public bool kiemtraXoa(string maHang)
        {
            return MatHangDAO.Intance.kiemtraXoa(maHang);
        }

        public bool capNhatHH(string maHang, int SL, int DonGia)
        {
            return MatHangDAO.Intance.capNhatHH(maHang, SL, DonGia);
        }

        public bool xoaHang(string maKH)
        {
            return MatHangDAO.Intance.xoaHang(maKH);
        }

        public string loadMaHH()
        {
            return MatHangDAO.Intance.loadMaHH();
        }

        public DataTable TimKiemHH(string maPN)
        {
            return MatHangDAO.Intance.TimKiemHH(maPN);
        }
    }
}
