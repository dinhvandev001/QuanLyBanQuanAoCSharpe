
namespace GUI
{
    partial class DanhSachLuongNhanVien
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
            this.dgvDanhSachLuongNhanVien = new System.Windows.Forms.DataGridView();
            this.cbThoiGian = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLuongNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachLuongNhanVien
            // 
            this.dgvDanhSachLuongNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLuongNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.ThoiGian,
            this.LuongCoBan,
            this.DoanhSo,
            this.TongLuong});
            this.dgvDanhSachLuongNhanVien.Location = new System.Drawing.Point(229, 299);
            this.dgvDanhSachLuongNhanVien.Name = "dgvDanhSachLuongNhanVien";
            this.dgvDanhSachLuongNhanVien.RowHeadersWidth = 51;
            this.dgvDanhSachLuongNhanVien.RowTemplate.Height = 29;
            this.dgvDanhSachLuongNhanVien.Size = new System.Drawing.Size(816, 324);
            this.dgvDanhSachLuongNhanVien.TabIndex = 0;
            // 
            // cbThoiGian
            // 
            this.cbThoiGian.FormattingEnabled = true;
            this.cbThoiGian.Location = new System.Drawing.Point(310, 115);
            this.cbThoiGian.Name = "cbThoiGian";
            this.cbThoiGian.Size = new System.Drawing.Size(151, 28);
            this.cbThoiGian.TabIndex = 1;
            this.cbThoiGian.SelectedValueChanged += new System.EventHandler(this.cbThoiGian_SelectedValueChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(951, 114);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 29);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tim kiem";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh Sach Luong Nhan Vien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bo loc : ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(783, 115);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(143, 27);
            this.txtTimKiem.TabIndex = 5;
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
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(951, 169);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(94, 29);
            this.btnTroVe.TabIndex = 6;
            this.btnTroVe.Text = "Tro ve";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(951, 226);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nhap tu khoa : ";
            // 
            // DanhSachLuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cbThoiGian);
            this.Controls.Add(this.dgvDanhSachLuongNhanVien);
            this.Name = "DanhSachLuongNhanVien";
            this.Text = "Danh Sach Luong Nhan Vien";
            this.Load += new System.EventHandler(this.DanhSachLuongNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLuongNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachLuongNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongCoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongLuong;
        private System.Windows.Forms.ComboBox cbThoiGian;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
    }
}