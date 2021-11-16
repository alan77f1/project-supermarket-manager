
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnKhoHang = new System.Windows.Forms.Button();
            this.panelDichuyen = new System.Windows.Forms.Panel();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbNguoiDung = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLeft.Controls.Add(this.btnThongKe);
            this.panelLeft.Controls.Add(this.btnKhoHang);
            this.panelLeft.Controls.Add(this.panelDichuyen);
            this.panelLeft.Controls.Add(this.btnNhanVien);
            this.panelLeft.Controls.Add(this.btnTrangChu);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Controls.Add(this.btnDangXuat);
            this.panelLeft.Controls.Add(this.btnBanHang);
            this.panelLeft.Controls.Add(this.btnNCC);
            this.panelLeft.Controls.Add(this.btnKhachHang);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(290, 742);
            this.panelLeft.TabIndex = 3;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Snow;
            this.btnThongKe.Image = global::WindowsFormsApp.Properties.Resources.ThongKe;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(37, 553);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(210, 58);
            this.btnThongKe.TabIndex = 27;
            this.btnThongKe.Text = "  Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnKhoHang
            // 
            this.btnKhoHang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKhoHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoHang.FlatAppearance.BorderSize = 0;
            this.btnKhoHang.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnKhoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoHang.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoHang.ForeColor = System.Drawing.Color.Snow;
            this.btnKhoHang.Image = global::WindowsFormsApp.Properties.Resources.KhoHang;
            this.btnKhoHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoHang.Location = new System.Drawing.Point(37, 472);
            this.btnKhoHang.Name = "btnKhoHang";
            this.btnKhoHang.Size = new System.Drawing.Size(210, 58);
            this.btnKhoHang.TabIndex = 26;
            this.btnKhoHang.Text = "  Kho hàng";
            this.btnKhoHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhoHang.UseVisualStyleBackColor = false;
            this.btnKhoHang.Click += new System.EventHandler(this.btnKhoHang_Click);
            // 
            // panelDichuyen
            // 
            this.panelDichuyen.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelDichuyen.Location = new System.Drawing.Point(12, 161);
            this.panelDichuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDichuyen.Name = "panelDichuyen";
            this.panelDichuyen.Size = new System.Drawing.Size(10, 58);
            this.panelDichuyen.TabIndex = 0;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Snow;
            this.btnNhanVien.Image = global::WindowsFormsApp.Properties.Resources.NhanVien;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(37, 391);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(210, 58);
            this.btnNhanVien.TabIndex = 25;
            this.btnNhanVien.Text = "  Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.Snow;
            this.btnTrangChu.Image = global::WindowsFormsApp.Properties.Resources.home_icon;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(37, 161);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(210, 58);
            this.btnTrangChu.TabIndex = 19;
            this.btnTrangChu.Text = " Trang chủ";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 153);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 92);
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
            this.label1.Location = new System.Drawing.Point(38, 37);
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
            this.label5.Location = new System.Drawing.Point(118, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 43);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mart";
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
            this.btnDangXuat.Location = new System.Drawing.Point(37, 730);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(210, 58);
            this.btnDangXuat.TabIndex = 10;
            this.btnDangXuat.Text = "   Đăng Xuất";
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
            this.btnBanHang.Location = new System.Drawing.Point(37, 317);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(210, 58);
            this.btnBanHang.TabIndex = 3;
            this.btnBanHang.Text = "  Bán Hàng";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
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
            this.btnKhachHang.Location = new System.Drawing.Point(37, 239);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(210, 58);
            this.btnKhachHang.TabIndex = 4;
            this.btnKhachHang.Text = " Khách Hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(805, 30);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // lbNguoiDung
            // 
            this.lbNguoiDung.AutoSize = true;
            this.lbNguoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiDung.ForeColor = System.Drawing.Color.Black;
            this.lbNguoiDung.Location = new System.Drawing.Point(861, 30);
            this.lbNguoiDung.Name = "lbNguoiDung";
            this.lbNguoiDung.Size = new System.Drawing.Size(64, 22);
            this.lbNguoiDung.TabIndex = 22;
            this.lbNguoiDung.Text = "chi123";
            this.lbNguoiDung.Click += new System.EventHandler(this.lbNguoiDung_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(49, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Black;
            this.lbTime.Location = new System.Drawing.Point(99, 28);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(99, 20);
            this.lbTime.TabIndex = 25;
            this.lbTime.Text = "HH:MM:ss";
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
            this.btnX.Location = new System.Drawing.Point(943, 19);
            this.btnX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnX.Name = "btnX";
            this.btnX.Padding = new System.Windows.Forms.Padding(1);
            this.btnX.Size = new System.Drawing.Size(49, 49);
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
            // panelControl
            // 
            this.panelControl.Location = new System.Drawing.Point(290, 80);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1010, 662);
            this.panelControl.TabIndex = 5;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.pictureBox3);
            this.panelRight.Controls.Add(this.lbNguoiDung);
            this.panelRight.Controls.Add(this.btnX);
            this.panelRight.Controls.Add(this.lbTime);
            this.panelRight.Controls.Add(this.pictureBox2);
            this.panelRight.Location = new System.Drawing.Point(296, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1010, 80);
            this.panelRight.TabIndex = 0;
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 742);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTrangchu";
            this.panelLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelDichuyen;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnKhoHang;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lbNguoiDung;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelRight;
    }
}