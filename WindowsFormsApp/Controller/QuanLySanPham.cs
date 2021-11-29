using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Controller
{
    class QuanLySanPham
    {
        private static QuanLySanPham instance;

        public QuanLySanPham()
        {
        }

        public static QuanLySanPham Intance
        {
            get { if (instance == null) instance = new QuanLySanPham(); return instance; }
            set => instance = value;
        }

    }
}
