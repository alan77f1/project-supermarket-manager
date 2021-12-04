
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelcanhbao = new System.Windows.Forms.Label();
            this.dgvQuanlypgc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaCLV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.dpkNgayLam = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.MaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvQuanlypgc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvQuanlypgc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuanlypgc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanlypgc.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuanlypgc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQuanlypgc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQuanlypgc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanlypgc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvQuanlypgc.ColumnHeadersHeight = 35;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuanlypgc.DefaultCellStyle = dataGridViewCellStyle12;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(417, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 28);
            this.label5.TabIndex = 49;
            this.label5.Text = "(*)";
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
            this.txtCa.Location = new System.Drawing.Point(663, 121);
            this.txtCa.Name = "txtCa";
            this.txtCa.PasswordChar = '\0';
            this.txtCa.PlaceholderText = "";
            this.txtCa.SelectedText = "";
            this.txtCa.ShadowDecoration.Parent = this.txtCa;
            this.txtCa.Size = new System.Drawing.Size(256, 31);
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
            this.txtMaCLV.Location = new System.Drawing.Point(135, 78);
            this.txtMaCLV.Name = "txtMaCLV";
            this.txtMaCLV.PasswordChar = '\0';
            this.txtMaCLV.PlaceholderText = "";
            this.txtMaCLV.SelectedText = "";
            this.txtMaCLV.ShadowDecoration.Parent = this.txtMaCLV;
            this.txtMaCLV.Size = new System.Drawing.Size(276, 31);
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
            this.txtTimKiem.Location = new System.Drawing.Point(135, 201);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(276, 31);
            this.txtTimKiem.TabIndex = 220;
            // 
            // dpkNgayLam
            // 
            this.dpkNgayLam.BorderRadius = 10;
            this.dpkNgayLam.BorderThickness = 1;
            this.dpkNgayLam.Checked = true;
            this.dpkNgayLam.CheckedState.Parent = this.dpkNgayLam;
            this.dpkNgayLam.FillColor = System.Drawing.Color.White;
            this.dpkNgayLam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dpkNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkNgayLam.HoverState.Parent = this.dpkNgayLam;
            this.dpkNgayLam.Location = new System.Drawing.Point(663, 75);
            this.dpkNgayLam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpkNgayLam.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpkNgayLam.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpkNgayLam.Name = "dpkNgayLam";
            this.dpkNgayLam.ShadowDecoration.Parent = this.dpkNgayLam;
            this.dpkNgayLam.Size = new System.Drawing.Size(256, 37);
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
            this.MaNV.Location = new System.Drawing.Point(135, 115);
            this.MaNV.Name = "MaNV";
            this.MaNV.PasswordChar = '\0';
            this.MaNV.PlaceholderText = "";
            this.MaNV.SelectedText = "";
            this.MaNV.ShadowDecoration.Parent = this.MaNV;
            this.MaNV.Size = new System.Drawing.Size(276, 31);
            this.MaNV.TabIndex = 227;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoRoundedCorners = true;
            this.btnXoa.BorderRadius = 23;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.DisabledState.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.btnXoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnXoa.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(858, 582);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(124, 48);
            this.btnXoa.TabIndex = 240;
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.AutoRoundedCorners = true;
            this.btnSua.BorderRadius = 23;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.DisabledState.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.btnSua.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSua.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Location = new System.Drawing.Point(708, 582);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(124, 48);
            this.btnSua.TabIndex = 239;
            this.btnSua.Text = "Sửa";
            // 
            // btnThem
            // 
            this.btnThem.AutoRoundedCorners = true;
            this.btnThem.BorderRadius = 23;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.DisabledState.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.btnThem.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnThem.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(559, 582);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(124, 48);
            this.btnThem.TabIndex = 238;
            this.btnThem.Text = "Thêm";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AutoRoundedCorners = true;
            this.btnLamMoi.BorderRadius = 23;
            this.btnLamMoi.CheckedState.Parent = this.btnLamMoi;
            this.btnLamMoi.CustomImages.Parent = this.btnLamMoi;
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.DisabledState.Parent = this.btnLamMoi;
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.btnLamMoi.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnLamMoi.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnLamMoi.HoverState.Parent = this.btnLamMoi;
            this.btnLamMoi.Location = new System.Drawing.Point(405, 582);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShadowDecoration.Parent = this.btnLamMoi;
            this.btnLamMoi.Size = new System.Drawing.Size(124, 48);
            this.btnLamMoi.TabIndex = 237;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(17, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 241;
            this.label8.Text = "Mã CLV :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(38, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 242;
            this.label9.Text = "Mã NV :";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(589, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 25);
            this.label11.TabIndex = 244;
            this.label11.Text = "Ca :";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(11, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 25);
            this.label10.TabIndex = 245;
            this.label10.Text = "Tìm kiếm :";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(512, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 25);
            this.label12.TabIndex = 246;
            this.label12.Text = "Ngày làm việc :";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(38, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 25);
            this.label13.TabIndex = 247;
            this.label13.Text = "Tên NV :";
            // 
            // btnTenNV
            // 
            this.btnTenNV.BorderColor = System.Drawing.Color.Black;
            this.btnTenNV.BorderRadius = 10;
            this.btnTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnTenNV.DefaultText = "";
            this.btnTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnTenNV.DisabledState.Parent = this.btnTenNV;
            this.btnTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTenNV.FocusedState.Parent = this.btnTenNV;
            this.btnTenNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTenNV.HoverState.Parent = this.btnTenNV;
            this.btnTenNV.Location = new System.Drawing.Point(135, 155);
            this.btnTenNV.Name = "btnTenNV";
            this.btnTenNV.PasswordChar = '\0';
            this.btnTenNV.PlaceholderText = "";
            this.btnTenNV.SelectedText = "";
            this.btnTenNV.ShadowDecoration.Parent = this.btnTenNV;
            this.btnTenNV.Size = new System.Drawing.Size(276, 31);
            this.btnTenNV.TabIndex = 248;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(417, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 28);
            this.label2.TabIndex = 250;
            this.label2.Text = "(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(925, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 28);
            this.label3.TabIndex = 251;
            this.label3.Text = "(*)";
            // 
            // UC_CaLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTenNV);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dpkNgayLam);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtMaCLV);
            this.Controls.Add(this.txtCa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelcanhbao);
            this.Controls.Add(this.dgvQuanlypgc);
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
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtCa;
        private Guna.UI2.WinForms.Guna2TextBox txtMaCLV;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpkNgayLam;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox MaNV;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private Guna.UI2.WinForms.Guna2GradientButton btnLamMoi;
        private Guna.UI2.WinForms.Guna2TextBox btnTenNV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
