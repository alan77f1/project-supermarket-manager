
namespace WindowsFormsApp
{
    partial class UC_ThongKePhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThongkepn = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimkiemphieunhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmapn = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongkepn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 195);
            this.label1.TabIndex = 4;
            this.label1.Text = "THỐNG KÊ PHIẾU NHẬP\r\n\r\n\r\n\r\n\r\n";
            // 
            // dgvThongkepn
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvThongkepn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongkepn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongkepn.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongkepn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongkepn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongkepn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongkepn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongkepn.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongkepn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongkepn.EnableHeadersVisualStyles = false;
            this.dgvThongkepn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongkepn.Location = new System.Drawing.Point(23, 67);
            this.dgvThongkepn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThongkepn.Name = "dgvThongkepn";
            this.dgvThongkepn.ReadOnly = true;
            this.dgvThongkepn.RowHeadersVisible = false;
            this.dgvThongkepn.RowHeadersWidth = 62;
            this.dgvThongkepn.RowTemplate.Height = 28;
            this.dgvThongkepn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongkepn.Size = new System.Drawing.Size(945, 493);
            this.dgvThongkepn.TabIndex = 5;
            this.dgvThongkepn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongkepn.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongkepn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongkepn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongkepn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongkepn.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongkepn.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongkepn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.dgvThongkepn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongkepn.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvThongkepn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongkepn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongkepn.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvThongkepn.ThemeStyle.ReadOnly = true;
            this.dgvThongkepn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongkepn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongkepn.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvThongkepn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongkepn.ThemeStyle.RowsStyle.Height = 28;
            this.dgvThongkepn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongkepn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 588);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tìm kiếm:";
            // 
            // txtTimkiemphieunhap
            // 
            this.txtTimkiemphieunhap.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtTimkiemphieunhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimkiemphieunhap.BorderThickness = 2;
            this.txtTimkiemphieunhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiemphieunhap.DefaultText = "";
            this.txtTimkiemphieunhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiemphieunhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiemphieunhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemphieunhap.DisabledState.Parent = this.txtTimkiemphieunhap;
            this.txtTimkiemphieunhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemphieunhap.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTimkiemphieunhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimkiemphieunhap.FocusedState.Parent = this.txtTimkiemphieunhap;
            this.txtTimkiemphieunhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiemphieunhap.ForeColor = System.Drawing.Color.Black;
            this.txtTimkiemphieunhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemphieunhap.HoverState.Parent = this.txtTimkiemphieunhap;
            this.txtTimkiemphieunhap.Location = new System.Drawing.Point(96, 577);
            this.txtTimkiemphieunhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTimkiemphieunhap.Name = "txtTimkiemphieunhap";
            this.txtTimkiemphieunhap.PasswordChar = '\0';
            this.txtTimkiemphieunhap.PlaceholderText = "";
            this.txtTimkiemphieunhap.SelectedText = "";
            this.txtTimkiemphieunhap.ShadowDecoration.Parent = this.txtTimkiemphieunhap;
            this.txtTimkiemphieunhap.Size = new System.Drawing.Size(188, 40);
            this.txtTimkiemphieunhap.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTimkiemphieunhap.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 588);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã phiếu: ";
            // 
            // txtmapn
            // 
            this.txtmapn.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtmapn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmapn.BorderThickness = 2;
            this.txtmapn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmapn.DefaultText = "";
            this.txtmapn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmapn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmapn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmapn.DisabledState.Parent = this.txtmapn;
            this.txtmapn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmapn.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtmapn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmapn.FocusedState.Parent = this.txtmapn;
            this.txtmapn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmapn.ForeColor = System.Drawing.Color.Black;
            this.txtmapn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmapn.HoverState.Parent = this.txtmapn;
            this.txtmapn.Location = new System.Drawing.Point(409, 577);
            this.txtmapn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmapn.Name = "txtmapn";
            this.txtmapn.PasswordChar = '\0';
            this.txtmapn.PlaceholderText = "";
            this.txtmapn.SelectedText = "";
            this.txtmapn.ShadowDecoration.Parent = this.txtmapn;
            this.txtmapn.Size = new System.Drawing.Size(118, 40);
            this.txtmapn.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtmapn.TabIndex = 22;
            // 
            // txtTien
            // 
            this.txtTien.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtTien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTien.BorderThickness = 2;
            this.txtTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTien.DefaultText = "";
            this.txtTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTien.DisabledState.Parent = this.txtTien;
            this.txtTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTien.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTien.FocusedState.Parent = this.txtTien;
            this.txtTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTien.ForeColor = System.Drawing.Color.Black;
            this.txtTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTien.HoverState.Parent = this.txtTien;
            this.txtTien.Location = new System.Drawing.Point(535, 577);
            this.txtTien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTien.Name = "txtTien";
            this.txtTien.PasswordChar = '\0';
            this.txtTien.PlaceholderText = "";
            this.txtTien.SelectedText = "";
            this.txtTien.ShadowDecoration.Parent = this.txtTien;
            this.txtTien.Size = new System.Drawing.Size(389, 40);
            this.txtTien.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTien.TabIndex = 23;
            // 
            // btnCong
            // 
            this.btnCong.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCong.FlatAppearance.BorderSize = 0;
            this.btnCong.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCong.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCong.ForeColor = System.Drawing.Color.Black;
            this.btnCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCong.Location = new System.Drawing.Point(1230, 714);
            this.btnCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCong.Name = "btnCong";
            this.btnCong.Padding = new System.Windows.Forms.Padding(1);
            this.btnCong.Size = new System.Drawing.Size(45, 43);
            this.btnCong.TabIndex = 24;
            this.btnCong.Text = "  ";
            this.btnCong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCong.UseVisualStyleBackColor = false;
            // 
            // UC_ThongKePhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.txtmapn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTimkiemphieunhap);
            this.Controls.Add(this.dgvThongkepn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_ThongKePhieuNhap";
            this.Size = new System.Drawing.Size(990, 690);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongkepn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongkepn;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiemphieunhap;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtmapn;
        private Guna.UI2.WinForms.Guna2TextBox txtTien;
        private System.Windows.Forms.Button btnCong;
    }
}
