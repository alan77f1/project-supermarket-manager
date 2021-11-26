
namespace WindowsFormsApp
{
    partial class FormThongTinHangMoi
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
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cmbDonvitinh = new System.Windows.Forms.ComboBox();
            this.txtTenmh = new System.Windows.Forms.TextBox();
            this.cmbMaĐVT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaHang
            // 
            this.txtMaHang.Enabled = false;
            this.txtMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang.Location = new System.Drawing.Point(277, 111);
            this.txtMaHang.Multiline = true;
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.ReadOnly = true;
            this.txtMaHang.Size = new System.Drawing.Size(183, 35);
            this.txtMaHang.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 40);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã MH:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên mặt hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 40);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã đơn vị tính:";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(645, 449);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(189, 49);
            this.btnLuu.TabIndex = 62;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cmbDonvitinh
            // 
            this.cmbDonvitinh.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDonvitinh.ForeColor = System.Drawing.Color.Maroon;
            this.cmbDonvitinh.FormattingEnabled = true;
            this.cmbDonvitinh.Location = new System.Drawing.Point(276, 347);
            this.cmbDonvitinh.Name = "cmbDonvitinh";
            this.cmbDonvitinh.Size = new System.Drawing.Size(300, 40);
            this.cmbDonvitinh.TabIndex = 75;
            // 
            // txtTenmh
            // 
            this.txtTenmh.Font = new System.Drawing.Font("Sitka Banner", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenmh.Location = new System.Drawing.Point(277, 186);
            this.txtTenmh.Multiline = true;
            this.txtTenmh.Name = "txtTenmh";
            this.txtTenmh.Size = new System.Drawing.Size(299, 38);
            this.txtTenmh.TabIndex = 76;
            // 
            // cmbMaĐVT
            // 
            this.cmbMaĐVT.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMaĐVT.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaĐVT.ForeColor = System.Drawing.Color.Maroon;
            this.cmbMaĐVT.FormattingEnabled = true;
            this.cmbMaĐVT.Location = new System.Drawing.Point(277, 261);
            this.cmbMaĐVT.Name = "cmbMaĐVT";
            this.cmbMaĐVT.Size = new System.Drawing.Size(300, 40);
            this.cmbMaĐVT.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 40);
            this.label4.TabIndex = 78;
            this.label4.Text = "Tên đơn vị tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(331, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(321, 47);
            this.label6.TabIndex = 90;
            this.label6.Text = "NHẬP MỚI HÀNG HÓA";
            // 
            // FormThongtinhangmoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 540);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMaĐVT);
            this.Controls.Add(this.txtTenmh);
            this.Controls.Add(this.cmbDonvitinh);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHang);
            this.Name = "FormThongtinhangmoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongtinhangmoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cmbDonvitinh;
        private System.Windows.Forms.TextBox txtTenmh;
        private System.Windows.Forms.ComboBox cmbMaĐVT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}