
namespace WindowsFormsApp
{
    partial class FormNhapHang
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
            this.label12 = new System.Windows.Forms.Label();
            this.lblMapn = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lsvNhaphang = new System.Windows.Forms.ListView();
            this.lbltong = new System.Windows.Forms.Label();
            this.lbltensp = new System.Windows.Forms.Label();
            this.lblmasp = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTensp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.dtpkNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMancc = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTenncc = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbTenncc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSĐT = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblManv = new System.Windows.Forms.Label();
            this.lblTennv = new System.Windows.Forms.Label();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1204, 896);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 40);
            this.label12.TabIndex = 64;
            this.label12.Text = "Tổng:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblMapn
            // 
            this.lblMapn.AutoSize = true;
            this.lblMapn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMapn.Location = new System.Drawing.Point(226, 105);
            this.lblMapn.Name = "lblMapn";
            this.lblMapn.Size = new System.Drawing.Size(147, 27);
            this.lblMapn.TabIndex = 62;
            this.lblMapn.Text = "Mã sản phẩm:";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(193, 896);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(155, 49);
            this.btnLuu.TabIndex = 61;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(22, 896);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 49);
            this.btnXoa.TabIndex = 60;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lsvNhaphang
            // 
            this.lsvNhaphang.CheckBoxes = true;
            this.lsvNhaphang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvNhaphang.HideSelection = false;
            this.lsvNhaphang.Location = new System.Drawing.Point(12, 524);
            this.lsvNhaphang.Name = "lsvNhaphang";
            this.lsvNhaphang.Size = new System.Drawing.Size(1459, 353);
            this.lsvNhaphang.TabIndex = 59;
            this.lsvNhaphang.UseCompatibleStateImageBehavior = false;
            // 
            // lbltong
            // 
            this.lbltong.AutoSize = true;
            this.lbltong.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbltong.Location = new System.Drawing.Point(1287, 908);
            this.lbltong.Name = "lbltong";
            this.lbltong.Size = new System.Drawing.Size(18, 25);
            this.lbltong.TabIndex = 58;
            this.lbltong.Text = ".";
            // 
            // lbltensp
            // 
            this.lbltensp.AutoSize = true;
            this.lbltensp.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltensp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbltensp.Location = new System.Drawing.Point(1216, 186);
            this.lbltensp.Name = "lbltensp";
            this.lbltensp.Size = new System.Drawing.Size(135, 25);
            this.lbltensp.TabIndex = 56;
            this.lbltensp.Text = "Mã sản phẩm:";
            // 
            // lblmasp
            // 
            this.lblmasp.AutoSize = true;
            this.lblmasp.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmasp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblmasp.Location = new System.Drawing.Point(1216, 117);
            this.lblmasp.Name = "lblmasp";
            this.lblmasp.Size = new System.Drawing.Size(135, 25);
            this.lblmasp.TabIndex = 55;
            this.lblmasp.Text = "Mã sản phẩm:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1240, 467);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(231, 51);
            this.btnThem.TabIndex = 54;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1026, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 40);
            this.label11.TabIndex = 53;
            this.label11.Text = "Giá nhập:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1026, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 40);
            this.label10.TabIndex = 52;
            this.label10.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1026, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 40);
            this.label8.TabIndex = 50;
            this.label8.Text = "Tên sản phẩm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1026, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 40);
            this.label7.TabIndex = 49;
            this.label7.Text = "Mã sản phẩm:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(538, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 376);
            this.panel1.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 40);
            this.label6.TabIndex = 47;
            this.label6.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 40);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ngày nhập hàng:";
            // 
            // cmbTensp
            // 
            this.cmbTensp.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTensp.ForeColor = System.Drawing.Color.Maroon;
            this.cmbTensp.FormattingEnabled = true;
            this.cmbTensp.Location = new System.Drawing.Point(231, 162);
            this.cmbTensp.Name = "cmbTensp";
            this.cmbTensp.Size = new System.Drawing.Size(224, 40);
            this.cmbTensp.TabIndex = 40;
            this.cmbTensp.SelectedIndexChanged += new System.EventHandler(this.cmbTensp_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 40);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mã phiếu nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(676, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 47);
            this.label1.TabIndex = 38;
            this.label1.Text = "NHẬP HÀNG\r\n";
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.Location = new System.Drawing.Point(382, 896);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(182, 49);
            this.btnLammoi.TabIndex = 65;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // dtpkNgaynhap
            // 
            this.dtpkNgaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgaynhap.Location = new System.Drawing.Point(231, 324);
            this.dtpkNgaynhap.Name = "dtpkNgaynhap";
            this.dtpkNgaynhap.Size = new System.Drawing.Size(249, 32);
            this.dtpkNgaynhap.TabIndex = 66;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(1008, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 376);
            this.panel2.TabIndex = 69;
            // 
            // lblMancc
            // 
            this.lblMancc.AutoSize = true;
            this.lblMancc.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMancc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMancc.Location = new System.Drawing.Point(777, 114);
            this.lblMancc.Name = "lblMancc";
            this.lblMancc.Size = new System.Drawing.Size(135, 25);
            this.lblMancc.TabIndex = 71;
            this.lblMancc.Text = "Mã sản phẩm:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(562, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(204, 40);
            this.label14.TabIndex = 70;
            this.label14.Text = "Mã nhà cung cấp:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(562, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(210, 40);
            this.label15.TabIndex = 72;
            this.label15.Text = "Tên nhà cung cấp:";
            // 
            // lblTenncc
            // 
            this.lblTenncc.AutoSize = true;
            this.lblTenncc.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenncc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTenncc.Location = new System.Drawing.Point(778, 180);
            this.lblTenncc.Name = "lblTenncc";
            this.lblTenncc.Size = new System.Drawing.Size(135, 25);
            this.lblTenncc.TabIndex = 73;
            this.lblTenncc.Text = "Mã sản phẩm:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(15, 234);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(210, 40);
            this.label17.TabIndex = 75;
            this.label17.Text = "Tên nhà cung cấp:";
            // 
            // cmbTenncc
            // 
            this.cmbTenncc.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenncc.ForeColor = System.Drawing.Color.Maroon;
            this.cmbTenncc.FormattingEnabled = true;
            this.cmbTenncc.Location = new System.Drawing.Point(231, 234);
            this.cmbTenncc.Name = "cmbTenncc";
            this.cmbTenncc.Size = new System.Drawing.Size(281, 40);
            this.cmbTenncc.TabIndex = 74;
            this.cmbTenncc.SelectedIndexChanged += new System.EventHandler(this.cmbTenncc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 40);
            this.label4.TabIndex = 76;
            this.label4.Text = "Địa chỉ:";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDiachi.Location = new System.Drawing.Point(778, 245);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(135, 25);
            this.lblDiachi.TabIndex = 77;
            this.lblDiachi.Text = "Mã sản phẩm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(562, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 40);
            this.label9.TabIndex = 78;
            this.label9.Text = "SĐT:";
            // 
            // lblSĐT
            // 
            this.lblSĐT.AutoSize = true;
            this.lblSĐT.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSĐT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSĐT.Location = new System.Drawing.Point(778, 320);
            this.lblSĐT.Name = "lblSĐT";
            this.lblSĐT.Size = new System.Drawing.Size(135, 25);
            this.lblSĐT.TabIndex = 79;
            this.lblSĐT.Text = "Mã sản phẩm:";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(1221, 244);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(169, 36);
            this.txtGia.TabIndex = 80;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(1221, 367);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(169, 36);
            this.txtSoLuong.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 40);
            this.label5.TabIndex = 82;
            this.label5.Text = "Nhân viên nhập:";
            // 
            // lblManv
            // 
            this.lblManv.AutoSize = true;
            this.lblManv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblManv.Location = new System.Drawing.Point(226, 417);
            this.lblManv.Name = "lblManv";
            this.lblManv.Size = new System.Drawing.Size(50, 27);
            this.lblManv.TabIndex = 83;
            this.lblManv.Text = "Mã:";
            // 
            // lblTennv
            // 
            this.lblTennv.AutoSize = true;
            this.lblTennv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTennv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTennv.Location = new System.Drawing.Point(291, 417);
            this.lblTennv.Name = "lblTennv";
            this.lblTennv.Size = new System.Drawing.Size(147, 27);
            this.lblTennv.TabIndex = 84;
            this.lblTennv.Text = "Mã sản phẩm:";
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.Location = new System.Drawing.Point(461, 161);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(51, 43);
            this.btnThemSP.TabIndex = 85;
            this.btnThemSP.Text = "+";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtGiaban
            // 
            this.txtGiaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaban.Location = new System.Drawing.Point(1221, 304);
            this.txtGiaban.Multiline = true;
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(169, 36);
            this.txtGiaban.TabIndex = 87;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1026, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 40);
            this.label13.TabIndex = 86;
            this.label13.Text = "Giá bán:";
            // 
            // FormNhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 957);
            this.Controls.Add(this.txtGiaban);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.lblTennv);
            this.Controls.Add(this.lblManv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.lblSĐT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmbTenncc);
            this.Controls.Add(this.lblTenncc);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblMancc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtpkNgaynhap);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblMapn);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lsvNhaphang);
            this.Controls.Add(this.lbltong);
            this.Controls.Add(this.lbltensp);
            this.Controls.Add(this.lblmasp);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTensp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormNhaphang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhaphang";
            this.Load += new System.EventHandler(this.FormNhaphang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMapn;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListView lsvNhaphang;
        private System.Windows.Forms.Label lbltong;
        private System.Windows.Forms.Label lbltensp;
        private System.Windows.Forms.Label lblmasp;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTensp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.DateTimePicker dtpkNgaynhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMancc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTenncc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbTenncc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSĐT;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblManv;
        private System.Windows.Forms.Label lblTennv;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.Label label13;
    }
}