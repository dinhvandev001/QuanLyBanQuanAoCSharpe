
namespace GUI
{
    partial class DanhSachKhachHang
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvDanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(929, 105);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 29);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tim kiem";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(929, 166);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(94, 29);
            this.btnTroVe.TabIndex = 1;
            this.btnTroVe.Text = "Tro ve";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(929, 230);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvDanhSachKhachHang
            // 
            this.dgvDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhachHang,
            this.TenKhachHang,
            this.SoDienThoai});
            this.dgvDanhSachKhachHang.Location = new System.Drawing.Point(201, 321);
            this.dgvDanhSachKhachHang.Name = "dgvDanhSachKhachHang";
            this.dgvDanhSachKhachHang.RowHeadersWidth = 51;
            this.dgvDanhSachKhachHang.RowTemplate.Height = 29;
            this.dgvDanhSachKhachHang.Size = new System.Drawing.Size(822, 308);
            this.dgvDanhSachKhachHang.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh Sach Khach Hang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhap tu khoa : ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(747, 106);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(141, 27);
            this.txtTimKiem.TabIndex = 8;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Ma khach hang";
            this.MaKhachHang.MinimumWidth = 6;
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Width = 200;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Ten khach hang";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Width = 200;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "So dien thoai";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            // 
            // DanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachKhachHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "DanhSachKhachHang";
            this.Text = "Danh Sach Khach Hang";
            this.Load += new System.EventHandler(this.DanhSachKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDanhSachKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
    }
}