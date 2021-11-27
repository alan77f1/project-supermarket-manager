namespace WindowsFormsApp
{
    partial class FormTrangChu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelRight = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTennv = new System.Windows.Forms.Label();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblManv = new System.Windows.Forms.Label();
            this.lblNguoidung = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lbNguoiDung = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlX = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panelDiChuyen = new System.Windows.Forms.Panel();
            this.pannelLeft1 = new System.Windows.Forms.Panel();
            this.btnNCC = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnKhoHang = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelRight.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.pannelLeft1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(66)))));
            this.panelRight.Controls.Add(this.panel2);
            this.panelRight.Controls.Add(this.lbNguoiDung);
            this.panelRight.Controls.Add(this.panel1);
            this.panelRight.Controls.Add(this.controlX);
            this.panelRight.Controls.Add(this.lbTime);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRight.Location = new System.Drawing.Point(216, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(984, 66);
            this.panelRight.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.lblTennv);
            this.panel2.Controls.Add(this.lblQuyen);
            this.panel2.Controls.Add(this.lblManv);
            this.panel2.Controls.Add(this.lblNguoidung);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.guna2ControlBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 66);
            this.panel2.TabIndex = 7;
            // 
            // lblTennv
            // 
            this.lblTennv.AutoSize = true;
            this.lblTennv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTennv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.lblTennv.Location = new System.Drawing.Point(415, 21);
            this.lblTennv.Name = "lblTennv";
            this.lblTennv.Size = new System.Drawing.Size(64, 22);
            this.lblTennv.TabIndex = 29;
            this.lblTennv.Text = "chi123";
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.lblQuyen.Location = new System.Drawing.Point(621, 18);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(96, 25);
            this.lblQuyen.TabIndex = 4;
            this.lblQuyen.Text = "Miễn Phí";
            // 
            // lblManv
            // 
            this.lblManv.AutoSize = true;
            this.lblManv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.lblManv.Location = new System.Drawing.Point(415, 21);
            this.lblManv.Name = "lblManv";
            this.lblManv.Size = new System.Drawing.Size(64, 22);
            this.lblManv.TabIndex = 30;
            this.lblManv.Text = "chi123";
            // 
            // lblNguoidung
            // 
            this.lblNguoidung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNguoidung.AutoSize = true;
            this.lblNguoidung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNguoidung.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblNguoidung.ForeColor = System.Drawing.Color.White;
            this.lblNguoidung.Location = new System.Drawing.Point(823, 18);
            this.lblNguoidung.Name = "lblNguoidung";
            this.lblNguoidung.Size = new System.Drawing.Size(92, 29);
            this.lblNguoidung.TabIndex = 6;
            this.lblNguoidung.Text = "ADMIN";
            this.lblNguoidung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNguoidung.Click += new System.EventHandler(this.lblNguoidung_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(758, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(45, 37);
            this.panel3.TabIndex = 5;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Teal;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(939, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 66);
            this.guna2ControlBox1.TabIndex = 4;
            // 
            // lbNguoiDung
            // 
            this.lbNguoiDung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNguoiDung.AutoSize = true;
            this.lbNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNguoiDung.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lbNguoiDung.ForeColor = System.Drawing.Color.White;
            this.lbNguoiDung.Location = new System.Drawing.Point(844, 18);
            this.lbNguoiDung.Name = "lbNguoiDung";
            this.lbNguoiDung.Size = new System.Drawing.Size(92, 29);
            this.lbNguoiDung.TabIndex = 6;
            this.lbNguoiDung.Text = "ADMIN";
            this.lbNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(788, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 37);
            this.panel1.TabIndex = 5;
            // 
            // controlX
            // 
            this.controlX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.controlX.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.controlX.HoverState.FillColor = System.Drawing.Color.Teal;
            this.controlX.HoverState.Parent = this.controlX;
            this.controlX.IconColor = System.Drawing.Color.White;
            this.controlX.Location = new System.Drawing.Point(939, 0);
            this.controlX.Name = "controlX";
            this.controlX.ShadowDecoration.Parent = this.controlX;
            this.controlX.Size = new System.Drawing.Size(45, 66);
            this.controlX.TabIndex = 4;
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(6, 3);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(226, 49);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "HH:MM:SS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Pacifico", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(18, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 56);
            this.label11.TabIndex = 3;
            this.label11.Text = "Co.op";
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.panelLeft.Controls.Add(this.bunifuThinButton21);
            this.panelLeft.Controls.Add(this.label16);
            this.panelLeft.Controls.Add(this.btnDangXuat);
            this.panelLeft.Controls.Add(this.label17);
            this.panelLeft.Controls.Add(this.panelDiChuyen);
            this.panelLeft.Controls.Add(this.pannelLeft1);
            this.panelLeft.Controls.Add(this.btnKhoHang);
            this.panelLeft.Controls.Add(this.btnNCC);
            this.panelLeft.Controls.Add(this.btnThongKe);
            this.panelLeft.Controls.Add(this.btnNhanVien);
            this.panelLeft.Controls.Add(this.btnKhachHang);
            this.panelLeft.Controls.Add(this.btnBanHang);
            this.panelLeft.Controls.Add(this.btnTrangChu);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(216, 760);
            this.panelLeft.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Chaparral Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(25, 733);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 18);
            this.label17.TabIndex = 4;
            this.label17.Text = "Liên hệ : 0123456789";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Chaparral Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(-3, 696);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(203, 18);
            this.label16.TabIndex = 4;
            this.label16.Text = "72 Tăng Phú , Quận 9, TP. HCM";
            // 
            // panelDiChuyen
            // 
            this.panelDiChuyen.BackColor = System.Drawing.Color.White;
            this.panelDiChuyen.Location = new System.Drawing.Point(0, 68);
            this.panelDiChuyen.Name = "panelDiChuyen";
            this.panelDiChuyen.Size = new System.Drawing.Size(10, 54);
            this.panelDiChuyen.TabIndex = 2;
            // 
            // pannelLeft1
            // 
            this.pannelLeft1.BackColor = System.Drawing.Color.White;
            this.pannelLeft1.Controls.Add(this.label1);
            this.pannelLeft1.Controls.Add(this.label11);
            this.pannelLeft1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pannelLeft1.Location = new System.Drawing.Point(0, 0);
            this.pannelLeft1.Name = "pannelLeft1";
            this.pannelLeft1.Size = new System.Drawing.Size(216, 66);
            this.pannelLeft1.TabIndex = 0;
            // 
            // btnNCC
            // 
            this.btnNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNCC.FlatAppearance.BorderSize = 0;
            this.btnNCC.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCC.Font = new System.Drawing.Font("Nunito", 13.2F);
            this.btnNCC.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.Location = new System.Drawing.Point(16, 406);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(194, 50);
            this.btnNCC.TabIndex = 1;
            this.btnNCC.Text = " Nhà C.Cấp";
            this.btnNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNCC.UseVisualStyleBackColor = true;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(216, 66);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(984, 694);
            this.panelControl.TabIndex = 5;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(16, 601);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(194, 50);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "   Đăng Xuất";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnKhoHang
            // 
            this.btnKhoHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoHang.FlatAppearance.BorderSize = 0;
            this.btnKhoHang.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnKhoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoHang.Font = new System.Drawing.Font("Nunito", 13.2F);
            this.btnKhoHang.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnKhoHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoHang.Image")));
            this.btnKhoHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoHang.Location = new System.Drawing.Point(16, 485);
            this.btnKhoHang.Name = "btnKhoHang";
            this.btnKhoHang.Size = new System.Drawing.Size(194, 50);
            this.btnKhoHang.TabIndex = 1;
            this.btnKhoHang.Text = " Kho Hàng";
            this.btnKhoHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhoHang.UseVisualStyleBackColor = true;
            this.btnKhoHang.Click += new System.EventHandler(this.btnKhoHang_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Nunito", 13.2F);
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(16, 338);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(194, 50);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = " Thống Kê";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Nunito", 13.2F);
            this.btnNhanVien.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(19, 270);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(194, 50);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = " Nhân Viên";
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click_1);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Nunito", 13.2F);
            this.btnKhachHang.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Image")));
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(16, 139);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(194, 50);
            this.btnKhachHang.TabIndex = 1;
            this.btnKhachHang.Text = " Khách Hàng";
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Nunito", 13.2F);
            this.btnBanHang.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBanHang.Image = ((System.Drawing.Image)(resources.GetObject("btnBanHang.Image")));
            this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.Location = new System.Drawing.Point(16, 204);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(194, 50);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.Text = " Bán Hàng";
            this.btnBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangChu.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Nunito", 13.2F);
            this.btnTrangChu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(19, 72);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(194, 50);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = " Trang Chủ";
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Pacifico", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(115, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "mart";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.bunifuThinButton21.ButtonText = "ThinButton";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(205, 315);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 6;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTrangChu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.pannelLeft1.ResumeLayout(false);
            this.pannelLeft1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panelDiChuyen;
        private System.Windows.Forms.Panel pannelLeft1;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnTrangChu;
        private Guna.UI2.WinForms.Guna2ControlBox controlX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKhoHang;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lbNguoiDung;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTennv;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.Label lblManv;
        private System.Windows.Forms.Label lblNguoidung;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}