
namespace GUI
{
    partial class DanhSachHangTrongKho
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
            this.cbKichThuoc = new System.Windows.Forms.ComboBox();
            this.dgvDanhSachHangTrongKho = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.MaHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KichThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMaLoaiHangHoa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHangTrongKho)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(998, 121);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 29);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tim kiem";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(998, 178);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(94, 29);
            this.btnTroVe.TabIndex = 1;
            this.btnTroVe.Text = "Tro ve";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(998, 238);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbKichThuoc
            // 
            this.cbKichThuoc.FormattingEnabled = true;
            this.cbKichThuoc.Location = new System.Drawing.Point(231, 122);
            this.cbKichThuoc.Name = "cbKichThuoc";
            this.cbKichThuoc.Size = new System.Drawing.Size(151, 28);
            this.cbKichThuoc.TabIndex = 3;
            this.cbKichThuoc.SelectedValueChanged += new System.EventHandler(this.cbKichThuoc_SelectedValueChanged);
            // 
            // dgvDanhSachHangTrongKho
            // 
            this.dgvDanhSachHangTrongKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHangTrongKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHangHoa,
            this.TenHangHoa,
            this.KichThuoc,
            this.GiaNhap,
            this.MaLoaiHangHoa,
            this.GiaBan,
            this.SoLuong,
            this.GhiChu});
            this.dgvDanhSachHangTrongKho.Location = new System.Drawing.Point(152, 318);
            this.dgvDanhSachHangTrongKho.Name = "dgvDanhSachHangTrongKho";
            this.dgvDanhSachHangTrongKho.RowHeadersWidth = 51;
            this.dgvDanhSachHangTrongKho.RowTemplate.Height = 29;
            this.dgvDanhSachHangTrongKho.Size = new System.Drawing.Size(940, 317);
            this.dgvDanhSachHangTrongKho.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh Sach Hang Trong Kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bo loc : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(689, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhap tu khoa : ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(819, 122);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(143, 27);
            this.txtTimKiem.TabIndex = 8;
            // 
            // MaHangHoa
            // 
            this.MaHangHoa.DataPropertyName = "MaHangHoa";
            this.MaHangHoa.HeaderText = "Ma hang hoa";
            this.MaHangHoa.MinimumWidth = 6;
            this.MaHangHoa.Name = "MaHangHoa";
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.DataPropertyName = "TenHangHoa";
            this.TenHangHoa.HeaderText = "Ten hang hoa";
            this.TenHangHoa.MinimumWidth = 6;
            this.TenHangHoa.Name = "TenHangHoa";
            this.TenHangHoa.Width = 125;
            // 
            // KichThuoc
            // 
            this.KichThuoc.DataPropertyName = "KichThuoc";
            this.KichThuoc.HeaderText = "Kich thuoc";
            this.KichThuoc.MinimumWidth = 6;
            this.KichThuoc.Name = "KichThuoc";
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Gia nhap";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            // 
            // MaLoaiHangHoa
            // 
            this.MaLoaiHangHoa.DataPropertyName = "MaLoaiHangHoa";
            this.MaLoaiHangHoa.HeaderText = "Ma loai hang hoa";
            this.MaLoaiHangHoa.MinimumWidth = 6;
            this.MaLoaiHangHoa.Name = "MaLoaiHangHoa";
            this.MaLoaiHangHoa.Width = 125;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Gia ban";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "So luong";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chu";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            // 
            // cbMaLoaiHangHoa
            // 
            this.cbMaLoaiHangHoa.FormattingEnabled = true;
            this.cbMaLoaiHangHoa.Location = new System.Drawing.Point(419, 122);
            this.cbMaLoaiHangHoa.Name = "cbMaLoaiHangHoa";
            this.cbMaLoaiHangHoa.Size = new System.Drawing.Size(151, 28);
            this.cbMaLoaiHangHoa.TabIndex = 9;
            this.cbMaLoaiHangHoa.SelectedValueChanged += new System.EventHandler(this.cbMaLoaiHangHoa_SelectedValueChanged);
            // 
            // DanhSachHangTrongKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.cbMaLoaiHangHoa);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachHangTrongKho);
            this.Controls.Add(this.cbKichThuoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "DanhSachHangTrongKho";
            this.Text = "Danh Sach Hang Trong Kho";
            this.Load += new System.EventHandler(this.DanhSachHangTrongKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHangTrongKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbKichThuoc;
        private System.Windows.Forms.DataGridView dgvDanhSachHangTrongKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn KichThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.ComboBox cbMaLoaiHangHoa;
    }
}