
namespace WindowsFormsApp
{
    partial class UC_ThongKeHangHoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThongkehh = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnTangTon = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimkiemhanghoa = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongkehh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ HÀNG HÓA\r\n\r\n";
            // 
            // dgvThongkehh
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvThongkehh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThongkehh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongkehh.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongkehh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongkehh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongkehh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongkehh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvThongkehh.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongkehh.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvThongkehh.EnableHeadersVisualStyles = false;
            this.dgvThongkehh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongkehh.Location = new System.Drawing.Point(22, 74);
            this.dgvThongkehh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThongkehh.Name = "dgvThongkehh";
            this.dgvThongkehh.ReadOnly = true;
            this.dgvThongkehh.RowHeadersVisible = false;
            this.dgvThongkehh.RowHeadersWidth = 62;
            this.dgvThongkehh.RowTemplate.Height = 28;
            this.dgvThongkehh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongkehh.Size = new System.Drawing.Size(947, 539);
            this.dgvThongkehh.TabIndex = 2;
            this.dgvThongkehh.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongkehh.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongkehh.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongkehh.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongkehh.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongkehh.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongkehh.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongkehh.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.dgvThongkehh.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongkehh.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvThongkehh.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongkehh.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongkehh.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvThongkehh.ThemeStyle.ReadOnly = true;
            this.dgvThongkehh.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongkehh.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongkehh.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvThongkehh.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongkehh.ThemeStyle.RowsStyle.Height = 28;
            this.dgvThongkehh.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongkehh.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnTangTon
            // 
            this.btnTangTon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTangTon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTangTon.FlatAppearance.BorderSize = 0;
            this.btnTangTon.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnTangTon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTangTon.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangTon.ForeColor = System.Drawing.Color.Black;
            this.btnTangTon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTangTon.Location = new System.Drawing.Point(1227, 14);
            this.btnTangTon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTangTon.Name = "btnTangTon";
            this.btnTangTon.Padding = new System.Windows.Forms.Padding(1);
            this.btnTangTon.Size = new System.Drawing.Size(45, 43);
            this.btnTangTon.TabIndex = 11;
            this.btnTangTon.Text = "  ";
            this.btnTangTon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTangTon.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 629);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tìm kiếm:";
            // 
            // txtTimkiemhanghoa
            // 
            this.txtTimkiemhanghoa.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtTimkiemhanghoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimkiemhanghoa.BorderThickness = 2;
            this.txtTimkiemhanghoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiemhanghoa.DefaultText = "";
            this.txtTimkiemhanghoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiemhanghoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiemhanghoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemhanghoa.DisabledState.Parent = this.txtTimkiemhanghoa;
            this.txtTimkiemhanghoa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemhanghoa.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTimkiemhanghoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimkiemhanghoa.FocusedState.Parent = this.txtTimkiemhanghoa;
            this.txtTimkiemhanghoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiemhanghoa.ForeColor = System.Drawing.Color.Black;
            this.txtTimkiemhanghoa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemhanghoa.HoverState.Parent = this.txtTimkiemhanghoa;
            this.txtTimkiemhanghoa.Location = new System.Drawing.Point(121, 618);
            this.txtTimkiemhanghoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTimkiemhanghoa.Name = "txtTimkiemhanghoa";
            this.txtTimkiemhanghoa.PasswordChar = '\0';
            this.txtTimkiemhanghoa.PlaceholderText = "";
            this.txtTimkiemhanghoa.SelectedText = "";
            this.txtTimkiemhanghoa.ShadowDecoration.Parent = this.txtTimkiemhanghoa;
            this.txtTimkiemhanghoa.Size = new System.Drawing.Size(372, 40);
            this.txtTimkiemhanghoa.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTimkiemhanghoa.TabIndex = 19;
            // 
            // UC_ThongKeHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTimkiemhanghoa);
            this.Controls.Add(this.btnTangTon);
            this.Controls.Add(this.dgvThongkehh);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_ThongKeHangHoa";
            this.Size = new System.Drawing.Size(990, 690);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongkehh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongkehh;
        private System.Windows.Forms.Button btnTangTon;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiemhanghoa;
    }
}
