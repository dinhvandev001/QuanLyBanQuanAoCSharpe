
namespace GUI
{
    partial class LuongNhanVien
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvLuongNhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(943, 194);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvLuongNhanVien
            // 
            this.dgvLuongNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuongNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.ThoiGian,
            this.LuongCoBan,
            this.DoanhSo,
            this.TongLuong});
            this.dgvLuongNhanVien.Location = new System.Drawing.Point(223, 309);
            this.dgvLuongNhanVien.Name = "dgvLuongNhanVien";
            this.dgvLuongNhanVien.RowHeadersWidth = 51;
            this.dgvLuongNhanVien.RowTemplate.Height = 29;
            this.dgvLuongNhanVien.Size = new System.Drawing.Size(814, 296);
            this.dgvLuongNhanVien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Luong Nhan Vien";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Ma nhan vien";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 125;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Ten nhan vien";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Width = 125;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Thoi gian";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.Width = 125;
            // 
            // LuongCoBan
            // 
            this.LuongCoBan.DataPropertyName = "LuongCoBan";
            this.LuongCoBan.HeaderText = "Luong co ban";
            this.LuongCoBan.MinimumWidth = 6;
            this.LuongCoBan.Name = "LuongCoBan";
            this.LuongCoBan.Width = 125;
            // 
            // DoanhSo
            // 
            this.DoanhSo.DataPropertyName = "DoanhSo";
            this.DoanhSo.HeaderText = "Doanh so";
            this.DoanhSo.MinimumWidth = 6;
            this.DoanhSo.Name = "DoanhSo";
            this.DoanhSo.Width = 125;
            // 
            // TongLuong
            // 
            this.TongLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongLuong.DataPropertyName = "TongLuong";
            this.TongLuong.HeaderText = "Tong luong";
            this.TongLuong.MinimumWidth = 6;
            this.TongLuong.Name = "TongLuong";
            // 
            // LuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLuongNhanVien);
            this.Controls.Add(this.btnThoat);
            this.Name = "LuongNhanVien";
            this.Text = "Luong Nhan Vien";
            this.Load += new System.EventHandler(this.LuongNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvLuongNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongCoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongLuong;
    }
}