﻿using System;
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
    public partial class FormXacNhanOTP : Form
    {
        public FormXacNhanOTP()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTiepTuc_Click_1(object sender, EventArgs e)
        {
            FormMatKhauMoi f = new FormMatKhauMoi();
            f.Show();
            this.Hide();
        }
    }
}
