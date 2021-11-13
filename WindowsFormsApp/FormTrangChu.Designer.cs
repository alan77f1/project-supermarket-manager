
namespace QuanLySieuThi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDichuyen = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNCC = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTaikhoan = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTrangchu = new System.Windows.Forms.Panel();
            this.timertTrangchu = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnThongke = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnThongke);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panelDichuyen);
            this.panel1.Controls.Add(this.btnNhanvien);
            this.panel1.Controls.Add(this.btnDangnhap);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnBanHang);
            this.panel1.Controls.Add(this.btnNCC);
            this.panel1.Controls.Add(this.btnKhachHang);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 750);
            this.panel1.TabIndex = 19;
            // 
            // panelDichuyen
            // 
            this.panelDichuyen.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelDichuyen.Location = new System.Drawing.Point(3, 146);
            this.panelDichuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDichuyen.Name = "panelDichuyen";
            this.panelDichuyen.Size = new System.Drawing.Size(10, 58);
            this.panelDichuyen.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 140);
            this.panel2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Bạn của mọi nhà";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 43);
            this.label1.TabIndex = 20;
            this.label1.Text = "Coop.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(105, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 43);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mart";
            // 
            // btnNCC
            // 
            this.btnNCC.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNCC.FlatAppearance.BorderSize = 0;
            this.btnNCC.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCC.Font = new System.Drawing.Font("Sitka Banner", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.ForeColor = System.Drawing.Color.White;
            this.btnNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.Location = new System.Drawing.Point(22, 530);
            this.btnNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Padding = new System.Windows.Forms.Padding(1);
            this.btnNCC.Size = new System.Drawing.Size(0, 0);
            this.btnNCC.TabIndex = 7;
            this.btnNCC.Text = "   Nhà C.Cấp";
            this.btnNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNCC.UseVisualStyleBackColor = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guna2Panel1.Controls.Add(this.pictureBox3);
            this.guna2Panel1.Controls.Add(this.lblTaikhoan);
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.lblTime);
            this.guna2Panel1.Controls.Add(this.btnX);
            this.guna2Panel1.Location = new System.Drawing.Point(233, 2);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(964, 72);
            this.guna2Panel1.TabIndex = 20;
            // 
            // lblTaikhoan
            // 
            this.lblTaikhoan.AutoSize = true;
            this.lblTaikhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaikhoan.ForeColor = System.Drawing.Color.Black;
            this.lblTaikhoan.Location = new System.Drawing.Point(808, 21);
            this.lblTaikhoan.Name = "lblTaikhoan";
            this.lblTaikhoan.Size = new System.Drawing.Size(64, 22);
            this.lblTaikhoan.TabIndex = 22;
            this.lblTaikhoan.Text = "chi123";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(70, 28);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(99, 20);
            this.lblTime.TabIndex = 25;
            this.lblTime.Text = "HH:MM:ss";
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Sitka Banner", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.Location = new System.Drawing.Point(893, 9);
            this.btnX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnX.Name = "btnX";
            this.btnX.Padding = new System.Windows.Forms.Padding(1);
            this.btnX.Size = new System.Drawing.Size(49, 41);
            this.btnX.TabIndex = 19;
            this.btnX.Text = "X";
            this.btnX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(1554, 918);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 11);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlTrangchu
            // 
            this.pnlTrangchu.Location = new System.Drawing.Point(233, 78);
            this.pnlTrangchu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTrangchu.Name = "pnlTrangchu";
            this.pnlTrangchu.Size = new System.Drawing.Size(964, 674);
            this.pnlTrangchu.TabIndex = 22;
            // 
            // timertTrangchu
            // 
            this.timertTrangchu.Tick += new System.EventHandler(this.timer_Trangchu);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(760, 20);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(21, 17);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongke.FlatAppearance.BorderSize = 0;
            this.btnThongke.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnThongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongke.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.ForeColor = System.Drawing.Color.Snow;
            this.btnThongke.Image = global::WindowsFormsApp.Properties.Resources.ThongKe;
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.Location = new System.Drawing.Point(21, 513);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Padding = new System.Windows.Forms.Padding(1);
            this.btnThongke.Size = new System.Drawing.Size(193, 58);
            this.btnThongke.TabIndex = 27;
            this.btnThongke.Text = "  Thống kê";
            this.btnThongke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Image = global::WindowsFormsApp.Properties.Resources.KhoHang;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(21, 439);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(1);
            this.button2.Size = new System.Drawing.Size(193, 58);
            this.button2.TabIndex = 26;
            this.button2.Text = "  Kho hàng";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNhanvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanvien.FlatAppearance.BorderSize = 0;
            this.btnNhanvien.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnNhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanvien.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanvien.ForeColor = System.Drawing.Color.Snow;
            this.btnNhanvien.Image = global::WindowsFormsApp.Properties.Resources.NhanVien;
            this.btnNhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.Location = new System.Drawing.Point(21, 361);
            this.btnNhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Padding = new System.Windows.Forms.Padding(1);
            this.btnNhanvien.Size = new System.Drawing.Size(193, 58);
            this.btnNhanvien.TabIndex = 25;
            this.btnNhanvien.Text = "  Nhân viên";
            this.btnNhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanvien.UseVisualStyleBackColor = false;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangnhap.FlatAppearance.BorderSize = 0;
            this.btnDangnhap.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangnhap.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.ForeColor = System.Drawing.Color.Snow;
            this.btnDangnhap.Image = global::WindowsFormsApp.Properties.Resources.home_icon;
            this.btnDangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangnhap.Location = new System.Drawing.Point(21, 146);
            this.btnDangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Padding = new System.Windows.Forms.Padding(1);
            this.btnDangnhap.Size = new System.Drawing.Size(193, 58);
            this.btnDangnhap.TabIndex = 19;
            this.btnDangnhap.Text = "  Trang chủ";
            this.btnDangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangnhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(103, -9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Snow;
            this.btnDangXuat.Image = global::WindowsFormsApp.Properties.Resources.DangXuat;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(21, 663);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(1);
            this.btnDangXuat.Size = new System.Drawing.Size(193, 58);
            this.btnDangXuat.TabIndex = 10;
            this.btnDangXuat.Text = "   Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.ForeColor = System.Drawing.Color.Snow;
            this.btnBanHang.Image = global::WindowsFormsApp.Properties.Resources.BanHang;
            this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.Location = new System.Drawing.Point(21, 289);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Padding = new System.Windows.Forms.Padding(1);
            this.btnBanHang.Size = new System.Drawing.Size(193, 58);
            this.btnBanHang.TabIndex = 3;
            this.btnBanHang.Text = "  Bán Hàng";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.Snow;
            this.btnKhachHang.Image = global::WindowsFormsApp.Properties.Resources.KhachHang;
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(21, 218);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(1);
            this.btnKhachHang.Size = new System.Drawing.Size(193, 58);
            this.btnKhachHang.TabIndex = 4;
            this.btnKhachHang.Text = "   Khách Hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.pnlTrangchu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTrangchu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnKhachHang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Panel pnlTrangchu;
        private System.Windows.Forms.Panel panelDichuyen;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timertTrangchu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Label lblTaikhoan;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}