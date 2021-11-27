
namespace WindowsFormsApp
{
    partial class UC_CaLamViec
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelcanhbao = new System.Windows.Forms.Label();
            this.dgvQuanlypgc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtCa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaCLV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dpkNgayLam = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlypgc)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelcanhbao
            // 
            this.labelcanhbao.AutoSize = true;
            this.labelcanhbao.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcanhbao.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelcanhbao.Location = new System.Drawing.Point(497, 708);
            this.labelcanhbao.Name = "labelcanhbao";
            this.labelcanhbao.Size = new System.Drawing.Size(159, 29);
            this.labelcanhbao.TabIndex = 45;
            this.labelcanhbao.Text = "Thêm thành công";
            // 
            // dgvQuanlypgc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvQuanlypgc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuanlypgc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuanlypgc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanlypgc.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuanlypgc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQuanlypgc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQuanlypgc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanlypgc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuanlypgc.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuanlypgc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuanlypgc.EnableHeadersVisualStyles = false;
            this.dgvQuanlypgc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQuanlypgc.Location = new System.Drawing.Point(21, 268);
            this.dgvQuanlypgc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQuanlypgc.Name = "dgvQuanlypgc";
            this.dgvQuanlypgc.ReadOnly = true;
            this.dgvQuanlypgc.RowHeadersVisible = false;
            this.dgvQuanlypgc.RowHeadersWidth = 62;
            this.dgvQuanlypgc.RowTemplate.Height = 28;
            this.dgvQuanlypgc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanlypgc.Size = new System.Drawing.Size(961, 280);
            this.dgvQuanlypgc.TabIndex = 44;
            this.dgvQuanlypgc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQuanlypgc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQuanlypgc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQuanlypgc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQuanlypgc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQuanlypgc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvQuanlypgc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQuanlypgc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.dgvQuanlypgc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQuanlypgc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQuanlypgc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQuanlypgc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvQuanlypgc.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvQuanlypgc.ThemeStyle.ReadOnly = true;
            this.dgvQuanlypgc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQuanlypgc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQuanlypgc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQuanlypgc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQuanlypgc.ThemeStyle.RowsStyle.Height = 28;
            this.dgvQuanlypgc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQuanlypgc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 29);
            this.label7.TabIndex = 43;
            this.label7.Text = "Tìm kiếm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mã Ca làm việc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(599, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 29);
            this.label3.TabIndex = 46;
            this.label3.Text = "Ca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(379, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 28);
            this.label5.TabIndex = 49;
            this.label5.Text = "(*)";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnXoa.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::WindowsFormsApp.Properties.Resources.Xoa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(844, 590);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 46);
            this.btnXoa.TabIndex = 208;
            this.btnXoa.Text = "  Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = global::WindowsFormsApp.Properties.Resources.LamMoi;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(452, 590);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 55);
            this.btnLamMoi.TabIndex = 205;
            this.btnLamMoi.Text = "    Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // txtCa
            // 
            this.txtCa.BorderColor = System.Drawing.Color.Black;
            this.txtCa.BorderRadius = 10;
            this.txtCa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCa.DefaultText = "";
            this.txtCa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCa.DisabledState.Parent = this.txtCa;
            this.txtCa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCa.FocusedState.Parent = this.txtCa;
            this.txtCa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCa.HoverState.Parent = this.txtCa;
            this.txtCa.Location = new System.Drawing.Point(663, 147);
            this.txtCa.Name = "txtCa";
            this.txtCa.PasswordChar = '\0';
            this.txtCa.PlaceholderText = "";
            this.txtCa.SelectedText = "";
            this.txtCa.ShadowDecoration.Parent = this.txtCa;
            this.txtCa.Size = new System.Drawing.Size(211, 31);
            this.txtCa.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCa.TabIndex = 218;
            // 
            // txtMaCLV
            // 
            this.txtMaCLV.BorderColor = System.Drawing.Color.Black;
            this.txtMaCLV.BorderRadius = 10;
            this.txtMaCLV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaCLV.DefaultText = "";
            this.txtMaCLV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaCLV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaCLV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaCLV.DisabledState.Parent = this.txtMaCLV;
            this.txtMaCLV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaCLV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaCLV.FocusedState.Parent = this.txtMaCLV;
            this.txtMaCLV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaCLV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaCLV.HoverState.Parent = this.txtMaCLV;
            this.txtMaCLV.Location = new System.Drawing.Point(149, 78);
            this.txtMaCLV.Name = "txtMaCLV";
            this.txtMaCLV.PasswordChar = '\0';
            this.txtMaCLV.PlaceholderText = "";
            this.txtMaCLV.SelectedText = "";
            this.txtMaCLV.ShadowDecoration.Parent = this.txtMaCLV;
            this.txtMaCLV.Size = new System.Drawing.Size(211, 31);
            this.txtMaCLV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMaCLV.TabIndex = 219;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderColor = System.Drawing.Color.Black;
            this.txtTimKiem.BorderRadius = 10;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.Parent = this.txtTimKiem;
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusedState.Parent = this.txtTimKiem;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.HoverState.Parent = this.txtTimKiem;
            this.txtTimKiem.Location = new System.Drawing.Point(132, 192);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(201, 31);
            this.txtTimKiem.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTimKiem.TabIndex = 220;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnSua.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = global::WindowsFormsApp.Properties.Resources.Sua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(724, 590);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(114, 46);
            this.btnSua.TabIndex = 217;
            this.btnSua.Text = "  Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnThem.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::WindowsFormsApp.Properties.Resources.Them;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(590, 590);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 46);
            this.btnThem.TabIndex = 206;
            this.btnThem.Text = "   Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 222;
            this.label4.Text = "Ngày làm việc:";
            // 
            // dpkNgayLam
            // 
            this.dpkNgayLam.BorderColor = System.Drawing.Color.Maroon;
            this.dpkNgayLam.BorderRadius = 3;
            this.dpkNgayLam.BorderThickness = 2;
            this.dpkNgayLam.Checked = true;
            this.dpkNgayLam.CheckedState.Parent = this.dpkNgayLam;
            this.dpkNgayLam.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dpkNgayLam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dpkNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkNgayLam.HoverState.Parent = this.dpkNgayLam;
            this.dpkNgayLam.Location = new System.Drawing.Point(690, 87);
            this.dpkNgayLam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpkNgayLam.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpkNgayLam.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpkNgayLam.Name = "dpkNgayLam";
            this.dpkNgayLam.ShadowDecoration.Parent = this.dpkNgayLam;
            this.dpkNgayLam.Size = new System.Drawing.Size(152, 37);
            this.dpkNgayLam.TabIndex = 224;
            this.dpkNgayLam.Value = new System.DateTime(2021, 10, 25, 21, 55, 52, 140);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 56);
            this.panel3.TabIndex = 225;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(323, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 40);
            this.label6.TabIndex = 183;
            this.label6.Text = "THÔNG TIN CA LÀM VIỆC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 226;
            this.label1.Text = "Mã NV:";
            // 
            // MaNV
            // 
            this.MaNV.BorderColor = System.Drawing.Color.Black;
            this.MaNV.BorderRadius = 10;
            this.MaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaNV.DefaultText = "";
            this.MaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaNV.DisabledState.Parent = this.MaNV;
            this.MaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaNV.FocusedState.Parent = this.MaNV;
            this.MaNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaNV.HoverState.Parent = this.MaNV;
            this.MaNV.Location = new System.Drawing.Point(132, 131);
            this.MaNV.Name = "MaNV";
            this.MaNV.PasswordChar = '\0';
            this.MaNV.PlaceholderText = "";
            this.MaNV.SelectedText = "";
            this.MaNV.ShadowDecoration.Parent = this.MaNV;
            this.MaNV.Size = new System.Drawing.Size(201, 31);
            this.MaNV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.MaNV.TabIndex = 227;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UC_CaLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dpkNgayLam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtMaCLV);
            this.Controls.Add(this.txtCa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelcanhbao);
            this.Controls.Add(this.dgvQuanlypgc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_CaLamViec";
            this.Size = new System.Drawing.Size(1010, 662);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlypgc)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelcanhbao;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQuanlypgc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private Guna.UI2.WinForms.Guna2TextBox txtCa;
        private Guna.UI2.WinForms.Guna2TextBox txtMaCLV;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpkNgayLam;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox MaNV;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
