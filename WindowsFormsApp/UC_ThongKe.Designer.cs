﻿
namespace WindowsFormsApp
{
    partial class UC_ThongKe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlTK = new System.Windows.Forms.Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbLuaChon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();
            this.dpkNgaykt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpkNgaybd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHanghoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnKhachhang = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnHoadon = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnphieunhap = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTk = new System.Windows.Forms.Label();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlTK.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTK
            // 
            this.pnlTK.BackColor = System.Drawing.Color.White;
            this.pnlTK.Controls.Add(this.btnSua);
            this.pnlTK.Controls.Add(this.btnXoa);
            this.pnlTK.Controls.Add(this.btnThem);
            this.pnlTK.Controls.Add(this.guna2Panel3);
            this.pnlTK.Controls.Add(this.cmbLuaChon);
            this.pnlTK.Controls.Add(this.label3);
            this.pnlTK.Controls.Add(this.btnXem);
            this.pnlTK.Controls.Add(this.dpkNgaykt);
            this.pnlTK.Controls.Add(this.label4);
            this.pnlTK.Controls.Add(this.label2);
            this.pnlTK.Controls.Add(this.dpkNgaybd);
            this.pnlTK.Controls.Add(this.label1);
            this.pnlTK.Controls.Add(this.panel2);
            this.pnlTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTK.Location = new System.Drawing.Point(0, 0);
            this.pnlTK.Name = "pnlTK";
            this.pnlTK.Size = new System.Drawing.Size(1234, 834);
            this.pnlTK.TabIndex = 25;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.chart1);
            this.guna2Panel3.Location = new System.Drawing.Point(21, 204);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(1198, 615);
            this.guna2Panel3.TabIndex = 241;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.LabelBorderWidth = 3;
            series1.Legend = "Legend1";
            series1.Name = "Doanh Thu";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1170, 594);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            // 
            // cmbLuaChon
            // 
            this.cmbLuaChon.BackColor = System.Drawing.Color.Transparent;
            this.cmbLuaChon.BorderColor = System.Drawing.Color.Black;
            this.cmbLuaChon.BorderRadius = 3;
            this.cmbLuaChon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLuaChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLuaChon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLuaChon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLuaChon.FocusedState.Parent = this.cmbLuaChon;
            this.cmbLuaChon.Font = new System.Drawing.Font("Cambria", 10F);
            this.cmbLuaChon.ForeColor = System.Drawing.Color.Black;
            this.cmbLuaChon.HoverState.Parent = this.cmbLuaChon;
            this.cmbLuaChon.ItemHeight = 30;
            this.cmbLuaChon.Items.AddRange(new object[] {
            "--- Lựa chọn xem ---",
            "Hôm qua",
            "Hôm nay",
            "Tuần này",
            "Tháng này",
            "Năm nay"});
            this.cmbLuaChon.ItemsAppearance.Parent = this.cmbLuaChon;
            this.cmbLuaChon.Location = new System.Drawing.Point(897, 148);
            this.cmbLuaChon.Name = "cmbLuaChon";
            this.cmbLuaChon.ShadowDecoration.Parent = this.cmbLuaChon;
            this.cmbLuaChon.Size = new System.Drawing.Size(233, 36);
            this.cmbLuaChon.TabIndex = 240;
            this.cmbLuaChon.SelectedIndexChanged += new System.EventHandler(this.cmbLuaChon_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(751, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 239;
            this.label3.Text = "Lựa chọn xem:";
            // 
            // btnXem
            // 
            this.btnXem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.btnXem.BorderRadius = 1;
            this.btnXem.BorderThickness = 1;
            this.btnXem.CheckedState.Parent = this.btnXem;
            this.btnXem.CustomImages.Parent = this.btnXem;
            this.btnXem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXem.DisabledState.Parent = this.btnXem;
            this.btnXem.FillColor = System.Drawing.Color.White;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.Black;
            this.btnXem.HoverState.Parent = this.btnXem;
            this.btnXem.Location = new System.Drawing.Point(606, 149);
            this.btnXem.Name = "btnXem";
            this.btnXem.ShadowDecoration.Parent = this.btnXem;
            this.btnXem.Size = new System.Drawing.Size(124, 36);
            this.btnXem.TabIndex = 33;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dpkNgaykt
            // 
            this.dpkNgaykt.BorderRadius = 3;
            this.dpkNgaykt.BorderThickness = 1;
            this.dpkNgaykt.CheckedState.Parent = this.dpkNgaykt;
            this.dpkNgaykt.FillColor = System.Drawing.Color.White;
            this.dpkNgaykt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpkNgaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkNgaykt.HoverState.Parent = this.dpkNgaykt;
            this.dpkNgaykt.Location = new System.Drawing.Point(370, 144);
            this.dpkNgaykt.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpkNgaykt.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpkNgaykt.Name = "dpkNgaykt";
            this.dpkNgaykt.ShadowDecoration.Parent = this.dpkNgaykt;
            this.dpkNgaykt.Size = new System.Drawing.Size(228, 36);
            this.dpkNgaykt.TabIndex = 21;
            this.dpkNgaykt.Value = new System.DateTime(2021, 12, 9, 19, 36, 10, 687);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Từ ngày";
            // 
            // dpkNgaybd
            // 
            this.dpkNgaybd.BorderRadius = 3;
            this.dpkNgaybd.BorderThickness = 1;
            this.dpkNgaybd.CheckedState.Parent = this.dpkNgaybd;
            this.dpkNgaybd.FillColor = System.Drawing.Color.White;
            this.dpkNgaybd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpkNgaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkNgaybd.HoverState.Parent = this.dpkNgaybd;
            this.dpkNgaybd.Location = new System.Drawing.Point(110, 148);
            this.dpkNgaybd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpkNgaybd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpkNgaybd.Name = "dpkNgaybd";
            this.dpkNgaybd.ShadowDecoration.Parent = this.dpkNgaybd;
            this.dpkNgaybd.Size = new System.Drawing.Size(220, 36);
            this.dpkNgaybd.TabIndex = 18;
            this.dpkNgaybd.Value = new System.DateTime(2021, 12, 9, 19, 36, 10, 687);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "TỔNG QUAN BÁO CÁO\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnHanghoa);
            this.panel2.Controls.Add(this.btnKhachhang);
            this.panel2.Controls.Add(this.btnHoadon);
            this.panel2.Controls.Add(this.btnphieunhap);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.lblTk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 50);
            this.panel2.TabIndex = 16;
            // 
            // btnHanghoa
            // 
            this.btnHanghoa.AutoRoundedCorners = true;
            this.btnHanghoa.BorderRadius = 21;
            this.btnHanghoa.CheckedState.Parent = this.btnHanghoa;
            this.btnHanghoa.CustomImages.Parent = this.btnHanghoa;
            this.btnHanghoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHanghoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHanghoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHanghoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHanghoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHanghoa.DisabledState.Parent = this.btnHanghoa;
            this.btnHanghoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnHanghoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnHanghoa.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHanghoa.ForeColor = System.Drawing.Color.White;
            this.btnHanghoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(254)))));
            this.btnHanghoa.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnHanghoa.HoverState.Parent = this.btnHanghoa;
            this.btnHanghoa.Location = new System.Drawing.Point(140, 3);
            this.btnHanghoa.Name = "btnHanghoa";
            this.btnHanghoa.ShadowDecoration.Parent = this.btnHanghoa;
            this.btnHanghoa.Size = new System.Drawing.Size(142, 44);
            this.btnHanghoa.TabIndex = 250;
            this.btnHanghoa.Text = "Hàng hóa";
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.AutoRoundedCorners = true;
            this.btnKhachhang.BorderRadius = 21;
            this.btnKhachhang.CheckedState.Parent = this.btnKhachhang;
            this.btnKhachhang.CustomImages.Parent = this.btnKhachhang;
            this.btnKhachhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhachhang.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhachhang.DisabledState.Parent = this.btnKhachhang;
            this.btnKhachhang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnKhachhang.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnKhachhang.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachhang.ForeColor = System.Drawing.Color.White;
            this.btnKhachhang.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(254)))));
            this.btnKhachhang.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnKhachhang.HoverState.Parent = this.btnKhachhang;
            this.btnKhachhang.Location = new System.Drawing.Point(297, 3);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.ShadowDecoration.Parent = this.btnKhachhang;
            this.btnKhachhang.Size = new System.Drawing.Size(142, 44);
            this.btnKhachhang.TabIndex = 249;
            this.btnKhachhang.Text = "Khách hàng";
            // 
            // btnHoadon
            // 
            this.btnHoadon.AutoRoundedCorners = true;
            this.btnHoadon.BorderRadius = 21;
            this.btnHoadon.CheckedState.Parent = this.btnHoadon;
            this.btnHoadon.CustomImages.Parent = this.btnHoadon;
            this.btnHoadon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoadon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoadon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoadon.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoadon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoadon.DisabledState.Parent = this.btnHoadon;
            this.btnHoadon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnHoadon.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnHoadon.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadon.ForeColor = System.Drawing.Color.White;
            this.btnHoadon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(254)))));
            this.btnHoadon.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnHoadon.HoverState.Parent = this.btnHoadon;
            this.btnHoadon.Location = new System.Drawing.Point(456, 3);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.ShadowDecoration.Parent = this.btnHoadon;
            this.btnHoadon.Size = new System.Drawing.Size(142, 44);
            this.btnHoadon.TabIndex = 248;
            this.btnHoadon.Text = "Hóa đơn";
            // 
            // btnphieunhap
            // 
            this.btnphieunhap.AutoRoundedCorners = true;
            this.btnphieunhap.BorderRadius = 21;
            this.btnphieunhap.CheckedState.Parent = this.btnphieunhap;
            this.btnphieunhap.CustomImages.Parent = this.btnphieunhap;
            this.btnphieunhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnphieunhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnphieunhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnphieunhap.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnphieunhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnphieunhap.DisabledState.Parent = this.btnphieunhap;
            this.btnphieunhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnphieunhap.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnphieunhap.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphieunhap.ForeColor = System.Drawing.Color.White;
            this.btnphieunhap.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(254)))));
            this.btnphieunhap.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnphieunhap.HoverState.Parent = this.btnphieunhap;
            this.btnphieunhap.Location = new System.Drawing.Point(621, 3);
            this.btnphieunhap.Name = "btnphieunhap";
            this.btnphieunhap.ShadowDecoration.Parent = this.btnphieunhap;
            this.btnphieunhap.Size = new System.Drawing.Size(142, 44);
            this.btnphieunhap.TabIndex = 247;
            this.btnphieunhap.Text = "Phiếu nhập";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(3, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1570, 1);
            this.panel6.TabIndex = 242;
            // 
            // lblTk
            // 
            this.lblTk.AutoSize = true;
            this.lblTk.Font = new System.Drawing.Font("Sitka Banner", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTk.Location = new System.Drawing.Point(15, 12);
            this.lblTk.Name = "lblTk";
            this.lblTk.Size = new System.Drawing.Size(100, 32);
            this.lblTk.TabIndex = 14;
            this.lblTk.Text = "Thống kê";
            // 
            // btnSua
            // 
            this.btnSua.Animated = true;
            this.btnSua.AutoRoundedCorners = true;
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BorderRadius = 26;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.DisabledState.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnSua.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSua.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(1)))), ((int)(((byte)(139)))));
            this.btnSua.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Location = new System.Drawing.Point(538, 53);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(159, 55);
            this.btnSua.TabIndex = 357;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseTransparentBackground = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Animated = true;
            this.btnXoa.AutoRoundedCorners = true;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderRadius = 26;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.DisabledState.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnXoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(1)))), ((int)(((byte)(139)))));
            this.btnXoa.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(364, 53);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(159, 55);
            this.btnXoa.TabIndex = 356;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseTransparentBackground = true;
            // 
            // btnThem
            // 
            this.btnThem.Animated = true;
            this.btnThem.AutoRoundedCorners = true;
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BorderRadius = 26;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.DisabledState.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnThem.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(1)))), ((int)(((byte)(139)))));
            this.btnThem.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(190, 53);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(159, 55);
            this.btnThem.TabIndex = 355;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseTransparentBackground = true;
            // 
            // UC_ThongKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlTK);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(1234, 834);
            this.pnlTK.ResumeLayout(false);
            this.pnlTK.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTk;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpkNgaykt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnXem;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpkNgaybd;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLuaChon;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2GradientButton btnHoadon;
        private Guna.UI2.WinForms.Guna2GradientButton btnphieunhap;
        private Guna.UI2.WinForms.Guna2GradientButton btnHanghoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnKhachhang;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
    }
}
