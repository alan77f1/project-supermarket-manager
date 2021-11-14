using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.DAO
{
    class QuanLyMatHang
    {
        private static QuanLyMatHang instance;

        public QuanLyMatHang()
        {
        }

        public static QuanLyMatHang Intance
        {
            get { if (instance == null) instance = new QuanLyMatHang(); return instance; }
            set => instance = value;
        }

        public List<Models.MatHang> getListSanPham()
        {
            List<Models.MatHang> list = new List<Models.MatHang>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from MatHang");
            foreach (DataRow item in data.Rows)
            {
                Models.MatHang mathang = new Models.MatHang(item);
                list.Add(mathang);
            }
            return list;
        }
    }
}
